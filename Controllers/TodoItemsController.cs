using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoItemsController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/todoitems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        {
            return await _context.todoitems
                .FromSqlRaw("SELECT * FROM TodoItems")
                .ToListAsync();
        }

        // GET: api/todoitem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetToDoItem(long id)
        {
            var todoItem = await _context.todoitems
                .FromSqlRaw("SELECT * FROM todoitems WHERE Id = {0}", id)
                .FirstOrDefaultAsync();

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        // PUT: api/TodoItems/5
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        {
            string sql = "INSERT INTO todoitems (Name, Is_Complete) VALUES (@p0, @p1)";

            await _context.Database.ExecuteSqlRawAsync(sql, todoItem.name, todoItem.is_complete);

            return CreatedAtAction(nameof(GetTodoItems), new { id = todoItem.id}, todoItem);

        }
        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(long id)
        {
            var todoItem = await _context.todoitems.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.todoitems.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TodoItemExists(long id)
        {
            return _context.todoitems.Any(e => e.id == id);
        }
    }
}

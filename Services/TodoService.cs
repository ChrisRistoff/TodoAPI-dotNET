using Npgsql;
using TodoApi.Models;

public class TodoService
{
    private string connectionString;

    public TodoService(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public List<TodoItem> GetAllTodos()
    {
        var todos = new List<TodoItem>();

        using var conn = new NpgsqlConnection(connectionString);
        conn.Open();

        using var cmd = new NpgsqlCommand("SELECT * FROM todos", conn);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            todos.Add(new TodoItem
            {
                name = reader.GetString(1),
                is_complete = reader.GetBoolean(2)
            });
        }

        return todos;
    }
}

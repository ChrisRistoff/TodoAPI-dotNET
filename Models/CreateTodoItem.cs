namespace TodoApi.Models;

public class CreateTodoItem
{
    public string name {get; set;}
    public bool is_complete { get; set; } = false;
}

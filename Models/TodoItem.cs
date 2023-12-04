namespace TodoApi.Models
{
    public class TodoItem
    {
        public long id { get; set; }
        public string? name { get; set; }
        public bool is_complete { get; set; }
    }
}

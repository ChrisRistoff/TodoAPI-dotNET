using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public TodoItem()
        {
        }

        public TodoItem(string? name)
        {
            this.name = name;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }
        public string? name { get; set; }
        public bool is_complete { get; set; } = false;
    }
}

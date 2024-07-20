using System.ComponentModel.DataAnnotations;

namespace Quiz_app.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Displayquiz { get; set; }

    }
}

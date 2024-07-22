using System.ComponentModel.DataAnnotations;

namespace EMSWeb.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public int Salary { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}

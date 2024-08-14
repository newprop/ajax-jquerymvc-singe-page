using System.ComponentModel.DataAnnotations;

namespace Mithuvai.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

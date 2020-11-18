using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Maximum Length cannot exceed 50")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Office Email")]
        [MaxLength(50, ErrorMessage = "Maximum Length cannot exceed 50")]
        public string Email { get; set; }
        [Required]
        public Element? Element { get; set; }
        [MaxLength(256)]
        public string PhotoPath { get; set; }
    }
}

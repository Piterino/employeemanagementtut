using System.ComponentModel.DataAnnotations;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;

namespace EmployeeManagement.ViewModels
{
    public class EmployeeCreateViewModel
    {
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
        public IFormFile Photo { get; set; }
    }
}

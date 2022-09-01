using System.ComponentModel.DataAnnotations;

namespace ExempelProject.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(4, ErrorMessage ="Too Short!")]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Subject { get; set; }
        [Required]
        [MaxLength(250)]
        public string? Message { get; set; }
    }
}

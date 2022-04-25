using System.ComponentModel.DataAnnotations;

namespace SwaggerApi.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Usernmae is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
    }
}

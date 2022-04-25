using System.ComponentModel.DataAnnotations;

namespace SwaggerApi.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Usernmae is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}

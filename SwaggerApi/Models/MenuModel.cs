using System.ComponentModel.DataAnnotations;

namespace SwaggerApi.Models
{
    public class MenuModel
    {
        [Key]
        public int MenuID { get; set; }

        [Required(ErrorMessage = "Menu Name is required.")]
        public string Name { get; set; }

        public bool IsActive { get; set; }
    }
}

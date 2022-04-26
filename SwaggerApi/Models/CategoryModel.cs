using System.ComponentModel.DataAnnotations;

namespace SwaggerApi.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Category Name is required.")]
        public string Name { get; set; }

        public bool IsActive { get; set; }
    }
}

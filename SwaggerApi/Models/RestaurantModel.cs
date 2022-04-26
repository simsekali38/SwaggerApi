using System.ComponentModel.DataAnnotations;

namespace SwaggerApi.Models
{
    public class RestaurantModel
    {

        [Key]
        public int RestaurantID { get; set; }

        [Required(ErrorMessage = "Category Name is required.")]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Restaurant Name is required.")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
    }
}

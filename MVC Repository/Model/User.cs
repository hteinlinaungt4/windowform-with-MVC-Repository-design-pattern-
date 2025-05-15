using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace MVC_Repository.Model
{
    public class User
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(10, ErrorMessage = "Name must be under 10 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(20, ErrorMessage = "City must be under 20 characters")]
        public string City { get; set; }

        [Required(ErrorMessage = "Image is required")]
        public string Image { get; set; }
    }
}

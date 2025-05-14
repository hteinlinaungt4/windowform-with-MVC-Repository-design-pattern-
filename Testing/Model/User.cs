using System.ComponentModel.DataAnnotations;
namespace Testing.Model
{
    public class User
    {

        public int Id { get; set; }


        [Required(ErrorMessage = "Name is required")]
        [StringLength(20,ErrorMessage = "You must be under 20 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(20,ErrorMessage ="You must be under 20 characters")]
        public string City { get; set; }

    }
}

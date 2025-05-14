using System.ComponentModel.DataAnnotations;
namespace Repository.Model
{

    public class UserModel
    {
            public int Id { get; set; }
    
            [Required(ErrorMessage = "Name is required")]
            [StringLength(10, ErrorMessage = "Name must be under 10 characters")]
            public string Name { get; set; }

            [Required(ErrorMessage = "City is required")]
            [StringLength(50, ErrorMessage = "City must be under 10 characters")]
            public string City { get; set; }

    }

}

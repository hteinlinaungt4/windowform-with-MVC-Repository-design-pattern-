
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using MVC_Repository.Model;
using MVC_Repository.Repository;

namespace MVC_Repository.Controller
{
    public class UserController
    {
        private readonly UserRepository _userRepository;


        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        private List<ValidationResult> ValidateModel(User user)
        {
            var context = new ValidationContext(user, null, null);
            var results = new List<ValidationResult>();
            Validator.TryValidateObject(user, context, results, true);
            return results;
        }
        public async Task<string> CreateUser(User user)
        {
            var errors = ValidateModel(user);
            if (errors.Count > 0)
                return string.Join("\n", errors.ConvertAll(e => e.ErrorMessage));

            return await _userRepository.CreateUser(user);
        }

        public async Task<List<User>> GetUsers()
        {
            return await _userRepository.GetUsers();
        }

        public async Task<string> UpdateUser(User user)
        {
            var errors = ValidateModel(user);
            if (errors.Count > 0)
                return string.Join("\n", errors.ConvertAll(e => e.ErrorMessage));
            return await _userRepository.UpdateUser(user);
        }

        public async Task<string> DeleteUser(int id)
        {
            return await _userRepository.DeleteUser(id);
        }

    }
}

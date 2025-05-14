using System.Collections.Generic;
using System.Threading.Tasks;
using Repository.Model;
using System.ComponentModel.DataAnnotations;
using Repository.Contract;
namespace Repository.Controller
{
    public class UserController
    {
        private readonly UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // Validate model using DataAnnotations
        private List<ValidationResult> ValidateModel(UserModel user)
        {
            var context = new ValidationContext(user, null, null);
            var results = new List<ValidationResult>();
            Validator.TryValidateObject(user, context, results, true);
            return results;
        }

        public async Task<string> AddUserAsync(UserModel user)
        {
            var errors = ValidateModel(user);
            if (errors.Count > 0)
                return string.Join("\n", errors.ConvertAll(e => e.ErrorMessage));

            return await _userRepository.AddUserAsync(user);
        }

        public async Task<string> UpdateUserAsync(UserModel user)
        {
            var errors = ValidateModel(user);
            if (errors.Count > 0)
                return string.Join("\n", errors.ConvertAll(e => e.ErrorMessage));

            return await _userRepository.UpdateUserAsync(user);
        }

        public async Task<string> DeleteUserAsync(int id)
        {
            return await _userRepository.DeleteUserAsync(id);
        }

        public async Task<List<UserModel>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Testing.Model;
using Testing.Repository;

namespace Testing.Controller
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


        //create
        public async Task<string> CreateUser(User user)
        {
            var errors = ValidateModel(user);
            if (errors.Count > 0)
            {
                return string.Join("\n", errors.ConvertAll(e => e.ErrorMessage));
            }

            return await _userRepository.CreateUser(user);

        }

        // Read
        public async Task<List<User>> GetUsers()
        {
            return await _userRepository.GetUsers();
        }


        //for update

        public async Task<string> UpdateUser(User user)
        {
            var errors = ValidateModel(user);
            if (errors.Count > 0)
            {
                return string.Join("\n", errors.ConvertAll(e => e.ErrorMessage));
            }
            return await _userRepository.UpdateUser(user);
        }


        //Task<string> DeleteUser(User user); //for delete
        public async Task<string> DeleteUser(User user)
        {
            var errors = ValidateModel(user);
            if (errors.Count > 0)
            {
                return string.Join("\n", errors.ConvertAll(e => e.ErrorMessage));
            }

            return await _userRepository.DeleteUser(user);  
        }
    }
}

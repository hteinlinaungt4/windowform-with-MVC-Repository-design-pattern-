using System.Collections.Generic;
using System.Threading.Tasks;
using Repository.Model;

namespace Repository.Contract
{
    public interface UserContract
    {
        Task<string> AddUserAsync(UserModel user);
        Task<string> UpdateUserAsync(UserModel user);
        Task<string> DeleteUserAsync(int id);
        Task<List<UserModel>> GetAllUsersAsync();
    }
}

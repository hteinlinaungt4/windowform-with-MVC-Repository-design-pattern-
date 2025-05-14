
using System.Collections.Generic;
using System.Threading.Tasks;
using Testing.Model;

namespace Testing.Contract
{
    public interface UserContract
    {
        //CRUD

        Task<string> CreateUser(User user); //for create user
        Task<List<User>> GetUsers(); // for read
        Task<string> UpdateUser(User user); //for update

        Task<string> DeleteUser(User user); //for delete
    }
}

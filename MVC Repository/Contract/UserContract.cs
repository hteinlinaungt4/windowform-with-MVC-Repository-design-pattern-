using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Repository.Model;

namespace MVC_Repository.Contract
{
    public interface UserContract
    {
        //CRUD
        Task<string> CreateUser(User user);

        Task<List<User>> GetUsers();

        Task<string> UpdateUser(User user);

        Task<string> DeleteUser(int id);


    }
}

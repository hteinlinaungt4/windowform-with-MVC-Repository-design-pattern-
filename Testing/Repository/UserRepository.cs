
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Testing.Contract;
using Testing.Model;

namespace Testing.Repository
{
    public class UserRepository : UserContract
    {
        //database connection
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["mvc"].ConnectionString;
        //user create
        public async  Task<string> CreateUser(User user)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
               var cmd = new MySqlCommand("INSERT INTO users (name, city) VALUES (@name, @city)", conn);
                cmd.Parameters.AddWithValue("@name",user.Name);
                cmd.Parameters.AddWithValue("@city",user.City);
                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }

            return "You are inserted Successfully!";
        }
        
        //Get all user data
        public async Task<List<User>> GetUsers()
        {
            var users = new List<User>();
            using (var conn = new MySqlConnection(connectionString))
            {
                var cmd  = new MySqlCommand("Select * from users", conn);
                await conn.OpenAsync();
                var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    users.Add(new User
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Name = reader["name"].ToString(),
                        City = reader["city"].ToString()
                    });
                }
            }
            return users;
        }
        //for update
       public async Task<string> UpdateUser(User user)
        {
           using (var conn = new MySqlConnection(connectionString))
            {
                var cmd = new MySqlCommand("UPDATE users SET name = @name, city = @city WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.Parameters.AddWithValue("@name",user.Name);
                cmd.Parameters.AddWithValue("@city", user.City);
                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            return "You are updated Successful";

        }
         //for delete
       public async Task<string> DeleteUser(User user)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                var cmd = new MySqlCommand("DELETE FROM users WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", user.Id);
                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
                return "You are Deleted Successful";
        }




    }
}


using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_Repository.Contract;
using MVC_Repository.Model;
using MySql.Data.MySqlClient;

namespace MVC_Repository.Repository
{
    public class UserRepository : UserContract
    {
        public readonly string connectionString = ConfigurationManager.ConnectionStrings["mvc"].ConnectionString;

        public async Task<string> CreateUser(User user)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                var cmd = new MySqlCommand("INSERT INTO Student (name, city,image) VALUES (@name, @city,@image)", conn);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@city", user.City);
                cmd.Parameters.AddWithValue("@image", user.Image);
                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            return "User created successfully!";
        }

        public async Task<List<User>> GetUsers()
        {
            var users = new List<User>();
            using (var conn = new MySqlConnection(connectionString))
            {
                var cmd = new MySqlCommand("SELECT * FROM Student", conn);
                await conn.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var user = new User
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["name"].ToString(),
                            City = reader["city"].ToString(),
                            Image = reader["image"].ToString()
                        };
                        users.Add(user);
                    }
                }
            }
            return users;
        }

        public async Task<string> UpdateUser(User user)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                var cmd = new MySqlCommand("UPDATE Student SET name = @name, city = @city,image=@image WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@city", user.City);
                cmd.Parameters.AddWithValue("@image", user.Image);
                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            return "User updated successfully!";
        }


        public async Task<string> DeleteUser(int id)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                var cmd = new MySqlCommand("DELETE FROM Student WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            return "User deleted successfully!";
        }



    }
}

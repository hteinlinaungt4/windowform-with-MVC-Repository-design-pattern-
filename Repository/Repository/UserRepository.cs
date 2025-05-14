using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Configuration;
using Repository.Model;
using System;
using Repository.Contract;

public class UserRepository : UserContract
{
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["mvc"].ConnectionString;

    public async Task<string> AddUserAsync(UserModel user)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            var cmd = new MySqlCommand("INSERT INTO users (name, city) VALUES (@name, @city)", conn);
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@city", user.City);

            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }
        return "User added successfully!";
    }

    public async Task<string> UpdateUserAsync(UserModel user)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            var cmd = new MySqlCommand("UPDATE users SET name = @name, city = @city WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@city", user.City);

            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }
        return "User updated successfully!";
    }

    public async Task<string> DeleteUserAsync(int id)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            var cmd = new MySqlCommand("DELETE FROM users WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }
        return "User deleted successfully!";
    }

    public async Task<List<UserModel>> GetAllUsersAsync()
    {
        var users = new List<UserModel>();
        using (var conn = new MySqlConnection(connectionString))
        {
            var cmd = new MySqlCommand("SELECT * FROM users", conn);
            await conn.OpenAsync();
            var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                users.Add(new UserModel
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Name = reader["name"].ToString(),
                    City = reader["city"].ToString()
                });
            }
        }
        return users;
    }

 
}

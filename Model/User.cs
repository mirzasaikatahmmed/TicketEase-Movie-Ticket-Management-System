using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketEase___Movie_Ticket_Management_System.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Role { get; set; } = "Customer";
        public DateTime CreatedAt { get; set; }

        private SqlDbDataAccess db = new SqlDbDataAccess();
        public static User Current { get; set; }

        public User Login(string email, string password)
        {
            User user = null;

            string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";
            SqlCommand cmd = db.GetQuery(query);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                user = new User
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Email = reader["Email"].ToString(),
                    Password = reader["Password"].ToString(),
                    PhoneNumber = reader["PhoneNumber"].ToString(),
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                    Role = reader["Role"].ToString(),
                    CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                };

                Current = user;
            }

            cmd.Connection.Close();
            return user;
        }

        public bool Register()
        {
            string query = @"INSERT INTO Users (Name, Email, Password, PhoneNumber, DateOfBirth, Role, CreatedAt)
                             VALUES (@Name, @Email, @Password, @PhoneNumber, @DateOfBirth, @Role, @CreatedAt)";

            SqlCommand cmd = db.GetQuery(query);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Role", Role);
            cmd.Parameters.AddWithValue("@CreatedAt", CreatedAt);

            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return rows > 0;
        }

        public bool UpdateProfile()
        {
            string query = @"UPDATE Users 
                     SET Name = @Name, 
                         PhoneNumber = @PhoneNumber, 
                         DateOfBirth = @DateOfBirth, 
                         Password = @Password 
                     WHERE Id = @Id";

            SqlCommand cmd = db.GetQuery(query);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Id", Id);

            try
            {
                cmd.Connection.Open();
                int rows = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return rows > 0;
            }
            catch
            {
                cmd.Connection.Close();
                return false;
            }
        }
    }

}

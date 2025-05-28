using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class LoginHandler
    {
        private SqlConnection conn = new SqlConnection("Data Source=LAPTOP-87MTL4FI\\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True;Encrypt=False");
        public User Authentication(string email, string password)
        {
            User user = null;

            string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";

            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-87MTL4FI\\SQLEXPRESS;Initial Catalog=IOOP_Assignment;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    user = new User
                    {
                        Email = reader["Email"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Role"].ToString()
                    };
                }

                conn.Close();
            }

            return user;
        }

    }
}

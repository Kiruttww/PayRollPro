using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollPro
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DSU Student\source\repos\PayRollPro\PayRollPro\PayrollDB.mdf;Integrated Security=True";

        public static void AddEmployeeToDatabase(Employee emp, string role)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Employees (Name, HourlyRate, Role) OUTPUT INSERTED.ID VALUES (@name, @rate, @role)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", emp.Name);
                cmd.Parameters.AddWithValue("@rate", emp.HourlyRate);
                cmd.Parameters.AddWithValue("@role", role);

                con.Open();

                int newId = (int)cmd.ExecuteScalar();
                emp.EmployeeId = newId;
            }
        }

        public static List<(int ID, string Name, double Rate, string Role)> LoadAllEmployees()
        {
            var list = new List<(int, string, double, string)>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employees";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string name = reader["Name"].ToString();
                    double rate = Convert.ToDouble(reader["HourlyRate"]);
                    string role = reader["Role"].ToString();

                    list.Add((id, name, rate, role));
                }
            }

            return list;
        }

        public static (int ID, string Name, double Rate, string Role)? GetEmployeeByName(string name)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employees WHERE Name = @name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string empName = reader["Name"].ToString();
                    double rate = Convert.ToDouble(reader["HourlyRate"]);
                    string role = reader["Role"].ToString();

                    return (id, empName, rate, role);
                }
            }
            return null;
        }

        public static void UpdateEmployeeInDatabase(Employee emp, string newRole)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Employees SET Name = @name WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", emp.EmployeeId);
                cmd.Parameters.AddWithValue("@name", emp.Name);
                cmd.Parameters.AddWithValue("@role", newRole);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

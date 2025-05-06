using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollPro
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DSU Student\source\repos\PayRollPro\PayRollPro\PayrollDB.mdf;Integrated Security=True";

        public static void AddEmployeeToDatabase(Employee emp)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Get the next available ID
                string getIdQuery = @"SELECT ISNULL((SELECT MIN(t1.ID + 1) FROM Employees t1 LEFT JOIN Employees t2 ON t1.ID + 1 = t2.ID WHERE t2.ID IS NULL), 0)";

                int nextId;
                using (SqlCommand getIdCmd = new SqlCommand(getIdQuery, con))
                {
                    nextId = (int)getIdCmd.ExecuteScalar();
                }

                // Insert the new employee with the calculated ID
                string query = "INSERT INTO Employees (ID, Name, HourlyRate, Role) VALUES (@id, @name, @rate, @role); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", nextId);
                    cmd.Parameters.AddWithValue("@name", emp.Name);
                    cmd.Parameters.AddWithValue("@rate", emp.HourlyRate);
                    cmd.Parameters.AddWithValue("@role", emp.Role);

                    // Execute the insert and retrieve the inserted ID
                    cmd.ExecuteNonQuery();

                    emp.EmployeeId = nextId; // This retrieves the newly inserted ID
                }
            }
        }

        public static void RemoveEmployeeFromDatabase(Employee emp)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "DELETE FROM Employees WHERE ID = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", emp.EmployeeId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        Console.WriteLine("No employee found with the given ID.");
                    }
                    else
                    {
                        MessageBox.Show("Employee removed successfully!");
                    }
                }
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
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = (int)reader["ID"];
                        string empName = reader["Name"].ToString();
                        double rate = Convert.ToDouble(reader["HourlyRate"]);
                        string role = reader["Role"].ToString();

                        return (id, empName, rate, role);
                    }
                }
            }
            return null;
        }

        public static void UpdateEmployeeInDatabase(Employee emp)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Employees SET Name = @name, Role = @role, HourlyRate = @rate WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", emp.EmployeeId);
                cmd.Parameters.AddWithValue("@name", emp.Name);
                cmd.Parameters.AddWithValue("@role", emp.Role);
                cmd.Parameters.AddWithValue("@rate", emp.HourlyRate);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

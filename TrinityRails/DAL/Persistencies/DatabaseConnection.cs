using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.Persistencies
{
    public class DatabaseConnection
    {  
        public string connectionString = @"Data Source=BOB;Initial Catalog=Trinity+;Integrated Security=True";

        public void executeCommand(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    command.ExecuteReader();
                    Console.WriteLine("Execute reader executed");
                    connection.Close();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
        }
                
        public Nullable<int> executeReaderInt(string query) //returns null if there is no result
        {
            Nullable<int> noResult = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (command.ExecuteScalar() != null)
                    {
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                    connection.Close();                    
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            return noResult;
        }
                
        public string executeReaderString(string query) //returns null if there is no result
        {
            string noResult = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (command.ExecuteScalar() != null)
                    {
                        return Convert.ToString(command.ExecuteScalar());
                    }
                    connection.Close();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            return noResult;
        }

        public Nullable<bool> executeReaderBool(string query) //returns null if there is no result
        {
            Nullable<bool> noResult = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (command.ExecuteScalar() != null)
                    {
                        return Convert.ToBoolean(command.ExecuteScalar());
                    }
                    connection.Close();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            return noResult;
        }

        public List<int> executeReaderIntList(string query) //returns null if there is no result
        {
            List<int> noResult = null;
            List<int> list = new List<int>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    list.Clear();
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader.GetInt32(0));
                    }
                    return list;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            return noResult;  
        }
    }
}
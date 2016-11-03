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
        //Er moet nog een methode komen die een list returns en een methode die een boolean returned
        public string connectionString = @"Server = DESKTOP-NNKUBRF; Database = Tronics; User ID = sa; Password = 1234;";

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
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
        }
                
        public int executeReaderInt(string query) //returns -1 if there is no result
        {
            int noResult = -1;
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Interfaces;
using DAL.Types;


namespace DAL.Persistencies
{
    public class UserSQL : IUser
    {
        private DatabaseConnection databaseConnection;

        public UserSQL()
        {
            databaseConnection = new DatabaseConnection();
        }

        public void changePassword(User user, string password)
        {
            string query = @"UPDATE [UserTable] SET [password] = '" + password + @"' WHERE ID = " + user.ID + @";";
            databaseConnection.executeCommand(query);
        }

        public void changeUsername(User user)
        {
            throw new NotImplementedException();
        }

        public void checkCredentials(string username, string password)
        {
            throw new NotImplementedException();
        }

        public string getFunction(User user)
        {
            throw new NotImplementedException();
        }

        public int getID(string username, string password)
        {
            string query = @"SELECT [ID] FROM [USER] WHERE Name = '" + username + @"' AND Password = '" + password + @"';";
            return databaseConnection.executeReaderInt(query);
        }

        //string query = @"INSERT INTO [UserTable] (Username, Password) VALUES ('" + username + @"', '" + user.password + @"');";
        //string query = @"DELETE FROM [UserTable] WHERE [UserID] = '" + user.ID + @"';";
        //string query = @"UPDATE [UserTable] SET [password] = '" + user.password + @"' WHERE [UserID] = '" + user.ID + @"';";
    }
}

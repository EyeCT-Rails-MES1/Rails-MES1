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
            string query = @"UPDATE [UserTable] SET [password] = '" + password + @"' WHERE [UserID] = " + user.ID + @";";
            databaseConnection.executeCommand(query);
        }

        public void changeUsername(User user)
        {
            string query = @"UPDATE [UserTable] SET [Username] = '" + user.username + @"' WHERE [UserID] = " + user.ID + @";";
            databaseConnection.executeCommand(query);
        }

        public bool checkCredentials(string username, string password)
        {
            string query = @"SELECT [UserID] FROM [UserTable] WHERE [Username] = '" + username + @"' AND [password] = '" + password + @"';";
            if (databaseConnection.executeReaderInt(query) != -1)
            {
                return true;
            }
            return false;
        }

        public int getFunction(User user)
        {
            string query = @"SELECT [function] FROM [UserTable] WHERE [UserID] = " + user.ID + @";";
            return Convert.ToInt32(databaseConnection.executeReaderInt(query));
        }

        public int getID(string username, string password)
        {
            string query = @"SELECT [UserID] FROM [UserTable] WHERE [username] = '" + username + @"' AND [password] = '" + password + @"';";
            return Convert.ToInt32(databaseConnection.executeReaderInt(query));
        }

        public string getName(User user)
        {
            string query = "";
            return databaseConnection.executeReaderString(query);
        }
    }
}

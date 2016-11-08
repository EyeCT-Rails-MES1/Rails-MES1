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
            string query = @"UPDATE [User] SET [Password] = '" + password + @"' WHERE [ID] = " + user.ID + @";";
            databaseConnection.executeCommand(query);
        }

        public void changeUsername(User user)
        {
            string query = @"UPDATE [User] SET [Name] = '" + user.username + @"' WHERE [ID] = " + user.ID + @";";
            databaseConnection.executeCommand(query);
        }

        public bool checkCredentials(string username, string password)
        {
            string query = @"SELECT [ID] FROM [User] WHERE [Name] = '" + username + @"' AND [Password] = '" + password + @"';";
            if (databaseConnection.executeReaderInt(query) != -1)
            {
                return true;
            }
            return false;
        }

        public int getFunction(User user)
        {
            string query = @"SELECT [Function] FROM [User] WHERE [ID] = " + user.ID + @";";
            return Convert.ToInt32(databaseConnection.executeReaderInt(query));
        }

        public int getID(string username, string password)
        {
            string query = @"SELECT [ID] FROM [User] WHERE [Name] = '" + username + @"' AND [Password] = '" + password + @"';";
            return Convert.ToInt32(databaseConnection.executeReaderInt(query));
        }

        public string getName(User user)
        {
            string query = @"SELECT[Name] FROM [User] WHERE [ID] = '" + user.ID + @";";
            return databaseConnection.executeReaderString(query);
        }
    }
}

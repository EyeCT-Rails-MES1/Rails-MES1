using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Types;
using Classes.Enumerations;

namespace DAL.Persistencies
{
    public class AdminSQL : IAdmin
    {
        private DatabaseConnection databaseConnection;
        public AdminSQL()
        {
            databaseConnection = new DatabaseConnection();
        }

        public void changePassword(User user, string password)
        {
            string query = @"UPDATE [User] SET Password = '" + password + @"' WHERE [ID] = " + user.ID + @";";
            databaseConnection.executeCommand(query);
        }

        public void changeUsername(User user)
        {
            string query = @"UPDATE [User] SET Username = '" + user.username + @"' WHERE [ID] = " + user.ID + @";";
            databaseConnection.executeCommand(query);
        }

        public void create(string username, string password)
        {
            string query = @"INSERT INTO [User] (ID, Username, Password) VALUES (" + username + @", " + password + @");";
            databaseConnection.executeCommand(query);
        }

        public void delete(User user)
        {
            string query = @"DELETE FROM [User] WHERE [ID] = " + user.ID + @";";
            databaseConnection.executeCommand(query);
        } 

        public List<User> getUsers()
        {
            List<User> userList = new List<User>();  

            string getUserIDquery = @"select ID from [user];"; 
            List<int> userIDList = databaseConnection.executeReaderIntList(getUserIDquery);

            foreach(int userID in userIDList)
            {
                string getNameQuery = @"Select Name from [user] where ID =" + userID + @";";
                string getUsernameQuery = @"Select Username from [user] where ID =" + userID + @";";
                string getFunctionIDQuery = @"Select FunctionID from [user] where ID =" + userID + @";"; 

                userList.Add(new User(userID, databaseConnection.executeReaderString(getNameQuery), databaseConnection.executeReaderString(getUsernameQuery), (Function.userFunction)databaseConnection.executeReaderInt(getFunctionIDQuery)));
            }
            return userList;
        }
    }
}

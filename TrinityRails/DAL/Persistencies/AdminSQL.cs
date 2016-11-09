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
            string query = @"UPDATE [User] SET Password = " + password + @" WHERE [ID] = " + user.ID + @";";
            databaseConnection.executeCommand(query);
        }

        public void changeUsername(User user)
        {
            string query = @"UPDATE [User] SET Username = " + user.username + @" WHERE [ID] = " + user.ID + @";";
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

        List<User> IAdmin.getUsers()
        {
            List<User> userList = new List<User>();
            string query = @"select ID from [user];";
            List<int> userID = databaseConnection.executeReaderIntList(query);
            User tempUser = new User(0,"harry");
            foreach(int id in userID)
            {
                tempUser.ID = id;
                query = @"Select Name from [user] where ID =" + id + @";";
                tempUser.name = databaseConnection.executeReaderString(query);
                query = @"Select Username from [user] where ID =" + id + @";";
                tempUser.username = databaseConnection.executeReaderString(query);
                query = @"Select FunctionID from [user] where ID =" + id + @";";
                tempUser.function = (Function.userFunction)databaseConnection.executeReaderInt(query);
                userList.Add(new User(tempUser.ID, tempUser.name, tempUser.username, tempUser.function));
            }
            return userList;
        }
    }
}

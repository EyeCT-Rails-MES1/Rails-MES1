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
            string query = @"UPDATE [User] SET [Password] = " + password + @"WHERE [UserID] = " + user.ID + @";";
            databaseConnection.executeCommand(query);
        }

        public void changeUsername(User user, string username)
        {
            string query = @"UPDATE [User] SET [Name] = " + user + @"WHERE [UserID] = " + user.ID + @";";
            databaseConnection.executeCommand(query);
        }

        public void create(string username, string password)
        {
            string query = @"INSERT INTO [User] (ID, Name, Password) VALUES (" + username + @", " + password + @");";
            databaseConnection.executeCommand(query);
        }

        public void delete(User user)
        {
            string query = @"DELETE FROM [User] WHERE [ID] = " + user.ID + @";";
            databaseConnection.executeCommand(query);
        } 

        List<User> IAdmin.getUsers()
        {
            throw new NotImplementedException();
            //Haalt alle users op en maakt nieuwe user instanties aan
        }
    }
}

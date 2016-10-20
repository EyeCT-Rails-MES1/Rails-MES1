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

        public void changePassword()
        {
            throw new NotImplementedException();
        }

        public void changeUsername()
        {
            throw new NotImplementedException();
        }

        public void checkCredentials()
        {
            throw new NotImplementedException();
        }

        public void getFunction()
        {
            throw new NotImplementedException();
        }

        public void getID()
        {
            throw new NotImplementedException();
        }

        //public void checkCredentials(User user)
        //{
        //    string query = @"INSERT INTO [UserTable] (Username, Password) VALUES ('" + user.username + @"', '" + user.password + @"');";
        //    databaseConnection.executeCommand(query);
        //}

        //public void getID()
        //{
        //    string query = @"DELETE FROM [UserTable] WHERE [UserID] = '" + user.ID + @"';";
        //    databaseConnection.executeCommand(query);
        //}

        //public void getFunction(string function)
        //{
        //    string query = @"";
        //    databaseConnection.executeCommand(query);
        //}

        //public void changeUsername()
        //{
        //    string query = @"UPDATE [UserTable] SET [password] = '" + user.password + @"' WHERE [UserID] = '" + user.ID + @"';";
        //    databaseConnection.executeCommand(query);
        //}

        //public void changePassword()
        //{
        //    string query = @"UPDATE [UserTable] SET [password] = '" + user.password + @"' WHERE [UserID] = '" + user.ID + @"';";
        //    databaseConnection.executeCommand(query);
        //}
    }
}

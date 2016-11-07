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
    class AdminSQL : IAdmin
    {
        private DatabaseConnection databaseConnection;
        public AdminSQL()
        {
            databaseConnection = new DatabaseConnection();
        }

        public void changePassword(string username, string password)
        {
            string query = @"UPDATE [USER] SET [Password] = "
        }

        public void changeUsername()
        {
            throw new NotImplementedException();
        }

        public void create()
        {
            throw new NotImplementedException();
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public void getUsers()
        {
            throw new NotImplementedException();
        }
    }
}

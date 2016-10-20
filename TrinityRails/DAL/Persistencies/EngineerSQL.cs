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
    class EngineerSQL : IEngineer
    {
        private DatabaseConnection databaseConnection;

        public EngineerSQL()
        {
            databaseConnection = new DatabaseConnection();
        }

        public void setDate()
        {
            throw new NotImplementedException();
        }

        public void setName()
        {
            throw new NotImplementedException();
        }

        public void setStatus()
        {
            throw new NotImplementedException();
        }
    }
}

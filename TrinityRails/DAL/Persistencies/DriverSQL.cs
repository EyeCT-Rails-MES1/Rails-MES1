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
    public class DriverSQL
    {
        private DatabaseConnection databaseConnection;

        public DriverSQL()
        {
            databaseConnection = new DatabaseConnection();
        }

        public void setCleaningTask()
        {
            throw new NotImplementedException();
        }

        public void setPriority()
        {
            throw new NotImplementedException();
        }

        public void getLocation()
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class CleanerSQL : ICleaner
    {
        private DatabaseConnection databaseConnection;

        public CleanerSQL()
        {
            databaseConnection = new DatabaseConnection();
        }

        public void setName()
        {
            throw new NotImplementedException();
        }

        public void setDate()
        {
            throw new NotImplementedException();
        }

        public void setStatus()
        {
            throw new NotImplementedException();
        }

        public void getCleaningTasks()
        {
            throw new NotImplementedException();
        }

        public List<string> cleaningList()
        {
            throw new NotImplementedException();
        }
    }
}

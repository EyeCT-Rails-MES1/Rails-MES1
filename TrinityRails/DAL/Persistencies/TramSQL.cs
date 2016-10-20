using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Interfaces;
using DAL.Types;
using Classes.Enumerations;

namespace DAL.Persistencies
{
    public class TramSQL : ITram
    {
        private DatabaseConnection databaseConnection;
        public TramSQL()
        {
            databaseConnection = new DatabaseConnection();
        }
        public List<Tram> getTrams()
        {
            throw new NotImplementedException();
        }

        public void setStatus(Tram tram, Status.tramStatus status)
        {
            throw new NotImplementedException();
        }

        public void setLocation(Tram tram, int location)
        {
            throw new NotImplementedException();
        }

        
    }
}

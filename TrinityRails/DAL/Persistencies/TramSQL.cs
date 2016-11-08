using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Interfaces;
using DAL.Types;
using Classes.Enumerations;
using Classes;

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
            string query = @"SELECT [TramNumber, RFID, Status, Rail, Sector] FROM [Tram];";
            databaseConnection.executeCommand(query);

            //Voeg ze toe aan een list en return deze
            throw new NotImplementedException();
        }

        public void setStatus(Tram tram, Status.tramStatus status)
        {
            string query = @"UPDATE [Tram] SET [Status] = '" + status + @"' WHERE [TramNumber] = " + tram.number + @";";
            databaseConnection.executeCommand(query);
        }

        public void setLocation(Tram tram)
        {
            string query = @"Update [Tram] SET [Rail, Sector] = '" + "(" + tram.rail + ", " + tram.sector + ")" + @"' WHERE [TramNumber] = " + tram.number + @";";
        }
    }
}
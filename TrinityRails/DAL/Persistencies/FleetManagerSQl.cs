using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using DAL.Interfaces;
using DAL.Types;

namespace DAL.Persistencies
{
    public class FleetManagerSQL : IFleetManager
    {
        private DatabaseConnection databaseConnection;

        public FleetManagerSQL()
        {
            databaseConnection = new DatabaseConnection();
        }

        public void setSectorStatus(Sector sector)
        {
            string query = @"UPDATE [Sector] SET [Status] = " + sector.blocked + @"WHERE [SectorNumber] = " + sector.Number + @";";
            databaseConnection.executeCommand(query);
        }

        public bool getSectorStatus(Sector sector)
        {
            string query = @"SELECT [Status] FROM [Sector] WHERE [SectorNumber] = " + sector.Number + @";";
            return Convert.ToBoolean(databaseConnection.executeReaderBool(query));
        }

        List<Sector> IFleetManager.getSectorList()
        {
            throw new NotImplementedException();
        }
        List<Rails> IFleetManager.getRailList()
        {
            throw new NotImplementedException();
        }
    }
}

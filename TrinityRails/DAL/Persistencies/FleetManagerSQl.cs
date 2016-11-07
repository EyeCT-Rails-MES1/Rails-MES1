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
    class FleetManagerSQL : IFleetManager
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
            databaseConnection.executeCommand(query);
            //Return de status als boolean
            throw new NotImplementedException();
        }
    }
}

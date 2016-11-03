using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool setSectorStatus()
        {
            throw new Exception();
            //Methode moet een boolean returnen
        }

        public void getSectorStatus()
        {

        }

        bool IFleetManager.getSectorStatus()
        {
            throw new NotImplementedException();
        }

        void IFleetManager.setSectorStatus()
        {
            throw new NotImplementedException();
        }
    }
}

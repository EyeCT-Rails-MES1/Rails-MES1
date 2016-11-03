using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Types;

namespace DAL.Repositories
{
    class FleetManagerRepository
    {
        IFleetManager context;
        List<User> userList = new List<User>();

        public FleetManagerRepository(IFleetManager context)
        {
            this.context = context;
        }

        public void checkSector()
        {
            //context.getSectorStatus();
        }

        public void blockSector()
        {
            //context.setSectorStatus(false);
        }

        public void unblockSector()
        {
            //context.setSectorStatus(false);
        }
    }
}

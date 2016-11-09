using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Types;
using Classes;

namespace DAL.Repositories
{
    public class FleetManagerRepository
    {
        IFleetManager context;
        List<User> userList = new List<User>();

        public FleetManagerRepository(IFleetManager context)
        {
            this.context = context;
        }

        public void checkSector(Sector sector)
        {
            context.getSectorStatus(sector);
        }

        public void blockSector(Sector sector)
        {
            bool block = sector.blocked;
            block = true;
            context.setSectorStatus(sector);
        }

        public void unblockSector(Sector sector)
        {
            bool block = sector.blocked;
            block = false;
            context.setSectorStatus(sector);
        }
    }
}
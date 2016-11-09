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
            sector.status = Classes.Enumerations.RailStatus.railStatus.Blocked;
            context.setSectorStatus(sector);
        }

        public void unblockSector(Sector sector)
        {
            sector.status = Classes.Enumerations.RailStatus.railStatus.Available;
            context.setSectorStatus(sector);
        }

        public List<Rails> getRailsList()
        {
            return context.getRailList();
        }

        public List<Sector> getSectorList()
        {
            return context.getSectorList();
        }

    }
}
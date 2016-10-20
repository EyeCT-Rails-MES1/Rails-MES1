using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.Repositories
{
    class FleetManagerRepository
    {
        IFleetManager context;

        public FleetManagerRepository(IFleetManager context)
        {
            this.context = context;
        }

        public void setSectorStatus()
        {
            switch (context.getSectorStatus())
            {
                case true:
                    context.setSectorStatus();
                    break;
                case false:
                    context.setSectorStatus();
                    break;
                default:
                    break;
            }
        }
    }
}

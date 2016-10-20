using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Types;
using Classes.Enumerations;
using Classes;

namespace DAL.Repositories
{
    public class DriverRepository
    {
        IDriver context;

        public DriverRepository(IDriver context)
        {
            this.context = context;
        }

        public void addCleaningTask(string cleaningTask)
        {
            
        }

        public int getLocation(int location)
        {
            return location;
        }
    }
}

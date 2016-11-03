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
        List<User> userList = new List<User>();

        public DriverRepository(IDriver context)
        {
            this.context = context;
        }

        public void addCleaningTask(string cleaningTask)
        {
            //context.setCleaningTask(cleaningTask);
        }

        public int getLocation(int location)
        {
            //return context.getLocation(location);
            throw new NotImplementedException();
        }
    }
}
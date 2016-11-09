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

        public void addCleaningTask(string cleaningTask, Tram tram)
        {
            context.createCleaningTask(cleaningTask, tram);
        }

        public int getLocation(Tram tram)
        {
            return (int)context.getLocation(tram);
        }
    }
}
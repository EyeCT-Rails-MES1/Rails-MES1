using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Types;

namespace DAL.Repositories
{
    public class EngineerRepository
    {
        IEngineer context;
        List<User> userList = new List<User>();

        public EngineerRepository(IEngineer context)
        {
            this.context = context;
        }

        public void setRepair(Tram tram, User user, Classes.Enumerations.Status.tramStatus status)
        {
            context.setName(user, tram);
            context.setStatus(tram, status);
        }

        public void finishRepair(Tram tram, User user, DateTime date, Classes.Enumerations.Status.tramStatus status)
        {
            context.setDate(date, user, tram);
            context.setName(user, tram);
            context.setStatus(tram, status);
        }
    }
}
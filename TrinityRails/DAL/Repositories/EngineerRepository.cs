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

        public void finishRepair()
        {
            //?
        }
    }
}
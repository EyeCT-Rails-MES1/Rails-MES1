using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Types;

namespace DAL.Repositories
{
    class EngineerRepository
    {
        IEngineer context;

        public EngineerRepository(IEngineer context)
        {
            this.context = context;
        }
        public void finishRepair()
        {
            throw new NotImplementedException();
        }
    }
}

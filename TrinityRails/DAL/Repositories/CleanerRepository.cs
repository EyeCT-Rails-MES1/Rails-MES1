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
    public class CleanerRepository
    {
        ICleaner context;

        public CleanerRepository(ICleaner context)
        {
            this.context = context;
        }
        public List<string> getCleaningList()
        {
            throw new NotImplementedException();
        }
        public void finishCleaning()
        {
            throw new NotImplementedException();
        }
    }
}


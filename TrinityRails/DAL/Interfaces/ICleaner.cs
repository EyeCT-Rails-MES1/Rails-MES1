using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Types;
using Classes.Enumerations;

namespace DAL.Interfaces
{
    public interface ICleaner
    {
        void finishTask(int tramNumber, DateTime date, User user);
        List<Cleaner> cleaningList();
    }
}

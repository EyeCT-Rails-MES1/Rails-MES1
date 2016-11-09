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
        void setDate(DateTime date, User user, Tram tram);
        void setName(User user, Tram tram);
        void setStatus(Tram tram, Status.tramStatus status);
        string getCleaningTasks(Tram tram);
        List<Cleaner> cleaningList();
    }
}

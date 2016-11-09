using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Types;

namespace DAL.Interfaces
{
    public interface IDriver
    {
        void createCleaningTask(string task, Tram tram);
        void setPriority(int priority, Tram tram);
        Nullable<int> getLocation(Tram tram);
    }
}

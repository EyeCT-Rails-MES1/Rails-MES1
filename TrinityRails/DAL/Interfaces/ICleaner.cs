using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Enumerations;

namespace DAL.Interfaces
{
    public interface ICleaner
    {
        void setName();
        void setDate();
        void setStatus();
        void getCleaningTasks();
        List<string> cleaningList();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Enumerations;
using DAL.Types;

namespace DAL.Interfaces
{
    public interface IEngineer
    {
        void setName(User user, Tram tram);
        void setDate(DateTime date, User user, Tram tram);
        void setStatus(Tram tram, Status.tramStatus status);
    }
}

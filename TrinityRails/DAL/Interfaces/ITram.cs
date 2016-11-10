using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Types;
using Classes.Enumerations;
using Classes;

namespace DAL.Interfaces
{
    public interface ITram
    {
        List<Tram> getTrams();
        List<Tram> getTramsInRemise();
        void setStatus(Tram tram, Status.tramStatus status);
        void setLocation(Tram tram);
    }
}

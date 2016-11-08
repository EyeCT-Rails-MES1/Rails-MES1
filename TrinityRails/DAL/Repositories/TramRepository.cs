using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Types;
using DAL.Interfaces;
using Classes.Enumerations;
using Classes;

namespace DAL.Repositories
{
    public class TramRepository : ITram
    {
        ITram context;
        List<Tram> trams = new List<Tram>();
        public TramRepository(ITram context)
        {
            this.context = context;
        }
        public List<Tram> getTrams()
        {
            return trams;
        }
        public void setStatus(Tram tram, Status.tramStatus status)
        {
            tram.status = status;
            context.setStatus(tram, status);
        }
        public void setLocation(Tram tram)
        {
            context.setLocation(tram);
        }
    }
}
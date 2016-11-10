using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace DAL.Types
{
    public class Reservation
    {
        public Tram tram { get; private set; }
        public int rail { get; private set; }

        public Reservation(Tram tram, int rail)
        {
            this.tram = tram;
            this.rail = rail;
        }
    }
}

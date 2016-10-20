using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Sector
    {
        public int railNumber { get; set; }
        public int sectorNumber { get; set; }
        public bool blocked { get; set; }

        public Sector (int railNumber, int sectorNumber)
        {
            this.railNumber = railNumber;
            this.sectorNumber = sectorNumber;
        }
    }
}

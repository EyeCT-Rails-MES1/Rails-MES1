using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class Rails
    {
        public int railNumber { get; set; }
        public int sectorAmount { get; set; }

        public Rails (int railNumber, int sectorAmount)
        {
            this.railNumber = railNumber;
            this.sectorAmount = sectorAmount;
        }


    }
}

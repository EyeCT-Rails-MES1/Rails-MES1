using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Rails
    {
        public int railNumber { get; private set; }
        public int sectorAmount { get; private set; }

        public Rails (int railNumber, int sectorAmount)
        {
            this.railNumber = railNumber;
            this.sectorAmount = sectorAmount;
        }
    }
}

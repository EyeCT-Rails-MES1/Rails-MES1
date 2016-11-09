using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Rails
    {
        public int Number { get; private set; }
        public int sectorAmount { get; set; }

        public Sector sector { get; set; }

        public Rails (int Number, int sectorAmount)
        {
            this.Number = Number;
            this.sectorAmount = sectorAmount;
        }
    }
}

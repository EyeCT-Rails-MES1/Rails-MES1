using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Classes.Enumerations;
using System.Threading.Tasks;

namespace Classes
{
    public class Sector
    {
        public int railNumber { get; private set; }
        public int Number { get; private set; }
        public RailStatus.railStatus status { get; set; }

        public Sector (int railNumber, int Number, RailStatus.railStatus status)
        {
            this.railNumber = railNumber;
            this.Number = Number;
            this.status = status;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Sector
    {
        public int railNumber { get; private set; }
        public int Number { get; private set; }
        public bool blocked { get; private set; }

        public Sector (int railNumber, int Number)
        {
            this.railNumber = railNumber;
            this.Number = Number;
        }
    }
}

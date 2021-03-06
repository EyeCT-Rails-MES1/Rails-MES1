﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using DAL.Types;

namespace DAL.Interfaces
{
    public interface IFleetManager
    {
        Nullable<bool> getSectorStatus(Sector sector);
        void setSectorStatus(Sector sector);

        List<Sector> getSectorList();
        List<Rails> getRailList();
    }
}

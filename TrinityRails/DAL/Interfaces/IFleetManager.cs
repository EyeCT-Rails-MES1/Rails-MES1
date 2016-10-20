using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.Types;

namespace DAL.Interfaces
{
    public interface IFleetManager
    {
        void getSectorStatus();
        void setSectorStatus();
    }
}

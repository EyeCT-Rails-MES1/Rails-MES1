using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Enumerations;

namespace DAL.Types
{
    public class Tram
    {
        public int number { get; set; }
        public Status.tramStatus status { get; set; }
        public int rail { get; set; }
        public int sector { get; set; }
        public string RFID { get; set; }
        Tram(int number, Status.tramStatus tramStatus, int sector, string RFID, int rail)
        {
            this.number = number;
            status = tramStatus;
            this.sector = sector;
            this.RFID = RFID;
            this.rail = rail;
        }
    }
}

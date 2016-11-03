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
        public int sector { get; set; }
        public int RFID { get; set; }
        public int location { get; set; }
        public Tram(int number, Status.tramStatus tramStatus, int sector, int RFID, int location)
        {
            this.number = number;
            status = tramStatus;
            this.sector = sector;
            this.RFID = RFID;
            this.location = location;
        }
    }
}

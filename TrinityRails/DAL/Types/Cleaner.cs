using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Types
{
    public class Cleaner
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string task { get; set; }
        public int tramNumber { get; set; }
        public Cleaner(int ID, string name, string task, int tramNumber)
        {
            this.ID = ID;
            this.name = name;
            this.task = task;
            this.tramNumber = tramNumber;
        }

        public override string ToString()
        {
            return task;
        }
    }
}

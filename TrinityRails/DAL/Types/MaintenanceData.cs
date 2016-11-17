using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Types
{
    public class MaintenanceData
    {
        public int ID { get; set; }
        public int TramID { get; set; }
        public int UserID { get; set; }
        public int CleaningListID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MaintenanceData(int ID, int tramID, int userID, int cleaninglistID, DateTime startDate, DateTime endDate)
        {
            this.ID = ID;
            this.TramID = tramID;
            this.UserID = userID;
            this.CleaningListID = cleaninglistID;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}

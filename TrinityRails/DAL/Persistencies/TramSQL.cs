using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Interfaces;
using DAL.Types;
using Classes.Enumerations;
using Classes;

namespace DAL.Persistencies
{
    public class TramSQL : ITram
    {
        private DatabaseConnection databaseConnection;
        public TramSQL()
        {
            databaseConnection = new DatabaseConnection();
        }
        List<Tram> ITram.getTrams()
        {
            List<Tram> TramList = new List<Tram>();
            string query = @"select TramNumber from [Tram];";
            List<int> tramID = databaseConnection.executeReaderIntList(query);
            Tram tempTram = new Tram(1, Status.tramStatus.Repair, 1, "1", 1);
            foreach (int id in tramID)
            {
                tempTram.number = id;
                query = @"Select Status from [Tram] where TramNumber =" + id + @";";
                tempTram.status = (Status.tramStatus)databaseConnection.executeReaderInt(query);
                query = @"select SectorNumber from [LOCATION] left join [TRAM] on LOCATION.ID = TRAM.LocationID where TRAM.TramNumber=" + id + @";";
                tempTram.sector = (int)databaseConnection.executeReaderInt(query);
                query = @"Select RFID from [Tram] where ID =" + id + @";";
                tempTram.RFID = (string)databaseConnection.executeReaderString(query);
                query = @"Select RailNumber from [Location] left join [TRAM] on LOCATION.ID = TRAM.LocationID where TRAM.TramNumber=" + id + @";";
                tempTram.rail = (int)databaseConnection.executeReaderInt(query);
                TramList.Add(new Tram(tempTram.number, tempTram.status, tempTram.sector, tempTram.RFID, tempTram.rail));
            }
            return TramList;
        }
        List<Tram> ITram.getTramsInRemise()
        {
            List<Tram> TramList = new List<Tram>();
            string query = @"select TramNumber from [Tram] WHERE [Status] = " + Convert.ToInt32(Status.tramStatus.Remise) + @";";
            List<int> tramID = databaseConnection.executeReaderIntList(query);
            Tram tempTram = new Tram(1, Status.tramStatus.Repair, 1, "1", 1);
            foreach (int id in tramID)
            {
                tempTram.number = id;
                query = @"Select Status from [Tram] where TramNumber =" + id + @";";
                tempTram.status = (Status.tramStatus)databaseConnection.executeReaderInt(query);
                query = @"select SectorNumber from [LOCATION] left join [TRAM] on LOCATION.ID = TRAM.LocationID where TRAM.TramNumber=" + id + @";";
                tempTram.sector = (int)databaseConnection.executeReaderInt(query);
                query = @"Select RFID from [Tram] where ID =" + id + @";";
                tempTram.RFID = (string)databaseConnection.executeReaderString(query);
                query = @"Select RailNumber from [Location] left join [TRAM] on LOCATION.ID = TRAM.LocationID where TRAM.TramNumber=" + id + @";";
                tempTram.rail = (int)databaseConnection.executeReaderInt(query);
                TramList.Add(new Tram(tempTram.number, tempTram.status, tempTram.sector, tempTram.RFID, tempTram.rail));
            }
            return TramList;
        }
        public void setStatus(Tram tram, Status.tramStatus status)
        {
            string query = @"UPDATE [Tram] SET [Status] = '" + Convert.ToInt32(status) + @"' WHERE [TramNumber] = " + tram.number + @";";
            databaseConnection.executeCommand(query);
        }

        public void setLocation(Tram tram)
        {
            string query = @"Update [Tram] SET [Rail, Sector] = '" + "(" + tram.rail + ", " + tram.sector + ")" + @"' WHERE [TramNumber] = " + tram.number + @";";
        }
    }
}
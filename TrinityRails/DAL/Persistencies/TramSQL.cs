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
        public List<Tram> getTrams()
        {
            List<Tram> userList = new List<Tram>();
            string query = @"select TramNumber from [Tram];";
            List<int> tramID = databaseConnection.executeReaderIntList(query);
            Tram tempTram = new Tram(1, 0, 1, "1", 1);
            foreach (int id in tramID)
            {
                tempTram.number = id;
                query = @"Select Status from [Tram] where ID =" + id + @";";
                tempTram.status = (Status.tramStatus)databaseConnection.executeReaderInt(query);
                query = @"Select SectorNumber from [Location] where ID = Location.ID AND Tram.LocationID=" + id + @";";
                tempTram.sector = (int)databaseConnection.executeReaderInt(query);
                query = @"Select RFID from [Tram] where ID =" + id + @";";
                tempTram.RFID = (string)databaseConnection.executeReaderString(query);
                query = @"Select RailNumber from [Location] where ID = Location.ID AND Tram.LocationID=" + id + @";";
                tempTram.rail = (int)databaseConnection.executeReaderInt(query);
                userList.Add(new Tram(tempTram.number, tempTram.status, tempTram.sector, tempTram.RFID, tempTram.rail));
            }
            return userList;


            //string query = @"SELECT [TramNumber, RFID, Status, Rail, Sector] FROM [Tram];";
            //databaseConnection.executeCommand(query);

            //Voeg ze toe aan een list en return deze
            throw new NotImplementedException();
        }

        public void setStatus(Tram tram, Status.tramStatus status)
        {
            string query = @"UPDATE [Tram] SET [Status] = '" + status + @"' WHERE [TramNumber] = " + tram.number + @";";
            databaseConnection.executeCommand(query);
        }

        public void setLocation(Tram tram)
        {
            string query = @"Update [Tram] SET [Rail, Sector] = '" + "(" + tram.rail + ", " + tram.sector + ")" + @"' WHERE [TramNumber] = " + tram.number + @";";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Classes.Enumerations;
using DAL.Interfaces;
using DAL.Types;

namespace DAL.Persistencies
{
    public class CleanerSQL : ICleaner
    {
        private DatabaseConnection databaseConnection;

        public CleanerSQL()
        {
            databaseConnection = new DatabaseConnection();
        }

        public void setDate(DateTime date, User user, Tram tram)
        {
            string query = @"UPDATE [Maintenance] SET [EndDate] = " + date + @" WHERE [UserID] = " + user.ID + @" AND [TramID] = " + tram.number + @";";
            databaseConnection.executeCommand(query);
        }

        public void setName(User user, Tram tram)
        {
            string query = @"UPDATE [Maintenance] SET [Name] = " + user.name + @" WHERE [UserID] = " + user.ID + @" AND [TramID] = " + tram.number + @";";
            databaseConnection.executeCommand(query);
        }

        public void setStatus(Tram tram, Status.tramStatus status)
        {
            string query = @"UPDATE [Tram] SET [Status] = " + Convert.ToInt32(status) + @"WHERE [TramNumber] = " + tram.number + @";";
            databaseConnection.executeCommand(query);
        }

        public string getCleaningTasks(Tram tram)
        {
            string query = @"SELECT [Task] FROM [Cleaninglist] WHERE [TramNumber] = " + tram.number + @";";
            return databaseConnection.executeReaderString(query);
        }

        List<Cleaner> ICleaner.cleaningList()
        {
            List<Cleaner> cleaningList = new List<Cleaner>();
            string query = @"select ID from [Cleaninglist];";
            List<int> cleaningID = databaseConnection.executeReaderIntList(query);
            Cleaner tempCleaning = new Cleaner(0, "", "harry", 2050);
            foreach (int id in cleaningID)
            {
                tempCleaning.ID = id;
                query = @"Select Name from [Cleaninglist] where ID =" + id + @";";
                tempCleaning.name = databaseConnection.executeReaderString(query);
                query = @"Select Task from [Cleaninglist] where ID =" + id + @";";
                tempCleaning.task = databaseConnection.executeReaderString(query);
                query = @"Select TramNumber from [Cleaninglist] where ID =" + id + @";";
                tempCleaning.tramNumber = (int)databaseConnection.executeReaderInt(query);
                cleaningList.Add(new Cleaner(tempCleaning.ID, tempCleaning.name, tempCleaning.task, tempCleaning.tramNumber));
            }
            return cleaningList;
        }
    }
}
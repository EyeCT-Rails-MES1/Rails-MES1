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

        public void finishTask(int tramNumber, DateTime date, User user)
        {
            string query = @"SELECT [ID] FROM [Tram] WHERE [TramNumber] = " + tramNumber + @";";
            int TramID = (int)databaseConnection.executeReaderInt(query);

            query = @"SELECT [CleaningListID] FROM [Maintenance] WHERE [TramID] = " + TramID + @";";
            int CleaningListID = (int)databaseConnection.executeReaderInt(query);

            query = @"SELECT [Task] FROM [CleaningList] WHERE [CleaningListID] = " + CleaningListID + @";";
            string Task = databaseConnection.executeReaderString(query);

            query = @"UPDATE [Maintenance] SET [EndDate] = '" + date + @"' WHERE [CleaningListID] = " + CleaningListID + @";";
            databaseConnection.executeCommand(query);

            query = @"UPDATE [Maintenance] SET [UserID] = " + user.ID + @" WHERE [CleaningListID] = " + CleaningListID + @";";
            databaseConnection.executeCommand(query);

            query = @"UPDATE [Tram] SET [Status] = " + Convert.ToInt32(Status.tramStatus.Remise) + @" WHERE [TramNumber] = " + tramNumber + @";";
            databaseConnection.executeCommand(query);

            query = @"DELETE FROM [CleaningList] WHERE [ID] = " + CleaningListID + @";";
            databaseConnection.executeCommand(query);
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Interfaces;
using DAL.Types;

namespace DAL.Persistencies
{
    public class DriverSQL : IDriver
    {
        private DatabaseConnection databaseConnection;

        public DriverSQL()
        {
            databaseConnection = new DatabaseConnection();
        }

        public void createCleaningTask(string task, Tram tram)
        {
            string query = @"SELECT MAX(ID) FROM [Cleaninglist]";
            int CleaningListID = (int)databaseConnection.executeReaderInt(query) + 1;
            query = @"INSERT INTO [Cleaninglist] VALUES (" + CleaningListID + @", " + "NULL" + @", '" + task + @"', " + tram.number + @");";
            databaseConnection.executeCommand(query);
            query = @"SELECT MAX(ID) FROM [Maintenance]";
            int MaintenanceID = (int)databaseConnection.executeReaderInt(query) + 1;
            query = @"SELECT [ID] FROM [Tram] WHERE [TramNumber] = " + tram.number + @";";
            int TramID = (int)databaseConnection.executeReaderInt(query);
            query = @"INSERT INTO [Maintenance] VALUES (" + MaintenanceID + @", " + TramID + @", " + "NULL" + @", " + CleaningListID + @", '" + DateTime.Today + @"', " + "NULL" + @");";
            databaseConnection.executeCommand(query);
        }

        public void setPriority(int priority, Tram tram)
        {
            string query = @"UPDATE [Cleaninglist] SET [Priority] = " + priority + @" WHERE [TramNumber] = " + tram.number + @");";
            databaseConnection.executeCommand(query);
        }

        public Nullable<int> getLocation(Tram tram)
        {
            string query = @"SELECT [LocationID] From [Tram] WHERE [TramNumber] = " + tram.number + @";";
            return Convert.ToInt32(databaseConnection.executeReaderInt(query));
        }
    }
}

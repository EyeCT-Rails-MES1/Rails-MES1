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
            string query = @"UPDATE [Tram] SET [Status] = " + status.ToInt() + @"WHERE [TramNumber] = " + tram.number + @";";
            databaseConnection.executeCommand(query);
        }

        public string getCleaningTasks(Tram tram)
        {
            string query = @"SELECT [Task] FROM [Cleaninglist] WHERE [TramNumber] = " + tram.number + @";";
            return databaseConnection.executeReaderString(query);
        }

        public List<string> cleaningList(Tram tram)
        {
            List<string> cleaningTasks = new List<string>();
            string query = @"SELECT COUNT(ID) FROM [CleaningList] WHERE [TramNumber] = " + tram.number + @";";

            for (int i = 0; i < databaseConnection.executeReaderInt(query); i++)
            {
                cleaningTasks.Add(getCleaningTasks(tram));
            }

            return cleaningTasks;
        }
    }
}

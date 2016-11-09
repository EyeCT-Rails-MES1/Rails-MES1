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
            string query = @"UPDATE [Maintenance] SET [EndDate] = " + date + @"WHERE [UserID] = " + user.ID + @"AND [TramID] = " + tram.number + @";";
            databaseConnection.executeCommand(query);
        }

        public void setName(User user, Tram tram)
        {
            string query = @"UPDATE [Maintenance] SET [Name] = " + user.name + @"WHERE [UserID] = " + user.ID + @"AND [TramID] = " + tram.number + @";";
            databaseConnection.executeCommand(query);
        }

        public void setStatus(Tram tram, Status.tramStatus status)
        {
            string query = @"UPDATE [Tram] SET [Status] = '" + Convert.ToInt32(status) + @"' WHERE [TramNumber] = " + tram.number + @";";
            databaseConnection.executeCommand(query);
        }

        public void getCleaningTasks()
        {
            string query = @"SELECT [Task] FROM [Cleaninglist];";
            //De methode haalt de tasks op, maar returned ze niet?
            databaseConnection.executeReaderInt(query);
        }

        public List<string> cleaningList()
        {
            throw new NotImplementedException();
        }
    }
}

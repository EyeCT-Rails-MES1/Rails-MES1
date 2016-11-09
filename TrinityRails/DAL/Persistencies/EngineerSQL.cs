using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Types;
using Classes.Enumerations;

namespace DAL.Persistencies
{
    public class EngineerSQL : IEngineer
    {
        private DatabaseConnection databaseConnection;

        public EngineerSQL()
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
            string query = @"UPDATE [Tram] SET [Status] = " + status + @"WHERE [TramNumber] = " + tram.number + @";";
            databaseConnection.executeCommand(query);
        }
    }
}

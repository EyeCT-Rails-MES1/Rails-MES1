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

        public void setCleaningTask(string task)
        {
            string query = @"UPDATE [Cleaninglist] SET [Task] = " + task +  @";";
            //Snap geen drol van onze database
            databaseConnection.executeCommand(query);
        }

        public void setPriority(int priority)
        {
            string query = @"UPDATE [Cleaninglist] SET [Priority] = " + priority + @";";
            //Snap geen drol van onze database
            databaseConnection.executeCommand(query);
        }

        int IDriver.getLocation()
        {
            throw new NotImplementedException();
            //Ik dacht dat een logaritme in de database de locatie bepaalde? En deze daarna in de database werd geupdate?
        }
    }
}

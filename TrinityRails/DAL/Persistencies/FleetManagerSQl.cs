using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using DAL.Interfaces;
using DAL.Types;
using Classes.Enumerations;

namespace DAL.Persistencies
{
    public class FleetManagerSQL : IFleetManager
    {
        private DatabaseConnection databaseConnection;

        public FleetManagerSQL()
        {
            databaseConnection = new DatabaseConnection();
        }

        public void setSectorStatus(Sector sector)
        {
            string query = @"UPDATE [Sector] SET [Status] = " + (int)sector.status + @"WHERE [SectorNumber] = " + sector.Number + @";";
            databaseConnection.executeCommand(query);
        }

        public Nullable<int> getSectorStatus(Sector sector)
        {
            string query = @"SELECT [Status] FROM [Location] WHERE [SectorNumber] = " + sector.Number + @";";
            return databaseConnection.executeReaderInt(query);
        }

        public List<Sector> getSectorList()
        {
            List<Sector> sectorList = new List<Sector>();
            string query = @"select ID from [Location];";
            List<int> sectorID = databaseConnection.executeReaderIntList(query);
            foreach (int id in sectorID)
            {
                query = @"Select RailNumber from [Location] where ID =" + id + @";";
                int railnummer = (int)databaseConnection.executeReaderInt(query);
                query = @"Select SectorNumber from [Location] where ID =" + id + @";";
                int sectornummer = (int)databaseConnection.executeReaderInt(query);
                query = @"Select Status from [Location] where ID =" + id + @";";
                RailStatus.railStatus status = (RailStatus.railStatus)databaseConnection.executeReaderInt(query);

                sectorList.Add(new Sector(railnummer, sectornummer, status));
            }
            return sectorList;
        }

        public List<Rails> getRailList()
        {
            List<Rails> railList = new List<Rails>();
            string query = @"select ID from [Location];";
            List<int> railID = databaseConnection.executeReaderIntList(query);
            foreach (int id in railID)
            {
                int count = railList.Count;
                query = @"Select RailNumber from [Location] where ID =" + id + @";";
                int railnummer = (int)databaseConnection.executeReaderInt(query);
                if (railList.Count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if(railList[i].Number == railnummer)
                        {
                            railList[i].sectorAmount++;
                        }
                        else
                        {
                            railList.Add(new Rails(railnummer, 1));
                        }
                    }
                }
                else
                {
                    railList.Add(new Rails(railnummer, 1));
                }
            }
            return railList;
        }
    }
}

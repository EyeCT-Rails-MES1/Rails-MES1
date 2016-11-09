using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrinityRailsDemo;
using System.Collections.Generic;
using DAL.Types;
using DAL.Persistencies;
using DAL.Interfaces;
using Classes.Enumerations;
using Classes;

namespace UnitTests
{
    [TestClass]
    public class UnitExample
    {
        IAdmin adminContext;
        ICleaner cleanerContext;
        IDriver driverContext;
        IEngineer engineerContext;
        IFleetManager fleetManagerContext;
        ITram tramContext;
        IUser userContext;

        public UnitExample(IAdmin adminContext, ICleaner cleanerContext, IDriver driverContext, IEngineer engineerContext, IFleetManager fleetManagerContext, ITram tramContext, IUser userContext)
        {
            this.adminContext = adminContext;
            this.cleanerContext = cleanerContext;
            this.driverContext = driverContext;
            this.engineerContext = engineerContext;
            this.fleetManagerContext = fleetManagerContext;
            this.tramContext = tramContext;
            this.userContext = userContext;
        }

        [TestMethod]
        public void testChangeUsername()
        {
            User user1 = new User(1, "Jan");
            //moet nog gegevens gebruiken uit dummydata

            User user2 = new User(1, "Jan");
            //moet nog gegevens gebruiken uit dummydata

            userContext.changeUsername(user1);
            Assert.AreEqual(user1, user2);
        }

        [TestMethod]
        public void testSetSectorStatus()
        {
            //Sector sector1 = new Sector(1, 5); //hoe check je of een status blocked/unblocked is? staat niet in constructor, dus hoe?
            //Sector sector2 = new Sector(1, 5);
            //fleetManagerContext.setSectorStatus(sector1); //geen status meegeven? (blocked/unblocked), hij wisselt iedere keer van blocked --> unblocked?
            //Assert.AreEqual(sector1, sector2);
            //komt false uit (niet gelijk als setSectorStatus is toegepast)
        }

        [TestMethod]
        public void testSetTramStatus()
        {
            Tram tram1 = new Tram(1, Status.tramStatus.Cleaning, 1, "asdf", 1);
            //moet nog gegevens gebruiken uit dummydata

            Tram tram2 = new Tram(1, Status.tramStatus.Repair, 1, "asdf", 1);
            //moet nog gegevens gebruiken uit dummydata

            tramContext.setStatus(tram2, Status.tramStatus.Cleaning);
            Assert.AreEqual(tram1, tram2);
        }

        [TestMethod]
        public void testAddCleaningtask()
        {
            List<string> tasks1 = new List<string>();
            tasks1.Add("Schoonmaken tram 1");
            tasks1.Add("Schoonmaken tram 2");
            tasks1.Add("Schoonmaken tram 3");

            List<string> tasks2 = new List<string>();
            tasks2.Add("Schoonmaken tram 1");
            tasks2.Add("Schoonmaken tram 2");
            tasks2.Add("Schoonmaken tram 4");

            string verander = tasks2[3];
            //driverContext.setCleaningTask(verander); verander in "Schoonmaken tram 3"
            //Luuk, kan je wel iets? Word eens legend #1. Ez pz. Ik heb al cardback.

            CollectionAssert.AreEqual(tasks1, tasks2);
        }
    }
}
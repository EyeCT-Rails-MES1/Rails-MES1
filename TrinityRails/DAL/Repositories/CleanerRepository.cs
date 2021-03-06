﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Types;
using Classes.Enumerations;
using Classes;

namespace DAL.Repositories
{
    public class CleanerRepository
    {
        ICleaner context;
        List<User> userList = new List<User>();

        public CleanerRepository(ICleaner context)
        {
            this.context = context;
        }

        public List<Cleaner> getCleaningList()
        {
            return context.cleaningList();
        }

        public void finishTask(int tramNumber, DateTime date, User user)
        {
            context.finishTask(tramNumber, date, user);
        }

        public List<MaintenanceData> getMaintenanceData()
        {
            return context.getMaintenanceData();
        }
    }
}
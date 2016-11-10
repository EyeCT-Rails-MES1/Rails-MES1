using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using DAL.Types;
using DAL.Repositories;
using DAL.Interfaces;
using DAL.Persistencies;

namespace TrinityRailsDemo
{
    public partial class CleanerForm : Form
    {
        CleanerRepository CleanerRepo = new CleanerRepository(new CleanerSQL());
        List<Cleaner> cleaningList = new List<Cleaner>();
        List<MaintenanceData> maintenanceList = new List<MaintenanceData>();
        User user;

        public CleanerForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void CleanerForm_Load(object sender, EventArgs e)
        {
            cleaningList = CleanerRepo.getCleaningList();
            foreach (Cleaner taak in cleaningList)
            {
                lbCleaning.Items.Add(taak.task + ", " + Convert.ToString(taak.tramNumber));
            }
            maintenanceList = CleanerRepo.getMaintenanceData();
            foreach(MaintenanceData data in maintenanceList)
            {
                lbDone.Items.Add(data.TramID + ", " + data.UserID + ", " + data.CleaningListID + ", " + data.StartDate.ToString() + ", " + data.EndDate.ToString());
            }
        }

        private void btnFinishCleaning_Click(object sender, EventArgs e)
        {
            string tramNumber = "";
            bool comma = false;
            foreach(char character in lbCleaning.SelectedItem.ToString())
            {
                if (comma)
                {
                    tramNumber += character;
                }
                if (character == ',')
                {
                    comma = true;
                }
            }
            tramNumber.Remove(0, 1);
            CleanerRepo.finishTask(Convert.ToInt32(tramNumber), DateTime.Today, user);
            lbCleaning.Items.Clear();
            cleaningList = CleanerRepo.getCleaningList();
            foreach (Cleaner taak in cleaningList)
            {
                lbCleaning.Items.Add(taak.task + ", " + Convert.ToString(taak.tramNumber));
            }
            lbDone.Items.Clear();
            foreach (MaintenanceData data in maintenanceList)
            {
                lbDone.Items.Add(data.TramID + ", " + data.UserID + ", " + data.CleaningListID + ", " + data.StartDate.ToString() + ", " + data.EndDate.ToString())
            }

        }
    }
}
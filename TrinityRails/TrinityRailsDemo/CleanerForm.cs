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
        }

        private void btnFinishCleaning_Click(object sender, EventArgs e)
        {
            string tramNumber = "";
            bool comma = false;
            foreach(char character in lbCleaning.SelectedItem.ToString())
            {
                if(character == ',')
                {
                    comma = true;
                }
                if(comma)
                {
                    tramNumber += character;
                }
            }
            tramNumber.Remove(0, 1);
            CleanerRepo.finishTask(Convert.ToInt32(tramNumber), DateTime.Today);
        }
    }
}

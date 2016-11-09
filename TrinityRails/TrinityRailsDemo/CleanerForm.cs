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
        List<string> Taken = new List<string>();
        User user;

        public CleanerForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void CleanerForm_Load(object sender, EventArgs e)
        {
            //Taken = CleanerRepo.getCleaningList();
            foreach (string taak in Taken)
            {
                lbCleaning.Items.Add(taak);
            }
        }

        private void btnFinishCleaning_Click(object sender, EventArgs e)
        {
            int selected = lbCleaning.SelectedIndex;
            //CleanerRepo.finishCleaning(dtDate.Value,  Taken[selected]);
        }
    }
}

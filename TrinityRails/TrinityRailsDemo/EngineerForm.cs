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
    public partial class EngineerForm : Form
    {
        TramRepository TramRepo = new TramRepository(new TramSQL());
        EngineerRepository EngineerRepo = new EngineerRepository(new EngineerSQL());
        List<Tram> Trams = new List<Tram>();
        User user;

        public EngineerForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void EngineerForm_Load(object sender, EventArgs e)
        {
            Trams = TramRepo.getTrams();
            foreach (Tram tram in Trams)
            {
                if (tram.status == Classes.Enumerations.Status.tramStatus.Defect || tram.status == Classes.Enumerations.Status.tramStatus.Repair)
                {
                    lbRepair.Items.Add(tram.number + ": " + tram.status);
                }
            }
        }

        private void btnFinishRepair_Click(object sender, EventArgs e)
        {
            int Selected = lbRepair.SelectedIndex;
            EngineerRepo.finishRepair(Trams[Selected], user, dtDate.Value, Classes.Enumerations.Status.tramStatus.Remise);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Selected = lbRepair.SelectedIndex;
            EngineerRepo.setRepair(Trams[Selected], user, Classes.Enumerations.Status.tramStatus.Repair);
        }

        private void lbRepair_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

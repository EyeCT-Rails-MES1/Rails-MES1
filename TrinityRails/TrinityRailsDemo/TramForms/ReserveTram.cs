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

namespace TrinityRailsDemo.SideForms
{
    public partial class ReserveTram : Form
    {
        public ReserveTram()
        {
            InitializeComponent();
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            TramRepository TramRepo = new TramRepository(new TramSQL());
            foreach (Tram tram in TramRepo.getTrams())
            {
                if (tram.number == Convert.ToInt32(tbTramNumber.Text))
                {
                    if (cbRepair.Checked)
                    {
                        TramRepo.setStatus(tram, Classes.Enumerations.Status.tramStatus.Repair);
                    }
                    Reservation reservation = new Reservation(tram, tram.rail);
                    tram.rail = Convert.ToInt32(tbRailNumber.Text);
                    TramRepo.setLocation(tram);
                }
            }
            this.Close();
        }
    }
}

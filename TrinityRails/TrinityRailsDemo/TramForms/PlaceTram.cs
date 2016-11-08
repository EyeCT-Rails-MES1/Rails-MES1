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
    public partial class PlaceTram : Form
    {
        public PlaceTram()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TramRepository TramRepo = new TramRepository(new TramSQL());
            foreach (Tram tram in TramRepo.getTrams())
            {
                if (tram.number == Convert.ToInt32(tbTramNumber.Text))
                {
                    tram.sector = Convert.ToInt32(tbSectorNumber.Text);
                    tram.rail = Convert.ToInt32(tbRailNumber.Text);
                    TramRepo.setLocation(tram);
                }
            }
        }
    }
}

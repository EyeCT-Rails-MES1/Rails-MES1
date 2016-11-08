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
    public partial class DeleteTram : Form
    {
        public DeleteTram()
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
                    tram.sector = 0;
                    TramRepo.setLocation(tram);
                }
            }
            this.Close();
        }
    }
}

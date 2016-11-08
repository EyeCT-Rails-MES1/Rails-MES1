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
    public partial class TramStatus : Form
    {
        public TramStatus()
        {
            InitializeComponent();
        }

        private void TramStatus_Load(object sender, EventArgs e)
        {
            cbTramStatus.Items.Clear();
            cbTramStatus.Items.Add(Classes.Enumerations.Status.tramStatus.Cleaning);
            cbTramStatus.Items.Add(Classes.Enumerations.Status.tramStatus.Repair);
            cbTramStatus.Items.Add(Classes.Enumerations.Status.tramStatus.Remise);
            cbTramStatus.Items.Add(Classes.Enumerations.Status.tramStatus.Service);
            cbTramStatus.Items.Add(Classes.Enumerations.Status.tramStatus.Defect);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TramRepository TramRepo = new TramRepository(new TramSQL());
            foreach (Tram tram in TramRepo.getTrams())
            {
                if (tram.number == Convert.ToInt32(tbTramNumber.Text))
                {
                    tram.status = (Classes.Enumerations.Status.tramStatus)cbTramStatus.SelectedItem;
                    TramRepo.setStatus(tram, tram.status);
                }
            }
            this.Close();
        }
    }
}

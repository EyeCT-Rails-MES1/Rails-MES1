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

namespace TrinityRailsDemo.RailForms
{
    public partial class BlockRailSector : Form
    {
        FleetManagerRepository fleetRepo = new FleetManagerRepository(new FleetManagerSQL());
        public BlockRailSector()
        {
            InitializeComponent();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            foreach (Sector sector in fleetRepo.getSectorList())
            {
                if (sector.railNumber == Convert.ToInt32(tbRailNumber.Text))
                {
                    if (sector.Number == Convert.ToInt32(tbSectorNumber.Text))
                    {
                        if (sector.status == Classes.Enumerations.RailStatus.railStatus.Available)
                        {
                            fleetRepo.blockSector(sector);
                        }
                        else if (sector.status == Classes.Enumerations.RailStatus.railStatus.Blocked)
                        {
                            fleetRepo.unblockSector(sector);
                        }
                    }
                }
            }
        }
    }
}

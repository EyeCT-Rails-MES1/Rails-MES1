using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes.Enumerations;
using DAL.Types;
using TrinityRailsDemo.RailForms;
using TrinityRailsDemo.SideForms;
using DAL.Repositories;
using DAL.Persistencies;
using Classes;

namespace TrinityRailsDemo
{
    public partial class MainForm : Form
    {
        TextBox currentTextBox;
        User user;
        List<Tram> trams;
        TramRepository tramRepo = new TramRepository(new TramSQL());
        FleetManagerRepository fleetRepo = new FleetManagerRepository(new FleetManagerSQL());

        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
            btnExit.Enabled = true;
            switch (user.function)
            {
                case Function.userFunction.Cleaner:
                    btnSchoonmaak.Enabled = true;
                    break;
                case Function.userFunction.Driver:
                    btnDiensten.Enabled = true;
                    break;
                case Function.userFunction.Engineer:
                    btnRepair.Enabled = true;
                    break;
                case Function.userFunction.Fleetmanager:
                    btnDiensten.Enabled = true;
                    btnLijnen.Enabled = true;
                    btnSporen.Enabled = true;
                    btnTrams.Enabled = true;
                    break;
                case Function.userFunction.Admin:

                    btnUsers.Enabled = true;
                    break;
                default:
                    btnDiensten.Enabled = false;
                    btnLijnen.Enabled = false;
                    btnRepair.Enabled = false;
                    btnSchoonmaak.Enabled = false;
                    btnSporen.Enabled = false;
                    btnTrams.Enabled = false;
                    break;
            }
        }

        //Verander de naam van context menu strip (nu cmsVakjes) in iets wat normaal klinkt
        private void ShowTextBoxCMS(Control cont, Object current)
        {
            if (user.function == Function.userFunction.Fleetmanager)
            {
                TextBox selected = (TextBox)current;
                cmsButtons.Show(cont, selected.Location.X, selected.Location.Y + selected.Height);
            }
        }

        private void ShowCMS(Control cont, object current, ContextMenuStrip cms)
        {
            Button selected = (Button)current;
            cms.Show(cont, selected.Location.X, selected.Location.Y + selected.Height);
        }


        // hier alle mouseclick events in zetten
        #region Mouse click CMS events


        private void txt_R38S1_MouseClick(object sender, MouseEventArgs e)
        {
            ShowTextBoxCMS(this, sender);
            currentTextBox = (TextBox)sender;
        }

        private void txt_R38S2_Click(object sender, EventArgs e)
        {
            ShowTextBoxCMS(this, sender);
            currentTextBox = (TextBox)sender;
        }

        private void txt_R37S2_Click(object sender, EventArgs e)
        {
            ShowTextBoxCMS(this, sender);
            currentTextBox = (TextBox)sender;
        }

        private void txt_R36S2_Click(object sender, EventArgs e)
        {
            ShowTextBoxCMS(this, sender);
            currentTextBox = (TextBox)sender;
        }

        private void txt_R38S3_Click(object sender, EventArgs e)
        {
            ShowTextBoxCMS(this, sender);
            currentTextBox = (TextBox)sender;
        }

        private void txt_R37S3_Click(object sender, EventArgs e)
        {
            ShowTextBoxCMS(this, sender);
            currentTextBox = (TextBox)sender;
        }

        private void txt_R36S3_Click(object sender, EventArgs e)
        {
            ShowTextBoxCMS(this, sender);
            currentTextBox = (TextBox)sender;
        }

        private void txt_R38S4_Click(object sender, EventArgs e)
        {
            ShowTextBoxCMS(this, sender);
            currentTextBox = (TextBox)sender;
        }

        private void txt_R37S4_Click(object sender, EventArgs e)
        {
            ShowTextBoxCMS(this, sender);
            currentTextBox = (TextBox)sender;
        }

        private void txt_R36S4_Click(object sender, EventArgs e)
        {
            ShowTextBoxCMS(this, sender);
            currentTextBox = (TextBox)sender;
        }

        private void txt_R38S5_Click(object sender, EventArgs e)
        {
            ShowTextBoxCMS(this, sender);
            currentTextBox = (TextBox)sender;
        }

        private void txt_R37S5_Click(object sender, EventArgs e)
        {
            ShowTextBoxCMS(this, sender);
            currentTextBox = (TextBox)sender;
        }

        private void txt_R36S5_Click(object sender, EventArgs e)
        {
            ShowTextBoxCMS(this, sender);
            currentTextBox = (TextBox)sender;
        }


        #endregion

        #region Button Click Events
        private void btnTrams_Click(object sender, EventArgs e)
        {
            ShowCMS(this, btnTrams, cmsTram);
        }
        private void btnSporen_Click(object sender, EventArgs e)
        {
            ShowCMS(this, btnSporen, cmsSporen);
        }
        private void btnLijnen_Click(object sender, EventArgs e)
        {
            ShowCMS(this, btnLijnen, cmsLijnen);
        }

        private void btnDiensten_Click(object sender, EventArgs e)
        {
            DriverForm form = new DriverForm(user);
            form.Show();
        }

        private void btnSchoonmaak_Click(object sender, EventArgs e)
        {
            CleanerForm form = new CleanerForm(user);
            form.Show();
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            EngineerForm form = new EngineerForm(user);
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            form.Show();
        }
        #endregion

        #region Tram Dropdown
        private void tsmPlaatsen_Click(object sender, EventArgs e)
        {
            PlaceTram form = new PlaceTram();
            form.Show();
        }

        private void tsmVerwijderen_Click(object sender, EventArgs e)
        {
            DeleteTram form = new DeleteTram();
            form.Show();
        }

        private void tsmReserveren_Click(object sender, EventArgs e)
        {
            ReserveTram form = new ReserveTram();
            form.Show();
        }

        private void tsmStatusVeranderen_Click(object sender, EventArgs e)
        {
            TramStatus form = new TramStatus();
            form.Show();
        }

        private void tsmInformatie_Click(object sender, EventArgs e)
        {
            TramInfo form = new TramInfo();
            form.Show();
        }
        #endregion
        #region Sporen Dropdown
        private void spoorSectorBlokkerenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void spoorUpdatenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void spoorInformatieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion



        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void cmsButtons_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tsmSpoorBlok_Click(object sender, EventArgs e)
        {
            foreach (Sector sector in fleetRepo.getSectorList())
            {
                if (sector.railNumber == Convert.ToInt32(currentTextBox.Name.Substring(currentTextBox.Name.IndexOf("R") + 1, 2)))
                {
                    if (sector.Number == Convert.ToInt32(currentTextBox.Name.Substring(currentTextBox.Name.IndexOf("S") + 1)))
                    {
                        if(sector.status == RailStatus.railStatus.Blocked)
                        {
                            sector.status = RailStatus.railStatus.Available;
                        }
                        else if(sector.status == RailStatus.railStatus.Available)
                        {
                            sector.status = RailStatus.railStatus.Blocked;
                        }
                        else
                        {
                            MessageBox.Show("Occupied");
                        }
                    }

                }
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Sector> sectors = new List<Sector>();
            foreach (Tram tram in tramRepo.getTrams())
            {
                sectors = fleetRepo.getSectorList();
                if (tram.rail != 0 && tram.sector != 0)
                {
                    

                }
            }
        }
    }
}

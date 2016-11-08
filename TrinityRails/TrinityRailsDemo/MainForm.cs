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

namespace TrinityRailsDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnDiensten.Enabled = true;
            btnExit.Enabled = true;
            btnLijnen.Enabled = true;
            btnRepair.Enabled = true;
            btnSchoonmaak.Enabled = true;
            btnSporen.Enabled = true;
            btnTrams.Enabled = true;
        }
        public MainForm(User user)
        {
            InitializeComponent();
            switch (user.function)
            {
                case Function.userFunction.Cleaner:
                    btnSchoonmaak.Enabled = true;
                    btnExit.Enabled = true;
                    break;
                case Function.userFunction.Driver:
                    break;
                case Function.userFunction.Engineer:
                    break;
                case Function.userFunction.Fleetmanager:
                    break;
                case Function.userFunction.Admin:
                    btnDiensten.Enabled = true;
                    btnExit.Enabled = true;
                    btnLijnen.Enabled = true;
                    btnRepair.Enabled = true;
                    btnSchoonmaak.Enabled = true;
                    btnSporen.Enabled = true;
                    btnTrams.Enabled = true;
                    break;
                default:
                    btnDiensten.Enabled = true;
                    btnExit.Enabled = true;
                    btnLijnen.Enabled = true;
                    btnRepair.Enabled = true;
                    btnSchoonmaak.Enabled = true;
                    btnSporen.Enabled = true;
                    btnTrams.Enabled = true;
                    break;
            }
        }

        //Verander de naam van context menu strip (nu cmsVakjes) in iets wat normaal klinkt
        private void ShowTextBoxCMS(Control cont, Object current)
        {
            TextBox selected = (TextBox)current;
            cmsButtons.Show(cont, selected.Location.X, selected.Location.Y + selected.Height);
        }

        private void ShowCMS(Control cont, object current, ContextMenuStrip cms)
        {
            Button selected = (Button)current;
            cms.Show(cont, selected.Location.X, selected.Location.Y + selected.Height);
        }
        
        //test voor de het menu klik. (vind je bij events bij properties)
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ay");
        }

        // hier alle mouseclick events in zetten
        #region Mouse click CMS events


        private void txt_R38S1_MouseClick(object sender, MouseEventArgs e)
        {
            ShowTextBoxCMS(this, sender);
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
            ShowCMS(this, btnDiensten,cmsDiensten);
        }

        private void btnSchoonmaak_Click(object sender, EventArgs e)
        {
            ShowCMS(this, btnSchoonmaak, cmsSchoonmaak);
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            ShowCMS(this, btnRepair, cmsReparatie);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}

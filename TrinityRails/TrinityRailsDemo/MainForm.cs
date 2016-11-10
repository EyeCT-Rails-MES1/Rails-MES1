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
        TextBox[] textBoxes12 = new TextBox[1];
        TextBox[] textBoxes13 = new TextBox[1];
        TextBox[] textBoxes14 = new TextBox[1];
        TextBox[] textBoxes15 = new TextBox[1];
        TextBox[] textBoxes16 = new TextBox[1];
        TextBox[] textBoxes17 = new TextBox[1];
        TextBox[] textBoxes18 = new TextBox[1];
        TextBox[] textBoxes19 = new TextBox[1];
        TextBox[] textBoxes20 = new TextBox[1];
        TextBox[] textBoxes21 = new TextBox[1];
        TextBox[] textBoxes30 = new TextBox[3];
        TextBox[] textBoxes31 = new TextBox[3];
        TextBox[] textBoxes32 = new TextBox[4];
        TextBox[] textBoxes33 = new TextBox[4];
        TextBox[] textBoxes34 = new TextBox[4];
        TextBox[] textBoxes35 = new TextBox[4];
        TextBox[] textBoxes36 = new TextBox[4];
        TextBox[] textBoxes37 = new TextBox[4];
        TextBox[] textBoxes38 = new TextBox[4];
        TextBox[] textBoxes40 = new TextBox[5];
        TextBox[] textBoxes41 = new TextBox[4];
        TextBox[] textBoxes42 = new TextBox[4];
        TextBox[] textBoxes43 = new TextBox[4];
        TextBox[] textBoxes44 = new TextBox[4];
        TextBox[] textBoxes45 = new TextBox[9];
        TextBox[] textBoxes51 = new TextBox[5];
        TextBox[] textBoxes52 = new TextBox[6];
        TextBox[] textBoxes53 = new TextBox[6];
        TextBox[] textBoxes54 = new TextBox[7];
        TextBox[] textBoxes55 = new TextBox[7];
        TextBox[] textBoxes56 = new TextBox[7];
        TextBox[] textBoxes57 = new TextBox[8];
        TextBox[] textBoxes58 = new TextBox[6];
        TextBox[] textBoxes61 = new TextBox[2];
        TextBox[] textBoxes62 = new TextBox[2];
        TextBox[] textBoxes63 = new TextBox[4];
        TextBox[] textBoxes64 = new TextBox[4];
        TextBox[] textBoxes74 = new TextBox[4];
        TextBox[] textBoxes75 = new TextBox[5];
        TextBox[] textBoxes76 = new TextBox[6];
        TextBox[] textBoxes77 = new TextBox[6];
        TextBox[] chosenBoxes = new TextBox[10];
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
            textBoxes12[0] = txt_R12S1;
            textBoxes13[0] = txt_R13S1;
            textBoxes14[0] = txt_R14S1;
            textBoxes15[0] = txt_R15S1;
            textBoxes12[0] = txt_R12S1;
            textBoxes13[0] = txt_R13S1;
            textBoxes14[0] = txt_R14S1;
            textBoxes15[0] = txt_R15S1;
            textBoxes16[0] = txt_R16S1;
            textBoxes17[0] = txt_R17S1;
            textBoxes18[0] = txt_R18S1;
            textBoxes19[0] = txt_R19S1;
            textBoxes20[0] = txt_R20S1;
            textBoxes21[0] = txt_R21S1;

            textBoxes30[0] = txt_R30S2;
            textBoxes30[1] = txt_R30S3;
            textBoxes30[2] = txt_R30S4;
            textBoxes31[0] = txt_R31S2;
            textBoxes31[1] = txt_R31S3;
            textBoxes31[2] = txt_R31S4;
            textBoxes32[0] = txt_R32S2;
            textBoxes32[1] = txt_R32S3;
            textBoxes32[2] = txt_R32S4;
            textBoxes32[3] = txt_R32S5;
            textBoxes33[0] = txt_R33S2;
            textBoxes33[1] = txt_R33S3;
            textBoxes33[2] = txt_R33S4;
            textBoxes33[3] = txt_R33S5;
            textBoxes34[0] = txt_R34S2;
            textBoxes34[1] = txt_R34S3;
            textBoxes34[2] = txt_R34S4;
            textBoxes34[3] = txt_R34S5;
            textBoxes35[0] = txt_R35S2;
            textBoxes35[1] = txt_R35S3;
            textBoxes35[2] = txt_R35S4;
            textBoxes35[3] = txt_R35S5;
            textBoxes36[0] = txt_R36S1;
            textBoxes36[1] = txt_R36S2;
            textBoxes36[2] = txt_R36S3;
            textBoxes36[3] = txt_R36S4;
            textBoxes37[0] = txt_R37S1;
            textBoxes37[1] = txt_R37S2;
            textBoxes37[2] = txt_R37S3;
            textBoxes37[3] = txt_R37S4;
            textBoxes38[0] = txt_R38S1;
            textBoxes38[1] = txt_R38S2;
            textBoxes38[2] = txt_R38S3;
            textBoxes38[3] = txt_R38S4;

            textBoxes40[0] = txt_R40S1;
            textBoxes40[1] = txt_R40S2;
            textBoxes40[2] = txt_R40S3;
            textBoxes40[3] = txt_R40S4;
            textBoxes40[4] = txt_R40S5;
            textBoxes41[0] = txt_R41S2;
            textBoxes41[1] = txt_R41S3;
            textBoxes41[2] = txt_R41S4;
            textBoxes41[3] = txt_R41S5;
            textBoxes42[0] = txt_R42S2;
            textBoxes42[1] = txt_R42S3;
            textBoxes42[2] = txt_R42S4;
            textBoxes42[3] = txt_R42S5;
            textBoxes43[0] = txt_R43S2;
            textBoxes43[1] = txt_R43S3;
            textBoxes43[2] = txt_R43S4;
            textBoxes43[3] = txt_R43S5;
            textBoxes44[0] = txt_R44S2;
            textBoxes44[1] = txt_R44S3;
            textBoxes44[2] = txt_R44S4;
            textBoxes44[3] = txt_R44S5;

            textBoxes45[0] = txt_R45S2;
            textBoxes45[1] = txt_R45S3;
            textBoxes45[2] = txt_R45S4;
            textBoxes45[3] = txt_R45S5;
            textBoxes45[4] = txt_R45S6;
            textBoxes45[5] = txt_R45S7;
            textBoxes45[6] = txt_R45S8;
            textBoxes45[7] = txt_R45S9;
            textBoxes45[8] = txt_R45S10;

            textBoxes51[0] = txt_R51S2;
            textBoxes51[1] = txt_R51S3;
            textBoxes51[2] = txt_R51S4;
            textBoxes51[3] = txt_R51S5;
            textBoxes51[4] = txt_R51S6;
            textBoxes52[0] = txt_R52S2;
            textBoxes52[1] = txt_R52S3;
            textBoxes52[2] = txt_R52S4;
            textBoxes52[3] = txt_R52S5;
            textBoxes52[4] = txt_R52S6;
            textBoxes52[5] = txt_R52S7;
            textBoxes53[0] = txt_R53S2;
            textBoxes53[1] = txt_R53S3;
            textBoxes53[2] = txt_R53S4;
            textBoxes53[3] = txt_R53S5;
            textBoxes53[4] = txt_R53S6;
            textBoxes53[5] = txt_R53S7;
            textBoxes54[0] = txt_R54S2;
            textBoxes54[1] = txt_R54S3;
            textBoxes54[2] = txt_R54S4;
            textBoxes54[3] = txt_R54S5;
            textBoxes54[4] = txt_R54S6;
            textBoxes54[5] = txt_R54S7;
            textBoxes54[6] = txt_R54S8;
            textBoxes55[0] = txt_R55S2;
            textBoxes55[1] = txt_R55S3;
            textBoxes55[2] = txt_R55S4;
            textBoxes55[3] = txt_R55S5;
            textBoxes55[4] = txt_R55S6;
            textBoxes55[5] = txt_R55S7;
            textBoxes55[6] = txt_R55S8;
            textBoxes56[0] = txt_R56S2;
            textBoxes56[1] = txt_R56S2;
            textBoxes56[2] = txt_R56S2;
            textBoxes56[3] = txt_R56S2;
            textBoxes56[4] = txt_R56S2;
            textBoxes56[5] = txt_R56S2;
            textBoxes56[6] = txt_R56S2;
            textBoxes57[0] = txt_R57S2;
            textBoxes57[1] = txt_R57S3;
            textBoxes57[2] = txt_R57S4;
            textBoxes57[3] = txt_R57S5;
            textBoxes57[4] = txt_R57S6;
            textBoxes57[5] = txt_R57S7;
            textBoxes57[6] = txt_R57S8;
            textBoxes57[7] = txt_R57S9;
            textBoxes58[0] = txt_R58S1;
            textBoxes58[1] = txt_R58S2;
            textBoxes58[2] = txt_R58S3;
            textBoxes58[3] = txt_R58S4;
            textBoxes58[4] = txt_R58S5;
            textBoxes58[5] = txt_R58S6;

            textBoxes61[0] = txt_R61S2;
            textBoxes61[1] = txt_R61S3;
            textBoxes62[0] = txt_R62S2;
            textBoxes62[1] = txt_R62S2;
            textBoxes63[0] = txt_R63S2;
            textBoxes63[1] = txt_R63S3;
            textBoxes63[2] = txt_R63S4;
            textBoxes63[3] = txt_R63S5;
            textBoxes64[0] = txt_R64S2;
            textBoxes64[1] = txt_R64S3;
            textBoxes64[2] = txt_R64S4;
            textBoxes64[3] = txt_R64S5;

            textBoxes74[0] = txt_R74S1;
            textBoxes74[1] = txt_R74S2;
            textBoxes74[2] = txt_R74S3;
            textBoxes74[3] = txt_R74S4;
            textBoxes75[0] = txt_R75S1;
            textBoxes75[1] = txt_R75S2;
            textBoxes75[2] = txt_R75S3;
            textBoxes75[3] = txt_R75S4;
            textBoxes75[4] = txt_R75S5;
            textBoxes76[0] = txt_R76S1;
            textBoxes76[1] = txt_R76S2;
            textBoxes76[2] = txt_R76S3;
            textBoxes76[3] = txt_R76S4;
            textBoxes76[4] = txt_R76S5;
            textBoxes76[5] = txt_R76S6;
            textBoxes77[0] = txt_R77S1;
            textBoxes77[1] = txt_R77S2;
            textBoxes77[2] = txt_R77S3;
            textBoxes77[3] = txt_R77S4;
            textBoxes77[4] = txt_R77S5;
            textBoxes77[5] = txt_R77S6;
            
            refreshTrams();

            //List<Sector> sectors = new List<Sector>();
            //foreach (Tram tram in tramRepo.getTrams())
            //{
            //    sectors = fleetRepo.getSectorList();
            //    if (tram.rail != 0 && tram.sector != 0)
            //    {

            //    }
            //}
        }

        public TextBox[] ReturnSectorBoxes(int spoorNummer)
        {
            switch (spoorNummer)
            {
                case 12:
                    return textBoxes12;
                case 13:
                    return textBoxes13;
                case 14:
                    return textBoxes14;
                case 15:
                    return textBoxes15;
                case 16:
                    return textBoxes16;
                case 17:
                    return textBoxes17;
                case 18:
                    return textBoxes18;
                case 19:
                    return textBoxes19;
                case 20:
                    return textBoxes20;
                case 21:
                    return textBoxes21;
                case 32:
                    return textBoxes32;
                case 33:
                    return textBoxes33;
                case 34:
                    return textBoxes34;
                case 35:
                    return textBoxes35;
                case 36:
                    return textBoxes36;
                case 37:
                    return textBoxes37;
                case 38:
                    return textBoxes38;
                case 40:
                    return textBoxes40;
                case 41:
                    return textBoxes41;
                case 42:
                    return textBoxes42;
                case 43:
                    return textBoxes43;
                case 44:
                    return textBoxes44;
                case 45:
                    return textBoxes45;
                case 51:
                    return textBoxes51;
                case 52:
                    return textBoxes52;
                case 53:
                    return textBoxes53;
                case 54:
                    return textBoxes54;
                case 55:
                    return textBoxes55;
                case 56:
                    return textBoxes56;
                case 57:
                    return textBoxes57;
                case 61:
                    return textBoxes61;
                case 62:
                    return textBoxes62;
                case 63:
                    return textBoxes63;
                case 64:
                    return textBoxes64;
                case 74:
                    return textBoxes74;
                case 75:
                    return textBoxes75;
                case 76:
                    return textBoxes76;
                case 77:
                    return textBoxes77;
                default:
                    return textBoxes58;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (trams != tramRepo.getTramsInRemise())
            {
                refreshTrams();
            }
        }

        public void refreshTrams()
        {
            trams = tramRepo.getTramsInRemise();
            foreach (Tram tram in trams)
            {
                if (tram.status == Status.tramStatus.Remise)
                {
                    TextBox[] chosenBoxes = ReturnSectorBoxes(tram.rail);
                    chosenBoxes[tram.sector - 1].Text = Convert.ToString(tram.number);
                }
            }
        }
    }
}

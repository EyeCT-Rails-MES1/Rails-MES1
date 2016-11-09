using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Interfaces;
using DAL.Persistencies;
using DAL.Types;
using DAL.Repositories;
using Phidgets;
using Phidgets.Events;

namespace TrinityRailsDemo
{
    public partial class InlogForm : Form
    {
        private RFID rfid;

        public InlogForm()
        {
            InitializeComponent();
            rfid = new RFID(); //Declare an RFID object
        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            UserRepository repository = new UserRepository(new UserSQL());
            User user = repository.login(txtGebruikersnaam.Text, txtWachtwoord.Text);
            if (user != null)
            {
                MainForm form = new MainForm(user);
                form.Show();
            }
            else
            {
                MessageBox.Show("Failed to log on");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnScanRFID_Click(object sender, EventArgs e)
        {
            //initialize Phidgets RFID reader and hook the event handlers
            rfid.Error += new ErrorEventHandler(rfid_Error);

            rfid.Tag += new TagEventHandler(rfid_Tag);

            //open the connection
            rfid.open();

            //wait for an rfid
            rfid.waitForAttachment();

            //turn on the lights to show it is on
            rfid.Antenna = true;
            btnScanRFID.Enabled = false;
        }

        private void rfid_Tag(object sender, TagEventArgs e)
        {
            //Vergelijk e.Tag met de RFID code van alle trams
        }

        static void rfid_Error(object sender, ErrorEventArgs e)
        {

        }
    }
}

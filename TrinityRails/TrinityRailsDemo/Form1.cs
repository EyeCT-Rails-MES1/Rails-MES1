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
    public partial class Form1 : Form
    {
        private RFID rfid;

        public Form1()
        {
            InitializeComponent();
            rfid = new RFID(); //Declare an RFID object
        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
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
            btnRFIDInloggen.Enabled = false;
        }

        private void rfid_Tag(object sender, TagEventArgs e)
        {
            TramRepository tramRepository = new TramRepository(new TramSQL());
            foreach (Tram tram in tramRepository.getTrams())
            {
                if (e.Tag == tram.RFID)
                {
                    throw new NotImplementedException();
                }
            }
        }

        static void rfid_Error(object sender, ErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            rfid.Tag -= new TagEventHandler(rfid_Tag);
            Application.DoEvents();
            rfid.close();
        }
    }
}

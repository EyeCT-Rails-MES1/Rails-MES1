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
        public InlogForm()
        {
            InitializeComponent();
        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            UserRepository repository = new UserRepository(new UserSQL());
            User user = repository.login(txtGebruikersnaam.Text, txtWachtwoord.Text);
            if (user != null)
            {
                MainForm form = new MainForm(user);
            }
            else
            {
                MessageBox.Show("Failed to log on");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

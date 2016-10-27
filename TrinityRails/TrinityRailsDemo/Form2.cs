using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinityRailsDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Verander de naam van context menu strip (nu cmsVakjes) in iets wat normaal klinkt

        private void ShowTextBoxCMS(Control cont, Object current)
        {
            TextBox selected = (TextBox)current;
            cmsButtons.Show(cont, selected.Location.X, selected.Location.Y + selected.Height);
        }

        private void btnTrams_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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



    }
}

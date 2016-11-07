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
    public partial class DriverForm : Form
    {
        public DriverForm()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbTramNumber.Text = tbTramNumber.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbTramNumber.Text = tbTramNumber.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbTramNumber.Text = tbTramNumber.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbTramNumber.Text = tbTramNumber.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbTramNumber.Text = tbTramNumber.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbTramNumber.Text = tbTramNumber.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbTramNumber.Text = tbTramNumber.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbTramNumber.Text = tbTramNumber.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbTramNumber.Text = tbTramNumber.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbTramNumber.Text = tbTramNumber.Text + "0";
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            if (tbTramNumber.TextLength > 1)
            {
                tbTramNumber.Text = tbTramNumber.Text.Substring(0, tbTramNumber.TextLength - 1);
            }
            else
            {
                tbTramNumber.Text = "";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbJa.Checked && tbRemarks.Text == "" || cbNee.Checked)
            {
                if (cbxNeedCleaning.Checked && tbRemarks.Text == "" || cbxNeedCleaning.Checked == false)
                {
                    if (tbTramNumber.TextLength == 3 || tbTramNumber.TextLength == 4)
                    {
                        btnConfirm.IsAccessible = true;
                    }
                }
            }
        }
    }
}

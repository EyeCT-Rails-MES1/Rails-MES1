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
    public partial class CleanerForm : Form
    {
        public CleanerForm()
        {
            InitializeComponent();
        }

        private void CleanerForm_Load(object sender, EventArgs e)
        {
            cbTramStatus.Items.Clear();
            cbTramStatus.Items.Add(Classes.Enumerations.Status.tramStatus.Cleaning);
            cbTramStatus.Items.Add(Classes.Enumerations.Status.tramStatus.Repair);
            cbTramStatus.Items.Add(Classes.Enumerations.Status.tramStatus.Remise);
            cbTramStatus.Items.Add(Classes.Enumerations.Status.tramStatus.Service);
            cbTramStatus.Items.Add(Classes.Enumerations.Status.tramStatus.Defect);
        }
    }
}

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

namespace TrinityRailsDemo
{
    public partial class UserForm : Form
    {
        AdminRepository adminRepo = new AdminRepository(new AdminSQL());
        List<User> Users = new List<User>();
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            AdminRepository adminRepo = new AdminRepository(new AdminSQL());
            adminRepo.create(Convert.ToInt32(tbID.Text), tbName.Text, tbUserName.Text, tbPassword.Text, (Classes.Enumerations.Function.userFunction)cbFunction.SelectedItem);
            MessageBox.Show("Gebruiker aangemaakt.");
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            Users = adminRepo.getUsers();
            cbFunction.Items.Clear();
            cbFunction.Items.Add(Classes.Enumerations.Function.userFunction.Cleaner);
            cbFunction.Items.Add(Classes.Enumerations.Function.userFunction.Driver);
            cbFunction.Items.Add(Classes.Enumerations.Function.userFunction.Engineer);
            cbFunction.Items.Add(Classes.Enumerations.Function.userFunction.Fleetmanager);
            cbFunction.Items.Add(Classes.Enumerations.Function.userFunction.Admin);

            foreach (User user in Users)
            {
                    lbUserList.Items.Add(user.name + ", "+  user.function);
            }
        }

        private void btnVeranderNaam_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text.Length > 3)
            {
                foreach (User user in adminRepo.getUsers())
                {
                    if (user.ID == Convert.ToInt32(tbID.Text))
                    {
                        adminRepo.changeUsername(user, tbUserName.Text);
                        MessageBox.Show("Gebruikersnaam aangepast.");
                    }

                }
            }
            else
            {
                MessageBox.Show("Gebruikersnaam te kort.");
            }

        }

        private void btnVeranderWachtwoord_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length > 4)
            {
                foreach (User user in adminRepo.getUsers())
                {
                    if (user.ID == Convert.ToInt32(tbID.Text))
                    {
                        adminRepo.changePassword(user, tbPassword.Text);
                        MessageBox.Show("Wachtwoord aangepast.");
                    }

                }
            }
            else
            {
                MessageBox.Show("Wachtwoord te kort.");
            }
            tbPassword.Clear();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            foreach (User user in adminRepo.getUsers())
            {
                if (user.ID == Convert.ToInt32(tbID.Text))
                {
                    adminRepo.delete(user);
                    MessageBox.Show("Gebruiker verwijderd.");
                }
                
            }
        }

        private void lbUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Selected = lbUserList.SelectedIndex;
            tbID.Text = Convert.ToString(Users[Selected].ID);
            tbName.Text = Users[Selected].name;
            tbUserName.Text = Users[Selected].username;
            cbFunction.SelectedIndex = Convert.ToInt32(Users[Selected].function) - 1;
        }
    }
}

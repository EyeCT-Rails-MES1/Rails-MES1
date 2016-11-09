﻿using System;
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
            cbFunction.Items.Clear();
            cbFunction.Items.Add(Classes.Enumerations.Function.userFunction.Driver);
            cbFunction.Items.Add(Classes.Enumerations.Function.userFunction.Admin);
            cbFunction.Items.Add(Classes.Enumerations.Function.userFunction.Engineer);
            cbFunction.Items.Add(Classes.Enumerations.Function.userFunction.Cleaner);
            cbFunction.Items.Add(Classes.Enumerations.Function.userFunction.Fleetmanager);

            foreach (User user in adminRepo.getUsers())
            {
                if (user.ID == Convert.ToInt32(tbID.Text))
                {
                    lbUserList.Items.Add(user.username + user.function);
                }
            }
        }

        private void btnVeranderNaam_Click(object sender, EventArgs e)
        {
            foreach (User user in adminRepo.getUsers())
            {
                if (user.ID == Convert.ToInt32(tbID.Text))
                {
                    adminRepo.changeUsername(user, tbUserName.Text);
                }
                MessageBox.Show("Gebruikersnaam aangepast.");
            }
        }

        private void btnVeranderWachtwoord_Click(object sender, EventArgs e)
        {
            foreach (User user in adminRepo.getUsers())
            {
                if (user.ID == Convert.ToInt32(tbID.Text))
                {
                    adminRepo.changePassword(user, tbPassword.Text);
                }
                MessageBox.Show("Wachtwoord aangepast.");
            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            foreach (User user in adminRepo.getUsers())
            {
                if (user.ID == Convert.ToInt32(tbID.Text))
                {
                    adminRepo.delete(user);
                }
                MessageBox.Show("Gebruiker verwijderd.");
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Controller;
using HospitalManagementSystem.Model;
using HospitalManagementSystem.Data;

namespace HospitalManagementSystem.View
{
    public partial class AdminFormLogin : Form
    {
        public AdminFormLogin()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            var db = new Database();
            var authController = new AuthController(db);

            if (authController.Login(email, password, "Admin", out object user))
            {
                Admin admin = user as Admin;
                MessageBox.Show("Welcome, Admin " + admin.FirstName + "!",
                                "Login Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide(); // Hide the login form 
            }
            else
            {
                MessageBox.Show("Invalid email or password!",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

            }
        }

        private void AdminFormLogin_Load(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

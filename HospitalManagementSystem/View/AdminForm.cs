﻿using HospitalManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.View
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //panel1.Controls.Add(label1);
        }

        private void OpenFormInPanel(Form form)//method to open form in panel 
        {
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manageDoctorBtn_Click(object sender, EventArgs e)
        {
            ManageDoctorForm mdf = new ManageDoctorForm();
            OpenFormInPanel(mdf);
            pictureBox1.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void managePatientBtn_Click(object sender, EventArgs e)
        {
            ManagePatientForm mpf = new ManagePatientForm();
            OpenFormInPanel(mpf);
            pictureBox1.Hide();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                var loginForm = new LoginForm();
                loginForm.Show();
                MessageBox.Show("You have successfully logged out.", "Logout Successful");

            }
            else
            {
                //MessageBox.Show("Logout cancelled.", "Action Cancelled");
            }
        }

        private void bookAppointmentBtn_Click(object sender, EventArgs e)
        {
            AdminBooking ab = new AdminBooking();
            OpenFormInPanel(ab);
            pictureBox1.Hide();
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            TransactionHistoryForm tf = new TransactionHistoryForm();
            OpenFormInPanel(tf);
            pictureBox1.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminViewAppointmentscs avA= new AdminViewAppointmentscs();
            OpenFormInPanel(avA);
            pictureBox1.Hide();
        }
    }
}
 
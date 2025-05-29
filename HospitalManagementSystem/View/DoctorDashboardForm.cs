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
    public partial class DoctorDashboardForm : Form
    {
        public DoctorDashboardForm()
        {
            InitializeComponent();


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
        private void guna2Button3_Click(object sender, EventArgs e)
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
                Application.Exit(); // Close the application
            }
            else
            {
                MessageBox.Show("Logout cancelled.", "Action Cancelled");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DoctorDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}

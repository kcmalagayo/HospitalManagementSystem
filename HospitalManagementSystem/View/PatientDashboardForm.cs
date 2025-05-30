using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Model;

namespace HospitalManagementSystem.View
{
    public partial class PatientDashboardForm : Form
    {
        private int _patientId;
        public PatientDashboardForm(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
            this.WindowState = FormWindowState.Maximized;

        }

        private void OpenFormInPanel(Form form)
        {
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
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
                //Application.Exit(); // Close the application
            }
            else
            {
                //MessageBox.Show("Logout cancelled.", "Action Cancelled");
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)//book appointment button    
        {
            PatientForm pf = new PatientForm(_patientId);
            OpenFormInPanel(pf);
            pictureBox1.Hide();
        }
        private void notifBtn_Click(object sender, EventArgs e)
        {
            NotificationForm notifForm = new NotificationForm(_patientId);
            OpenFormInPanel(notifForm);
            pictureBox1.Hide();
        }

        private void PatientDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            PatientViewAppointment va = new PatientViewAppointment(_patientId);
            OpenFormInPanel(va);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            PatientViewRecord vr = new PatientViewRecord(_patientId);
            OpenFormInPanel(vr);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

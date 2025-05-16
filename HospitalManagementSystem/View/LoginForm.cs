using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            selectRoleComboBox.Items.Add("Patient");
            selectRoleComboBox.Items.Add("Doctor");
            selectRoleComboBox.Items.Add("Admin");
            selectRoleComboBox.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            var db = new Database();
            var authController = new AuthController(db);


            if (selectRoleComboBox.SelectedItem.ToString() == "Admin")//condition for admin role
            {

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

            } else if (selectRoleComboBox.SelectedItem.ToString() == "Patient")//condition for patient role
            {
                if (authController.Login(email, password, "Patient", out object user))
                {
                    Patient patient = user as Patient;
                    MessageBox.Show("Welcome, Patient " + patient.FirstName + "!",
                                    "Login Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    PatientDashboardForm patientDashForm = new PatientDashboardForm();
                    patientDashForm.Show();
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
            else
            {
                MessageBox.Show("Doctor role coming soon!. ",
                                   "Please try other role for now",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
            }               
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

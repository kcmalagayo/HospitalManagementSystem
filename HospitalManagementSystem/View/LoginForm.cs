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
using HospitalManagementSystem.View;


namespace HospitalManagementSystem.View
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            //select role to login as patient, doctor or admin  
            InitializeComponent();
            selectRoleComboBox.Items.Add("Patient");
            selectRoleComboBox.Items.Add("Doctor");
            selectRoleComboBox.Items.Add("Admin");
            selectRoleComboBox.SelectedIndex = 0;
            passwordTextBox.PasswordChar = '*';
            this.WindowState = FormWindowState.Maximized;
        }

        private void label4_Click(object sender, EventArgs e)//misclicked this label, so I left it empty
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)//login button 
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
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password!",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else if (selectRoleComboBox.SelectedItem.ToString() == "Patient")//condition for patient role
            {
                if (authController.Login(email, password, "Patient", out object user))
                {
                    Patient patient = user as Patient;
                    int patientId = patient.PatientID;

                    MessageBox.Show("Welcome, Patient " + patient.FirstName + "!",
                                    "Login Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    //  Open the PatientViewAppointments screen with the correct ID
                    PatientDashboardForm viewForm = new PatientDashboardForm(patientId);
                    viewForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password!",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else if (selectRoleComboBox.SelectedItem.ToString() == "Doctor")
            {
                if (authController.Login(email, password, "Doctor", out object user))
                {
                    Doctor doctor = user as Doctor;
                    int doctorId = doctor.DoctorID;

                    MessageBox.Show("Welcome, Doctor " + doctor.FirstName + "!",
                                    "Login Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    DoctorDashboardForm DoctorDashboardForm = new DoctorDashboardForm(doctorId); // pass doctorId
                    DoctorDashboardForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password!",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)//misclicked this method, so I left it empty
        {

        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)//misclicked this picture box, so I left it empty
        {
        }
    

        private void panel2_Paint(object sender, PaintEventArgs e)//misclicked this panel, so I left it empty
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)//misclicked this panel, so I left it empty
        {

        }

        private void label5_Click(object sender, EventArgs e)// misclicked this label, so I left it empty
        {

        }
    }
}

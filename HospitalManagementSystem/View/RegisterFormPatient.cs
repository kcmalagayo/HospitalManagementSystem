using HospitalManagementSystem.Controller;
using HospitalManagementSystem.Model;
using HospitalManagementSystem.Data;
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
    public partial class RegisterFormPatient : Form
    {

        public RegisterFormPatient()
        {
            InitializeComponent();
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
            genderComboBox.SelectedIndex = 0;


        }

        private void LoadFormIntoPanel(Form form)
        {
            // Optional: Dispose previous form if needed
            foreach (Control ctrl in registerPanelPatient.Controls)
            {
                if (ctrl is Form f)
                    f.Close();
            }

            registerPanelPatient.Controls.Clear();        // Clear existing controls
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            registerPanelPatient.Controls.Add(form);
            form.Show();
        }



        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
        private void registerBtn1_Click(object sender, EventArgs e)
        {

            string FirstName, LastName, Gender, ContactNumber, Email, Address, Password;
            DateTime DateOfBirth;

            // 1. Collect input from form controls
            var patient = new Patient
            (
                FirstName = firstNameTxt.Text,
                LastName = lastNameTxt.Text,
                DateOfBirth = dobPicker.Value,
                Gender = genderComboBox.SelectedItem?.ToString() ?? "",
                ContactNumber = contactTxt.Text,
                Email = emailTxt.Text,
                Address = addressTxt.Text,
                Password = lastNameTxt.Text + dobPicker.Value.Year
            );

            // 2. Set up database and controller
            var db = new Database();  // assumes default "hospital_db.sqlite"
            var authController = new AuthController(db);

            if (authController.EmailExistsInAnyRole(patient.Email))
            {
                MessageBox.Show("This email is already registered to an account.");
                db.Close();
                return;
            }

            // 3. Attempt to register
            bool success = authController.Register(patient);

            if (success)
            {
                MessageBox.Show("Registration successful!");
                db.Close();
                this.Close(); // or redirect to login
            }
            else
            {
                MessageBox.Show("Registration failed.");
            }
        }

        private void doctorBtn_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new RegisterFormDoctor());
        }

        private void patientBtn_Click(object sender, EventArgs e)
        {

        }

        private void dobPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

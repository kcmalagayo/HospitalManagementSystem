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
    public partial class RegisterFormDoctor : Form
    {
        public RegisterFormDoctor()
        {
            InitializeComponent();
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
            genderComboBox.SelectedIndex = 0;

            specializaitionDropBox.Items.Add("Dermatologist");
            specializaitionDropBox.Items.Add("Ophthalmologist");
            specializaitionDropBox.Items.Add("Otolaryngologist (ENT)");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string FirstName, LastName, Gender, ContactNumber, Email, Specialization, Password;
            DateTime DateOfBirth;

            // 1. Collect input from form controls
            var doctor = new Doctor
            (
                FirstName = firstNameTxt.Text,
                LastName = lastNameTxt.Text,
                DateOfBirth = dobPicker.Value,
                Gender = genderComboBox.SelectedItem?.ToString() ?? "",
                Specialization = specializaitionDropBox.SelectedItem?.ToString() ?? "",
                ContactNumber = contactTxt.Text,
                Email = emailTxt.Text,
                Password = lastNameTxt.Text + dobPicker.Value.Year

            );

            // 2. Set up database and controller
            var db = new Database();  // assumes default "hospital_db.sqlite"
            var authController = new AuthController(db);

            if (authController.EmailExistsInAnyRole(doctor.Email))
            {
                MessageBox.Show("This email is already registered to an account.");
                db.Close();
                return;
            }
            // 3. Attempt to register
            bool success = authController.RegisterDoctor(doctor);

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

        private void doctorBtn_Click(object sender, EventArgs e)//misclicked this button, so I left it empty
        {

        }

        private void patientBtn_Click(object sender, EventArgs e)// misclicked this button, so I left it empty
        {

        }

        private void firstNameTxt_TextChanged(object sender, EventArgs e)// misclicked this textbox, so I left it empty
    
        {

        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)// misclicked this combobox, so I left it empty
    
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void RegisterFormDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}

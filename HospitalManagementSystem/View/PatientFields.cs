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
    public partial class PatientFields : Form
    {
        private Patient _patient;

        public PatientFields(Patient patient)
        {
            InitializeComponent();

            _patient = patient;

            // Populate gender options
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
            genderComboBox.SelectedIndex = 0;

            // Fill form fields with patient data
            firstNameTxt.Text = _patient.FirstName;
            lastNameTxt.Text = _patient.LastName;
            genderComboBox.SelectedItem = _patient.Gender;
            emailTxt.Text = _patient.Email;
            passwordTxtBox.Text = _patient.password;
            contactTxt.Text = _patient.ContactNumber;
            dobPicker.Value = _patient.DateOfBirth;
            addressTxt.Text = _patient.Address;
        }

        private void PatientFields_Load(object sender, EventArgs e)
        {

        }
    }
}

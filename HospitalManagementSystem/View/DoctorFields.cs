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
using HospitalManagementSystem.Data;
using HospitalManagementSystem.Controller;
using System.Numerics;

namespace HospitalManagementSystem.View
{
    public partial class DoctorFields : Form
    {

        private Doctor _doctor;
        public DoctorFields(Doctor doctor)
        {
            InitializeComponent();

            _doctor = doctor;

            // Fill form fields
            firstNameTxt.Text = _doctor.FirstName;
            lastNameTxt.Text = _doctor.LastName;
            genderComboBox.SelectedItem = _doctor.Gender;
            specializationTxt.Text = _doctor.Specialization;
            emailTxt.Text = _doctor.Email;
            PasswordTxtBox.Text = _doctor.Password;
            contactTxt.Text = _doctor.ContactNumber;
            dobPicker.Value = _doctor.DateOfBirth;
            statusTxtBox.Text = _doctor.Status;
        }

        private void firstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

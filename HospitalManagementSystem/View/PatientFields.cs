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
    public partial class PatientFields : Form
    {
        private Patient _patient;
        private readonly PatientController _patientController;
        private bool _isEditMode = false;

        public PatientFields(Patient patient, Database db)
        {
            InitializeComponent();

            _patient = patient ?? new Patient(); // Null check, initialize if null
            _patientController = new PatientController(db);

            // Populate gender options
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
            genderComboBox.SelectedIndex = 0;

            // Disable fields initially
            ToggleFields(false);

            // Fill form fields
            PopulateFields();
        }

        // Toggle Enable/Disable Fields
        private void ToggleFields(bool isEnabled)
        {
            firstNameTxt.Enabled = isEnabled;
            lastNameTxt.Enabled = isEnabled;
            genderComboBox.Enabled = isEnabled;
            emailTxt.Enabled = isEnabled;
            passwordTxtBox.Enabled = isEnabled;
            contactTxt.Enabled = isEnabled;
            dobPicker.Enabled = isEnabled;
            addressTxt.Enabled = isEnabled;
            saveBtn.Enabled = isEnabled;

            // Added check for Discard button
            if (discardbtn != null)
            {
                discardbtn.Enabled = isEnabled;
            }
        }

        // Populate Fields with Data
        private void PopulateFields()
        {
            // Safely populate fields, even if null
            firstNameTxt.Text = _patient.FirstName ?? string.Empty;
            lastNameTxt.Text = _patient.LastName ?? string.Empty;
            genderComboBox.SelectedItem = string.IsNullOrEmpty(_patient.Gender) ? "Male" : _patient.Gender;
            emailTxt.Text = _patient.Email ?? string.Empty;
            passwordTxtBox.Text = _patient.password ?? string.Empty;
            contactTxt.Text = _patient.ContactNumber ?? string.Empty;
            addressTxt.Text = _patient.Address ?? string.Empty;

            // Safe date assignment
            dobPicker.Value = _patient.DateOfBirth != DateTime.MinValue ? _patient.DateOfBirth : DateTime.Today;
        }

        private void PatientFields_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _patient.FirstName = firstNameTxt.Text ?? string.Empty;
            _patient.LastName = lastNameTxt.Text ?? string.Empty;
            _patient.Gender = genderComboBox.SelectedItem?.ToString() ?? "Male";
            _patient.Email = emailTxt.Text ?? string.Empty;
            _patient.password = passwordTxtBox.Text ?? string.Empty;
            _patient.ContactNumber = contactTxt.Text ?? string.Empty;
            _patient.DateOfBirth = dobPicker.Value;
            _patient.Address = addressTxt.Text ?? string.Empty;

            // Call controller to save to database
            bool isUpdated = _patientController.UpdatePatient(_patient);

            if (isUpdated)
            {
                MessageBox.Show("Patient details have been updated successfully.", "Update Success");
                ToggleFields(false);
                _isEditMode = false;
                btnRegister.Text = "Edit Fields";
            }
            else
            {
                MessageBox.Show("Failed to update patient details. Please try again.", "Update Failed");
            }
        }



        private void discardbtn_Click(object sender, EventArgs e)
        {
            PopulateFields();
            MessageBox.Show("Changes have been discarded.", "Action Undone");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _isEditMode = !_isEditMode;
            if (_isEditMode)
            {
                ToggleFields(true);
                btnRegister.Text = "Cancel Edit";
            }
            else
            {
                ToggleFields(false);
                PopulateFields();
                btnRegister.Text = "Edit Fields";
            }
        }
    }
}

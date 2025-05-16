using System;
using System.Windows.Forms;
using HospitalManagementSystem.Model;
using HospitalManagementSystem.Controller;
using HospitalManagementSystem.Data;

namespace HospitalManagementSystem.View
{
    public partial class DoctorFields : Form
    {
        private Doctor _doctor;
        private readonly DoctorController _doctorController;
        private bool _isEditMode = false;

        public DoctorFields(Doctor doctor, Database db)
        {
            InitializeComponent();

            _doctor = doctor ?? new Doctor(); // ✅ Null check, initialize if null
            _doctorController = new DoctorController(db);

            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
            genderComboBox.SelectedIndex = 0;

            specializaitionDropBox.Items.Add("Dermatologist");
            specializaitionDropBox.Items.Add("Ophthalmologist");
            specializaitionDropBox.Items.Add("Otolaryngologist (ENT)");

            // Disable fields initially
            ToggleFields(false);

            // Fill form fields
            PopulateFields();
        }

        // 🔹 Toggle Enable/Disable Fields
        private void ToggleFields(bool isEnabled)
        {
            firstNameTxt.Enabled = isEnabled;
            lastNameTxt.Enabled = isEnabled;
            genderComboBox.Enabled = isEnabled;
            specializaitionDropBox.Enabled = isEnabled;
            emailTxt.Enabled = isEnabled;
            PasswordTxtBox.Enabled = isEnabled;
            contactTxt.Enabled = isEnabled;
            dobPicker.Enabled = isEnabled;
            statusTxtBox.Enabled = isEnabled;
            saveBtn.Enabled = isEnabled;

            // ✅ Added null check to discard button
            if (discardbtn != null)
            {
                discardbtn.Enabled = isEnabled;
            }
        }

        // 🔹 Fill Fields with Data
        private void PopulateFields()
        {
            // ✅ Safely populate fields, even if null
            firstNameTxt.Text = _doctor.FirstName ?? string.Empty;
            lastNameTxt.Text = _doctor.LastName ?? string.Empty;

            // ✅ Avoid null reference for Gender and Specialization
            genderComboBox.SelectedItem = string.IsNullOrEmpty(_doctor.Gender) ? "Male" : _doctor.Gender;
            specializaitionDropBox.SelectedItem = string.IsNullOrEmpty(_doctor.Specialization) ? "Dermatologist" : _doctor.Specialization;

            emailTxt.Text = _doctor.Email ?? string.Empty;
            PasswordTxtBox.Text = _doctor.Password ?? string.Empty;
            contactTxt.Text = _doctor.ContactNumber ?? string.Empty;
            statusTxtBox.Text = _doctor.Status ?? "Active";

            // ✅ Safe date assignment
            dobPicker.Value = _doctor.DateOfBirth != DateTime.MinValue ? _doctor.DateOfBirth : DateTime.Today;
        }

        // 🔹 Register Button Click
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

        // 🔹 Save Changes Logic
        private void saveBtn_Click(object sender, EventArgs e)
        {
            // ✅ Ensure fields are not null before saving
            _doctor.FirstName = firstNameTxt.Text ?? string.Empty;
            _doctor.LastName = lastNameTxt.Text ?? string.Empty;
            _doctor.Gender = genderComboBox.SelectedItem?.ToString() ?? "Male";
            _doctor.Specialization = specializaitionDropBox.SelectedItem?.ToString() ?? "Dermatologist";
            _doctor.Email = emailTxt.Text ?? string.Empty;
            _doctor.Password = PasswordTxtBox.Text ?? string.Empty;
            _doctor.ContactNumber = contactTxt.Text ?? string.Empty;
            _doctor.DateOfBirth = dobPicker.Value;
            _doctor.Status = statusTxtBox.Text ?? "Active";

            // ✅ Call controller to save to database
            bool isUpdated = _doctorController.UpdateDoctor(_doctor);

            if (isUpdated)
            {
                MessageBox.Show("Doctor details have been updated successfully.", "Update Success");
                ToggleFields(false);
                _isEditMode = false;
                btnRegister.Text = "Edit Fields";
            }
            else
            {
                MessageBox.Show("Failed to update doctor details. Please try again.", "Update Failed");
            }
        }

        // 🔹 Discard Changes Logic
        private void discardbtn_Click(object sender, EventArgs e)
        {
            PopulateFields();
            MessageBox.Show("Changes have been discarded.", "Action Undone");
        }

        private void DoctorFields_Load(object sender, EventArgs e)
        {

        }
    }
}

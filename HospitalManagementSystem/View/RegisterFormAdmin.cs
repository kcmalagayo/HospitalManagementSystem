using System;
using System.Windows.Forms;
using HospitalManagementSystem.Controller;
using HospitalManagementSystem.Model;
using HospitalManagementSystem.Data;

namespace HospitalManagementSystem.View
{
    public partial class RegisterFormAdmin : Form
    {
        public RegisterFormAdmin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // 1. Collect input from form controls
            string firstName = firstNameTxt.Text.Trim();
            string lastName = lastNameTxt.Text.Trim();
            string email = emailTxt.Text.Trim();
            string password = firstName + lastName;

            var admin = new Admin//admin model instance
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };

            // 2. Validate inputs
            if (string.IsNullOrEmpty(admin.FirstName) ||
                string.IsNullOrEmpty(admin.LastName) ||
                string.IsNullOrEmpty(admin.Email) ||
                string.IsNullOrEmpty(admin.Password))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            // 3. Set up database and controller
            var db = new Database();  
            var authController = new AuthController(db);

            if (authController.EmailExistsInAnyRole(email))
            {
                MessageBox.Show("This email is already registered to an account.");
                db.Close();
                return;
            }
            // 4. Attempt to register the admin
            bool success = authController.RegisterAdmin(admin);

            if (success)
            {
                MessageBox.Show("Admin registration successful!");
                db.Close();
                this.Close(); // or redirect to login/dashboard
            }
            else
            {
                MessageBox.Show("Admin registration failed. Try again.");
                db.Close();
            }
        }
    }
}

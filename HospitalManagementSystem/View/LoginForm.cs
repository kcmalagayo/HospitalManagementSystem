using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using HospitalManagementSystem.Model;
using HospitalManagementSystem.Data;
using HospitalManagementSystem.Controller;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.View
{
    public partial class LoginForm : Form
    {
        private readonly AuthController authController;

        public LoginForm(AuthController authController)
        {
            InitializeComponent();
            authController = new AuthController(); // Pass the required 'db' parameter
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string password = passwordTxt.Text;

            bool isValid = authController.ValidateLogin(email, password);
            if (isValid)
            {
                MessageBox.Show("Login successful!");
                // Proceed to main form
                AdminForm main = new AdminForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}

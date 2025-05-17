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
    public partial class PatientDashboardForm : Form
    {
        public PatientDashboardForm()
        {
            InitializeComponent();
        }

        private void OpenFormInPanel(Form form)
        {
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Left;
            panel1.Controls.Add(form);
            form.Show();
        }
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm logout = new LoginForm();
            logout.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)//book appointment button    
        {
            PatientForm pf = new PatientForm();
            OpenFormInPanel(pf);
        }

        private void PatientDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}

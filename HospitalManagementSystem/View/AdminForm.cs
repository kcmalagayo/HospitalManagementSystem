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
    public partial class AdminForm : Form
    {
        public AdminForm()
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manageDoctorBtn_Click(object sender, EventArgs e)
        {
            ManageDoctorForm mdf = new ManageDoctorForm();
            OpenFormInPanel(mdf);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}

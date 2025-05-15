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

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            RoleSelectFormcs logout = new RoleSelectFormcs();
            logout.Show();
            this.Hide();
        }
    }
}

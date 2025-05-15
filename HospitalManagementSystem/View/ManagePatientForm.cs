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

namespace HospitalManagementSystem.View
{
    public partial class ManagePatientForm : Form
    {
        public ManagePatientForm()
        {
            InitializeComponent();
            string keyword = patientSearchTxt.Text.Trim();

            var db = new HospitalManagementSystem.Data.Database();
            var controller = new PatientController(db);

            var results = controller.SearchPatient(keyword);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = results;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ManagePatientForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

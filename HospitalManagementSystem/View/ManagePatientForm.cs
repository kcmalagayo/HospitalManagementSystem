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
            this.WindowState = FormWindowState.Maximized;

            LoadPatientData();
        }

        private void LoadPatientData()
        {
            string keyword = patientSearchTxt.Text.Trim();

            var db = new HospitalManagementSystem.Data.Database();
            var controller = new PatientController(db);

            var results = controller.SearchPatient(keyword);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = results;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Hide sensitive columns
            if (dataGridView1.Columns.Contains("Password"))
                dataGridView1.Columns["Password"].Visible = false;

            if (dataGridView1.Columns.Contains("Appointment"))
                dataGridView1.Columns["Appointment"].Visible = false;
        }

        private void ManagePatientForm_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                try
                {
                    var db = new HospitalManagementSystem.Data.Database();

                    var selectedPatient = new Patient
                    {
                        PatientID = Convert.ToInt32(row.Cells["PatientID"].Value),
                        FirstName = row.Cells["FirstName"].Value.ToString(),
                        LastName = row.Cells["LastName"].Value.ToString(),
                        DateOfBirth = DateTime.Parse(row.Cells["DateOfBirth"].Value.ToString()),
                        Gender = row.Cells["Gender"].Value.ToString(),
                        ContactNumber = row.Cells["ContactNumber"].Value.ToString(),
                        Email = row.Cells["Email"].Value.ToString(),
                        password = row.Cells["Password"].Value.ToString(),
                        Address = row.Cells["Address"].Value.ToString()
                    };

                    var editForm = new PatientFields(selectedPatient, db);
                    editForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading patient: " + ex.Message);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterFormPatient registerFormPatient = new RegisterFormPatient();
            registerFormPatient.Show();
        }
    }
}

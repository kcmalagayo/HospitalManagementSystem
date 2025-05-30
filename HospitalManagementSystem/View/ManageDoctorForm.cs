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
    public partial class ManageDoctorForm : Form
    {
        public ManageDoctorForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;//set the form to maximized state

            LoadDoctorData();
        }

        private void LoadDoctorData()//metod to load doctor data into the DataGridView
        {
            string keyword = doctorSearchTxt.Text.Trim();

            var db = new HospitalManagementSystem.Data.Database();
            var controller = new DoctorController(db);

            var results = controller.SearchDoctors(keyword);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = results;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Hide sensitive columns
            if (dataGridView1.Columns.Contains("Password"))
                dataGridView1.Columns["Password"].Visible = false;

            if (dataGridView1.Columns.Contains("Appointment"))
                dataGridView1.Columns["Appointment"].Visible = false;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            LoadDoctorData();
        }

        private void ManageDoctorForm_Load(object sender, EventArgs e)//misclicked this method, so I left it empty
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//method to handle cell clicks in the DataGridView
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                try
                {
                    var db = new HospitalManagementSystem.Data.Database();

                    var selectedDoctor = new Doctor
                    {
                        DoctorID = Convert.ToInt32(row.Cells["DoctorID"].Value),
                        FirstName = row.Cells["FirstName"].Value.ToString(),
                        LastName = row.Cells["LastName"].Value.ToString(),
                        DateOfBirth = DateTime.Parse(row.Cells["DateOfBirth"].Value.ToString()),
                        Gender = row.Cells["Gender"].Value.ToString(),
                        Specialization = row.Cells["Specialization"].Value.ToString(),
                        ContactNumber = row.Cells["ContactNumber"].Value.ToString(),
                        Email = row.Cells["Email"].Value.ToString(),
                        Password = row.Cells["Password"].Value.ToString(),
                        Status = row.Cells["Status"].Value.ToString()
                    };

                    var editForm = new DoctorFields(selectedDoctor, db);
                    editForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading doctor: " + ex.Message);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterFormDoctor registerFormDoctor = new RegisterFormDoctor();
            registerFormDoctor.Show();
        }
    }
}

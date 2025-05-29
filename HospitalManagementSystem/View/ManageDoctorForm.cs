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
            this.WindowState = FormWindowState.Maximized;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = doctorSearchTxt.Text.Trim();

            var db = new HospitalManagementSystem.Data.Database();
            var controller = new DoctorController(db);

            var results = controller.SearchDoctors(keyword);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = results;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void ManageDoctorForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                try
                {
                    // 1️⃣ Initialize Database Connection
                    var db = new HospitalManagementSystem.Data.Database();

                    // 2️⃣ Create the Doctor Object from the Selected Row
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

                    // 3️⃣ Pass Both Doctor and Database to the Constructor
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
            //open register form 
            RegisterFormDoctor registerFormDoctor = new RegisterFormDoctor();
            registerFormDoctor.Show();
        }
    }
}

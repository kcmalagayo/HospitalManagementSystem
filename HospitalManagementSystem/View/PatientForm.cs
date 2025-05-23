using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Controller;
using HospitalManagementSystem.Data;


namespace HospitalManagementSystem.View
{

    public partial class PatientForm : Form
    {
        private HospitalManagementSystem.Data.Database database;
        private readonly DoctorController doctorController;
        public PatientForm()
        {
            InitializeComponent();
            var database = new Database();
            doctorController = new DoctorController(database);

            LoadSpecializations();
            LoadDoctors();
        }
        private void LoadSpecializations()
        {
            specializaitionDropBox.Items.Clear();
            specializaitionDropBox.Items.Add("All"); // Default option to show all doctors
            specializaitionDropBox.Items.Add("Dermatologist");
            specializaitionDropBox.Items.Add("Ophthalmologist");
            specializaitionDropBox.Items.Add("Otolaryngologist (ENT)");
            specializaitionDropBox.SelectedIndex = 0; // Set default to "All"
        }
        private void LoadDoctors(string specialization = null)
        {
            if (specialization == null || specialization == "All")
            {
                dataGridView2.DataSource = doctorController.GetAllDoctors();
            }
            else
            {
                dataGridView2.DataSource = doctorController.GetDoctorsBySpecialization(specialization);
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PatientForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void doctorSearchTxt_TextChanged(object sender, EventArgs e)
        {
            string searchValue = doctorSearchTxt.Text;
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format("FirstName LIKE '%{0}%' OR LastName LIKE '%{0}%' OR Specialization LIKE '%{0}%'", searchValue);

        }

        private void specializaitionDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSpecialization = specializaitionDropBox.SelectedItem.ToString();
            LoadDoctors(selectedSpecialization == "All" ? null : selectedSpecialization);
        }

    }
}


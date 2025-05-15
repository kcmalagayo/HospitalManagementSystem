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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView2.SelectedRows[0];
                int doctorId = Convert.ToInt32(selectedRow.Cells["DoctorID"].Value);
                string firstName = selectedRow.Cells["FirstName"].Value.ToString();
                string lastName = selectedRow.Cells["LastName"].Value.ToString();
                DateTime selectedDate = monthCalendar1.SelectionStart;

                // Call Controller to Save
                bool isSaved = doctorController.SaveAppointment(doctorId, selectedDate);

                if (isSaved)
                {
                    MessageBox.Show($"You have booked an appointment with Dr. {firstName} {lastName} on {selectedDate}.", "Booking Confirmed");
                }
                else
                {
                    MessageBox.Show("Failed to save the appointment. Please try again.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor to book an appointment.", "Error");
            }
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


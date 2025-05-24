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
        private System.Windows.Forms.ComboBox timeSlotDropDown;

        public PatientForm()
        {
            InitializeComponent();
            var database = new Database();
            doctorController = new DoctorController(database);
            timeSlotDropDown = new ComboBox();
            timeSlotDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            timeSlotDropDown.Font = new Font("Arial", 9F);
            timeSlotDropDown.Location = new Point(12, 185);  // Adjust position if needed
            timeSlotDropDown.Name = "timeSlotDropDown";
            timeSlotDropDown.Size = new Size(301, 25);
            panel1.Controls.Add(timeSlotDropDown);
            LoadSpecializations();
            LoadDoctors();
        }
        private void LoadTimeSlots()
        {
            timeSlotDropDown.Items.Clear();

            for (int hour = 8; hour <= 18; hour++) // 8 AM to 6 PM
            {
                timeSlotDropDown.Items.Add($"{hour:00}:00");
                timeSlotDropDown.Items.Add($"{hour:00}:30");
            }

            timeSlotDropDown.SelectedIndex = 0;
        }
        private bool IsAppointmentSlotTaken(int doctorId, DateTime appointmentDateTime)
        {
            var db = new Database();
            var conn = db.GetConnection();

            string query = @"SELECT COUNT(*) FROM Appointment 
                     WHERE DoctorID = @DoctorID AND AppointmentDateTime = @AppointmentDateTime";

            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                cmd.Parameters.AddWithValue("@AppointmentDateTime", appointmentDateTime.ToString("yyyy-MM-dd HH:mm:ss"));

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
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
            guna2DateTimePicker1.Format = DateTimePickerFormat.Custom;
            guna2DateTimePicker1.CustomFormat = "MM/dd/yyyy";
            guna2DateTimePicker1.ShowUpDown = false;

            LoadTimeSlots();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a doctor before booking.");
                return;
            }

            if (timeSlotDropDown.SelectedItem == null)
            {
                MessageBox.Show("Please select a time slot.");
                return;
            }

            int doctorId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["DoctorID"].Value);
            DateTime selectedDate = guna2DateTimePicker1.Value.Date;
            TimeSpan selectedTime = TimeSpan.Parse(timeSlotDropDown.SelectedItem.ToString());
            DateTime appointmentDateTime = selectedDate + selectedTime;

            // Prevent double booking
            if (IsAppointmentSlotTaken(doctorId, appointmentDateTime))
            {
                MessageBox.Show("This time slot is already booked. Please choose another.");
                return;
            }

            try
            {
                var db = new Database();
                var conn = db.GetConnection();

                string query = @"INSERT INTO Appointment (PatientID, DoctorID, AppointmentDateTime, Status)
                         VALUES (@PatientID, @DoctorID, @AppointmentDateTime, @Status)";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientID", 1); // Replace with actual patient ID
                    cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                    cmd.Parameters.AddWithValue("@AppointmentDateTime", appointmentDateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Status", "Pending");

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Appointment booked successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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


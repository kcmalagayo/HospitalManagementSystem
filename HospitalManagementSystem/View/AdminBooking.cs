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
    public partial class AdminBooking : Form
    {
        private int selectedPatientId;

        private HospitalManagementSystem.Data.Database database;
        private readonly DoctorController doctorController;
        private System.Windows.Forms.ComboBox timeSlotDropDown;

        public AdminBooking()
        {
            InitializeComponent();
            database = new Database();
            doctorController = new DoctorController(database);
            timeSlotDropDown = new ComboBox();

            // Hook up search and grid events
            patientSearchTxt.TextChanged += patientSearchTxt_TextChanged;
            dataGridView1.CellClick += dataGridView1_CellClick;

            // Setup dropdown
            timeSlotDropDown.BringToFront();
            timeSlotDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            timeSlotDropDown.Font = new Font("Arial", 9F);
            timeSlotDropDown.IntegralHeight = true;
            timeSlotDropDown.ItemHeight = 40;
            timeSlotDropDown.Location = new Point(240, 400);
            timeSlotDropDown.Name = "timeSlotDropDown";
            timeSlotDropDown.Size = new Size(197, 33);
            timeSlotDropDown.Visible = true;
            panel2.Controls.Add(timeSlotDropDown);

            panel2.Enabled = false; // Disable doctor panel initially
            LoadSpecializations();
            LoadDoctors();
        }

        private void LoadPatients()
        {
            string keyword = patientSearchTxt.Text.Trim();
            var controller = new PatientController(database);
            var results = controller.SearchPatient(keyword);

            dataGridView1.DataSource = results;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridView1.Columns.Contains("Password"))
                dataGridView1.Columns["Password"].Visible = false;

            if (dataGridView1.Columns.Contains("Appointments"))
                dataGridView1.Columns["Appointments"].Visible = false;
        }

        private void patientSearchTxt_TextChanged(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                selectedPatientId = Convert.ToInt32(row.Cells["PatientID"].Value);

                string patientName = $"{row.Cells["FirstName"].Value} {row.Cells["LastName"].Value}";
                label3.Text = $"Selected Patient: {patientName}";

                panel2.Enabled = true; // Enable doctor panel
            }
        }

        private void LoadTimeSlots()
        {
            for (int hour = 8; hour <= 18; hour++)
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
            specializaitionDropBox.Items.Add("All");
            specializaitionDropBox.Items.Add("Dermatologist");
            specializaitionDropBox.Items.Add("Ophthalmologist");
            specializaitionDropBox.Items.Add("Otolaryngologist (ENT)");
            specializaitionDropBox.SelectedIndex = 0;
        }

        private void LoadDoctors(string specialization = null)
        {
            DataTable dt;

            if (specialization == null || specialization == "All")
            {
                dt = doctorController.GetAllDoctors();
            }
            else
            {
                dt = doctorController.GetDoctorsBySpecialization(specialization);
            }

            dataGridView2.DataSource = dt;
        }

        private void AdminBooking_Load(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Format = DateTimePickerFormat.Custom;
            guna2DateTimePicker1.CustomFormat = "MM/dd/yyyy";
            guna2DateTimePicker1.ShowUpDown = false;
            guna2DateTimePicker1.MinDate = DateTime.Today;
            guna2DateTimePicker1.MaxDate = new DateTime(2050, 12, 31);

            LoadTimeSlots();
            LoadPatients(); // 🔥 Load all patients on form open
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

            DateTime selectedDate = guna2DateTimePicker1.Value.Date;

            if (selectedDate < DateTime.Today || selectedDate > new DateTime(2050, 12, 31))
            {
                MessageBox.Show("Invalid date. Please select today or a future date before 2051.");
                return;
            }

            int doctorId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["DoctorID"].Value);
            TimeSpan selectedTime = TimeSpan.Parse(timeSlotDropDown.SelectedItem.ToString());
            DateTime appointmentDateTime = selectedDate + selectedTime;

            if (IsAppointmentSlotTaken(doctorId, appointmentDateTime))
            {
                MessageBox.Show("This time slot is already booked. Please choose another.");
                return;
            }

            try
            {
                PaymentForm paymentForm = new PaymentForm(doctorId, selectedPatientId, appointmentDateTime, "Admin");
                paymentForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void doctorSearchTxt_TextChanged(object sender, EventArgs e)
        {
            string searchValue = doctorSearchTxt.Text;
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format(
                "FirstName LIKE '%{0}%' OR LastName LIKE '%{0}%' OR Specialization LIKE '%{0}%'", searchValue);
        }

        private void specializaitionDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSpecialization = specializaitionDropBox.SelectedItem.ToString();
            LoadDoctors(selectedSpecialization == "All" ? null : selectedSpecialization);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void patientSearchTxt_TextChanged_2(object sender, EventArgs e) { }
    }
}

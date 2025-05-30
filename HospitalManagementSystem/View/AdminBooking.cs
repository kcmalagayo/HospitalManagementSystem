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
        private HospitalManagementSystem.Data.Database database;
        private readonly DoctorController doctorController;
        private System.Windows.Forms.ComboBox timeSlotDropDown;
        public AdminBooking()
        {
            InitializeComponent();
            database = new Database();
            doctorController = new DoctorController(database);
            timeSlotDropDown = new ComboBox();
            timeSlotDropDown.BringToFront();
            timeSlotDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            timeSlotDropDown.Font = new Font("Arial", 9F);
            timeSlotDropDown.IntegralHeight = true;
            timeSlotDropDown.ItemHeight = 40;
            timeSlotDropDown.Location = new Point(240, 310);  // Adjust position if needed
            timeSlotDropDown.Name = "timeSlotDropDown";
            timeSlotDropDown.Size = new Size(197, 33);
            //timeSlotDropDown.Anchor = AnchorStyles.Right;
            timeSlotDropDown.Visible = true;
            panel2.Controls.Add(timeSlotDropDown);
            LoadSpecializations();
            LoadDoctors();
        }
        private void LoadTimeSlots()
        {
            // timeSlotDropDown.Items.Clear();

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
        private void AdminBooking_Load(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Format = DateTimePickerFormat.Custom;
            guna2DateTimePicker1.CustomFormat = "MM/dd/yyyy";
            guna2DateTimePicker1.ShowUpDown = false;
            guna2DateTimePicker1.MinDate = DateTime.Today;
            guna2DateTimePicker1.MaxDate = new DateTime(2050, 12, 31);
            LoadTimeSlots();
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

            // 🔒 Enforce date logic in case of any UI bypass
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
                PaymentForm paymentForm = new PaymentForm(doctorId, 1, appointmentDateTime);
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
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format("FirstName LIKE '%{0}%' OR LastName LIKE '%{0}%' OR Specialization LIKE '%{0}%'", searchValue);
        }
        private void specializaitionDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSpecialization = specializaitionDropBox.SelectedItem.ToString();
            LoadDoctors(selectedSpecialization == "All" ? null : selectedSpecialization);
        }
    }
}

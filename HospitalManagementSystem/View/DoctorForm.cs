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
using HospitalManagementSystem.Data;

namespace HospitalManagementSystem.View
{
    public partial class DoctorForm : Form
    {
        private Database _db;
        private int _patientId = -1; // Patient ID to filter appointments
        private DoctorForm _doctorForm;

        public DoctorForm()
        {
            InitializeComponent();
            _db = new Database();
            comboBox1.Items.AddRange(new string[] { "Completed", "Cancelled", "No Show" });
            LoadAppointments();

            AppointmentSearchTxt.TextChanged += AppointmentSearchTxt_TextChanged;
            guna2Button2.Click += guna2Button2_Click; // Update button
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        // Overloaded constructor to pass patient ID
        public DoctorForm(int patientId) : this()
        {
            _patientId = patientId;
        }

        public static void RedirectToDoctorFormAfterBooking(Form currentForm, int patientId)
        {
            MessageBox.Show("Appointment booked successfully!", "Success");
            DoctorForm form = new DoctorForm(patientId);
            form.Show();
            currentForm.Hide();
        }

        private void LoadAppointments(string keyword = "")
        {
            string query = @"SELECT a.AppointmentID, a.PatientID,
                                      d.FirstName || ' ' || d.LastName AS DoctorName,
                                      a.AppointmentDateTime, a.Status
                             FROM Appointment a
                             JOIN Doctor d ON a.DoctorID = d.DoctorID
                             WHERE (d.FirstName || ' ' || d.LastName LIKE @keyword)";

            if (_patientId > 0)
            {
                query += " AND a.PatientID = @patientId";
            }

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                if (_patientId > 0)
                {
                    cmd.Parameters.AddWithValue("@patientId", _patientId);
                }
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Tag != null && row.Tag.ToString() == "past")
                {
                    row.Selected = false;
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && comboBox1.SelectedItem != null)
            {
                DateTime appointmentTime = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["AppointmentDateTime"].Value);
                if (appointmentTime < DateTime.Now)
                {
                    MessageBox.Show("Cannot update past appointments.", "Not Allowed");
                    return;
                }

                int appointmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AppointmentID"].Value);
                string newStatus = comboBox1.SelectedItem.ToString();

                using (var cmd = new SQLiteCommand("UPDATE Appointment SET Status = @status WHERE AppointmentID = @id", _db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@id", appointmentId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Appointment status updated.", "Success");
                LoadAppointments(AppointmentSearchTxt.Text.Trim());
            }
            else
            {
                MessageBox.Show("Please select an appointment and a new status.", "Warning");
            }
        }

        private void AppointmentSearchTxt_TextChanged(object sender, EventArgs e)
        {
            LoadAppointments(AppointmentSearchTxt.Text.Trim());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorRecordsForm recordsForm = new DoctorRecordsForm();
            recordsForm.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Are you sure you want to log out?",
               "Logout Confirmation",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                var loginForm = new LoginForm();
                loginForm.Show();
                MessageBox.Show("You have successfully logged out.", "Logout Successful");
            }
            else
            {
                MessageBox.Show("Logout cancelled.", "Action Cancelled");
            }
        }
    }
}

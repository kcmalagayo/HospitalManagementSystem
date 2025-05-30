using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using HospitalManagementSystem.Controller;
using HospitalManagementSystem.Data;

namespace HospitalManagementSystem.View
{
    public partial class DoctorForm : Form
    {
        private Database _db;
        private int _doctorId = -1;

        public DoctorForm(int doctorId)
        {
            InitializeComponent();
            _db = new Database();
            _doctorId = doctorId;

            comboBox1.Items.AddRange(new string[] { "Completed", "Cancelled", "No Show" });

            LoadAppointments();

            AppointmentSearchTxt.TextChanged += AppointmentSearchTxt_TextChanged;
            guna2Button2.Click += guna2Button2_Click;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void LoadAppointments(string keyword = "")
        {
            string query = @"SELECT a.AppointmentID, 
                        a.PatientID,
                        p.FirstName || ' ' || p.LastName AS PatientName,
                        d.FirstName || ' ' || d.LastName AS DoctorName,
                        a.AppointmentDateTime,
                        a.Status
                 FROM Appointment a
                 JOIN Doctor d ON a.DoctorID = d.DoctorID
                 JOIN Patient p ON a.PatientID = p.PatientID
                 WHERE a.DoctorID = @doctorId
                   AND (p.FirstName || ' ' || p.LastName LIKE @keyword 
                        OR d.FirstName || ' ' || d.LastName LIKE @keyword)";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@doctorId", _doctorId);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void AppointmentSearchTxt_TextChanged(object sender, EventArgs e)
        {
            LoadAppointments(AppointmentSearchTxt.Text.Trim());
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
                int patientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PatientID"].Value); // ✅ GET PATIENT ID HERE
                using (var cmd = new SQLiteCommand("UPDATE Appointment SET Status = @status WHERE AppointmentID = @id", _db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@id", appointmentId);
                    cmd.ExecuteNonQuery();
                }
                AuthController controller = new AuthController(_db);

                bool success = controller.InsertNotification(patientId, "Your appointment status has been changed to: " + newStatus + ".", "Online");


                MessageBox.Show("Appointment status updated.", "Success");
                LoadAppointments(AppointmentSearchTxt.Text.Trim());
            }
            else
            {
                MessageBox.Show("Please select an appointment and a new status.", "Warning");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorRecordsForm recordsForm = new DoctorRecordsForm(_doctorId); // Optional: pass _doctorId if filtering needed
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
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Logout cancelled.", "Action Cancelled");
            }
        }
    }
}

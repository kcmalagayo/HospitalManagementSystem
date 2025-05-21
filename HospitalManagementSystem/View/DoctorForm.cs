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
        public DoctorForm()
        {
            InitializeComponent();
            _db = new Database();
            comboBox1.Items.AddRange(new string[] { "Completed", "Cancelled", "No Show" });
            LoadAppointments();

            AppointmentSearchTxt.TextChanged += AppointmentSearchTxt_TextChanged;
            guna2Button2.Click += guna2Button2_Click; // Update button
        }
        private void LoadAppointments(string keyword = "")
        {
            string query = @"SELECT a.AppointmentID, a.PatientID, d.FirstName || ' ' || d.LastName AS DoctorName,
                                      a.AppointmentDateTime, a.Status, a.Notes
                             FROM Appointment a
                             JOIN Doctor d ON a.DoctorID = d.DoctorID
                             WHERE d.FirstName || ' ' || d.LastName LIKE @keyword";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && comboBox1.SelectedItem != null)
            {
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
    }
}

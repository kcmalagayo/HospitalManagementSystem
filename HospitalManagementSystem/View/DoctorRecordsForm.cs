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
    public partial class DoctorRecordsForm : Form
    {
        private Database _db;
        public DoctorRecordsForm()
        {
            InitializeComponent();
            _db = new Database();
            LoadPreviousAppointments();
            AppointmentSearchTxt.TextChanged += AppointmentSearchTxt_TextChanged;
        }
        private void LoadPreviousAppointments(string keyword = "")
        {
            string query = @"SELECT a.AppointmentID, a.PatientID, d.FirstName || ' ' || d.LastName AS DoctorName,
                                      a.AppointmentDateTime, a.Status, a.Notes
                             FROM Appointment a
                             JOIN Doctor d ON a.DoctorID = d.DoctorID
                             WHERE a.Status IN ('Completed', 'Cancelled', 'No Show')
                               AND d.FirstName || ' ' || d.LastName LIKE @keyword";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void DoctorRecordsForm_Load(object sender, EventArgs e)
        {

        }

        private void AppointmentSearchTxt_TextChanged(object sender, EventArgs e)
        {
            LoadPreviousAppointments(AppointmentSearchTxt.Text.Trim());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string message = $"Appointment ID: {row.Cells["AppointmentID"].Value}\n" +
                                 $"Patient ID: {row.Cells["PatientID"].Value}\n" +
                                 $"Doctor Name: {row.Cells["DoctorName"].Value}\n" +
                                 $"Date & Time: {row.Cells["AppointmentDateTime"].Value}\n" +
                                 $"Status: {row.Cells["Status"].Value}\n" +
                                 $"Notes: {row.Cells["Notes"].Value}";

                MessageBox.Show(message, "Appointment Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

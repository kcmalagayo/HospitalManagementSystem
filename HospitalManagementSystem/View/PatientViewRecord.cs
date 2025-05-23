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
using HospitalManagementSystem.Model;
using HospitalManagementSystem.Data;

namespace HospitalManagementSystem.View
{
    public partial class PatientViewRecord : Form
    {
        private int _patientId;
        private Database _db;


        public PatientViewRecord(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
            _db = new Database();

            LoadPastAppointments();
            AppointmentSearchTxt.TextChanged += AppointmentSearchTxt_TextChanged;
        }
        private void LoadPastAppointments(string keyword = "")
        {
            string query = @"SELECT a.AppointmentID, a.PatientID, d.FirstName || ' ' || d.LastName AS DoctorName,
                                      a.AppointmentDateTime, a.Status
                             FROM Appointment a
                             JOIN Doctor d ON a.DoctorID = d.DoctorID
                             WHERE a.Status IN ('Completed', 'Cancelled', 'No Show')
                               AND d.FirstName || ' ' || d.LastName LIKE @keyword";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@patientId", _patientId);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientViewAppointment pa = new PatientViewAppointment(_patientId);
            pa.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AppointmentSearchTxt_TextChanged(object sender, EventArgs e)
        {
            LoadPastAppointments(AppointmentSearchTxt.Text.Trim());
        }
    }
}

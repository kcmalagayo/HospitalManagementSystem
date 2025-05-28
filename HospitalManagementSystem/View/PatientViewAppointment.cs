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
using HospitalManagementSystem.Model;

namespace HospitalManagementSystem.View
{
    public partial class PatientViewAppointment : Form
    {
        private Database _db;
        private int _patientId;
        public PatientViewAppointment(int patientId)
        {
            InitializeComponent();
            _db = new Database();
            _patientId = patientId;

            LoadAppointments();
            AppointmentSearchTxt.TextChanged += AppointmentSearchTxt_TextChanged;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }
        private void LoadAppointments(string keyword = "")
        {
            string query = @"
        SELECT a.AppointmentID,
               d.FirstName || ' ' || d.LastName AS DoctorName,
               a.AppointmentDateTime,
               a.Status
        FROM Appointment a
        JOIN Doctor d ON a.DoctorID = d.DoctorID
        WHERE a.PatientID = @patientId
          AND a.AppointmentDateTime >= CURRENT_TIMESTAMP      
          AND (d.FirstName || ' ' || d.LastName LIKE @keyword)
        ORDER BY a.AppointmentDateTime ASC";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@patientId", _patientId);
                cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientViewRecord vr = new PatientViewRecord(_patientId);
            vr.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var doctorName = dataGridView1.Rows[e.RowIndex].Cells["DoctorName"].Value.ToString();
                var dateTime = dataGridView1.Rows[e.RowIndex].Cells["AppointmentDateTime"].Value.ToString();
                MessageBox.Show($"Appointment with Dr. {doctorName} on {dateTime}.", "Appointment Details");
            }
        }

        private void AppointmentSearchTxt_TextChanged(object sender, EventArgs e)
        {
            LoadAppointments(AppointmentSearchTxt.Text.Trim());
        }

        private void PatientViewAppointment_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

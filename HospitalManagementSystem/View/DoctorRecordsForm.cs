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
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
        }

        private void LoadPreviousAppointments(string keyword = "")
        {
            string query = @"SELECT a.AppointmentID, a.PatientID, d.FirstName || ' ' || d.LastName AS DoctorName,
                                      a.AppointmentDateTime, a.Status
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
        private void AppointmentSearchTxt_TextChanged(object sender, EventArgs e)
        {
            LoadPreviousAppointments(AppointmentSearchTxt.Text.Trim());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
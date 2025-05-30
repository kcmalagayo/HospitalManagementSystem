using HospitalManagementSystem.Model;
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
using HospitalManagementSystem.Controller;
using HospitalManagementSystem.Model;
using HospitalManagementSystem.View;

namespace HospitalManagementSystem.View
{
    
    public partial class AdminViewAppointmentscs : Form

    {

        private Database _db;
        public AdminViewAppointmentscs()
        {
            InitializeComponent();


            InitializeComponent();
            _db = new Database();

            LoadAppointments();

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;


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
                     WHERE (p.FirstName || ' ' || p.LastName LIKE @keyword 
                            OR d.FirstName || ' ' || d.LastName LIKE @keyword)";

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
            LoadAppointments(AppointmentSearchTxt.Text.Trim());
        }



    }
}


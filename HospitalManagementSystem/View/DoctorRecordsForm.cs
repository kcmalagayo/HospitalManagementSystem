﻿using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using HospitalManagementSystem.Data;

namespace HospitalManagementSystem.View
{
    public partial class DoctorRecordsForm : Form
    {
        private Database _db;
        private int _doctorId;

        public DoctorRecordsForm(int doctorId)
        {
            InitializeComponent();
            _db = new Database();
            _doctorId = doctorId;

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
            string query = @"SELECT a.AppointmentID, 
                                    a.PatientID,
                                    p.FirstName || ' ' || p.LastName AS PatientName,
                                    a.AppointmentDateTime,
                                    a.Status
                             FROM Appointment a
                             JOIN Doctor d ON a.DoctorID = d.DoctorID
                             JOIN Patient p ON a.PatientID = p.PatientID
                             WHERE a.DoctorID = @doctorId
                               AND a.Status IN ('Completed', 'Cancelled', 'No Show')
                               AND (p.FirstName || ' ' || p.LastName LIKE @keyword)";

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
            LoadPreviousAppointments(AppointmentSearchTxt.Text.Trim());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorForm doctorForm = new DoctorForm(_doctorId);
            doctorForm.Show();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Reserved for future click actions
        }
    }
}

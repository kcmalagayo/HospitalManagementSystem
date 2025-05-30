using System;
using System.Collections.Generic;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalManagementSystem.Data
{
    public class Database
    {
        private SQLiteConnection connection;

        public Database(string databasePath = "hospital_db.sqlite")
        {
            connection = new SQLiteConnection($"Data Source={databasePath};Version=3;");
            connection.Open();

            CreateTables();
        }

        public SQLiteConnection GetConnection()
        {
            return connection;
        }

        public void Close()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
                connection.Close();
        }

        private void CreateTables()
        {
            string createPatientTable = @"
                CREATE TABLE IF NOT EXISTS Patient (
                    PatientID INTEGER PRIMARY KEY AUTOINCREMENT,
                    FirstName TEXT NOT NULL,
                    LastName TEXT NOT NULL,
                    DateOfBirth TEXT NOT NULL,
                    Gender TEXT NOT NULL,
                    ContactNumber TEXT,
                    Email TEXT,
                    Address TEXT,
                    Password TEXT
                );
            ";

            string createDoctorTable = @"
                CREATE TABLE IF NOT EXISTS Doctor (
                    DoctorID INTEGER PRIMARY KEY AUTOINCREMENT,
                    FirstName TEXT NOT NULL,
                    LastName TEXT NOT NULL,
                    DateOfBirth TEXT NOT NULL,
                    Gender TEXT NOT NULL,
                    Specialization TEXT,
                    ContactNumber TEXT,
                    Email TEXT,
                    Password TEXT,
                    Status TEXT DEFAULT 'Active'
                );
            ";
            string createAdminTable = @"
                CREATE TABLE IF NOT EXISTS Admin (
                    AdminID INTEGER PRIMARY KEY AUTOINCREMENT,
                    FirstName TEXT NOT NULL,
                    LastName TEXT NOT NULL,
                    Email TEXT NOT NULL,
                    Password TEXT NOT NULL
                );
            ";
            string createAppointmentTable = @"
                 CREATE TABLE IF NOT EXISTS Appointment (
                    AppointmentID INTEGER PRIMARY KEY AUTOINCREMENT,
                    PatientID INTEGER,
                    DoctorID INTEGER NOT NULL,
                    AppointmentDateTime TEXT NOT NULL,
                    Status TEXT NOT NULL,
                    Notes TEXT,
                    FOREIGN KEY(DoctorID) REFERENCES Doctor(DoctorID),
                    FOREIGN KEY(PatientID) REFERENCES Patient(PatientID)
                );
            ";
            string createNotificationTable = @"
            CREATE TABLE IF NOT EXISTS Notification (
                NotificationID INTEGER PRIMARY KEY AUTOINCREMENT,
                PatientID INTEGER NOT NULL,
                Message TEXT NOT NULL,
                CreatedAt TEXT NOT NULL DEFAULT (datetime('now')),
                Type TEXT,
                FOREIGN KEY(PatientID) REFERENCES Patient(PatientID)
            );
            ";
            string createTransactionHistoryTable = @"
            CREATE TABLE IF NOT EXISTS TransactionHistory (
                TransactionId INTEGER PRIMARY KEY AUTOINCREMENT,
                PatientID INTEGER NOT NULL,
                DoctorID INTEGER NOT NULL,
                TotalAmount REAL NOT NULL,
                PaymentMethod TEXT NOT NULL,
                AppointmentType TEXT NOT NULL,
                AppointmentDate TEXT NOT NULL DEFAULT (datetime('now')),
                CreatedAt TEXT NOT NULL DEFAULT (datetime('now')),
                FOREIGN KEY(PatientID) REFERENCES Patient(PatientID),
                FOREIGN KEY(DoctorID) REFERENCES Doctor(DoctorID)
            );
            ";




            using (var cmd = new SQLiteCommand(createPatientTable, connection))
            {
                cmd.ExecuteNonQuery();
            }

            using (var cmd = new SQLiteCommand(createDoctorTable, connection))
            {
                cmd.ExecuteNonQuery();
            }
            using (var cmd = new SQLiteCommand(createAdminTable, connection))
            {
                cmd.ExecuteNonQuery();
            }
            using (var cmd = new SQLiteCommand(createAppointmentTable, connection))
            {
                cmd.ExecuteNonQuery();
            }
            using (var cmd = new SQLiteCommand(createNotificationTable, connection))
            {
                cmd.ExecuteNonQuery();
            }
            using (var cmd = new SQLiteCommand(createTransactionHistoryTable, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}



using System;
using System.Data.SQLite;

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
        }
    }
}



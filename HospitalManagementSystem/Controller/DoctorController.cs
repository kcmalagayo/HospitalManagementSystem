using System.Collections.Generic;
using System.Data.SQLite;
using HospitalManagementSystem.Model;
using HospitalManagementSystem.Data;
using System.Data;

namespace HospitalManagementSystem.Controller
{
    public class DoctorController
    {
        private readonly Database _db;

        public DoctorController(Database db)
        {
            _db = db;
        }

        public List<Doctor> SearchDoctors(string keyword)
        {
            List<Doctor> result = new List<Doctor>();
            string query = "SELECT * FROM Doctor WHERE FirstName || ' ' || LastName LIKE @keyword";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {   
                        result.Add(new Doctor
                        {
                            DoctorID = Convert.ToInt32(reader["DoctorID"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString()),
                            Gender = reader["Gender"].ToString(),
                            Specialization = reader["Specialization"].ToString(),
                            ContactNumber = reader["ContactNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            Password = reader["Password"].ToString(),
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }

            return result;
        }
        public DataTable GetAllDoctors()
        {
            DataTable dt = new DataTable();
            using (var cmd = new SQLiteCommand("SELECT DoctorID, FirstName, LastName, Specialization, ContactNumber, Email FROM Doctor", _db.GetConnection()))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
        public DataTable GetDoctorsBySpecialization(string specialization)
        {
            DataTable dt = new DataTable();
            string query = "SELECT DoctorID, FirstName, LastName, Specialization, ContactNumber, Email FROM Doctor WHERE Specialization = @specialization";
            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@specialization", specialization);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
        public bool SaveAppointment(int doctorId, DateTime appointmentDate)
        {
            try
            {
                using (var cmd = new SQLiteCommand("INSERT INTO Appointment (DoctorID, AppointmentDateTime, Status) VALUES (@doctorId, @appointmentDate, @status)", _db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    cmd.Parameters.AddWithValue("@appointmentDate", appointmentDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@status", "Scheduled");

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database Error: {ex.Message}");
                return false;
            }
        }
    }
}

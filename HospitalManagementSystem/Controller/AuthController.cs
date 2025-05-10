using System;
using System.Data.SQLite;
using HospitalManagementSystem.Model;
using HospitalManagementSystem.Data;

namespace HospitalManagementSystem.Controller
{
    public class AuthController
    {
        private readonly Database _db;

        public AuthController(Database db)
        {
            _db = db;
        }

        public bool Login(string email, string password, out Patient patient)
        {
            patient = null;

            string query = "SELECT * FROM Patient WHERE Email = @Email AND Password = @Password";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password); // Plain text — you may want to hash it

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        patient = new Patient
                        {
                            PatientID = Convert.ToInt32(reader["PatientID"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString()),
                            Gender = reader["Gender"].ToString(),
                            ContactNumber = reader["ContactNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            Address = reader["Address"].ToString(),
                            password = reader["Password"].ToString()
                        };

                        return true;
                    }
                }
            }

            return false;
        }

        public bool Register(Patient patient)
        {
            string query = @"
                INSERT INTO Patient (FirstName, LastName, DateOfBirth, Gender, ContactNumber, Email, Address, Password)
                VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @ContactNumber, @Email, @Address, @Password)
            ";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
                cmd.Parameters.AddWithValue("@LastName", patient.LastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@ContactNumber", patient.ContactNumber);
                cmd.Parameters.AddWithValue("@Email", patient.Email);
                cmd.Parameters.AddWithValue("@Address", patient.Address);
                cmd.Parameters.AddWithValue("@Password", patient.password); // Again, hash this in real apps

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool RegisterDoctor(Doctor doctor)
        {
            string query = @"
                INSERT INTO Doctor (FirstName, LastName, DateOfBirth, Gender, Specialization, ContactNumber, Email, Password, Status)
                VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @Specialization, @ContactNumber, @Email, @Password, @Status)
            ";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@FirstName", doctor.FirstName);
                cmd.Parameters.AddWithValue("@LastName", doctor.LastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", doctor.DateOfBirth.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Gender", doctor.Gender);
                cmd.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                cmd.Parameters.AddWithValue("@ContactNumber", doctor.ContactNumber);
                cmd.Parameters.AddWithValue("@Email", doctor.Email);
                cmd.Parameters.AddWithValue("@Password", doctor.Password);
                cmd.Parameters.AddWithValue("@Status", doctor.Status ?? "Active"); // Default to "Active" if null

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}

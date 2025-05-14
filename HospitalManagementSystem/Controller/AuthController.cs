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

        public bool Login(string email, string password, string userType, out object user)
        {
            user = null;
            string query = "";

            if (userType == "Patient")
            {
                query = "SELECT * FROM Patient WHERE Email = @Email AND Password = @Password";
            }
            else if (userType == "Doctor")
            {
                query = "SELECT * FROM Doctor WHERE Email = @Email AND Password = @Password";
            }
            else if (userType == "Admin")
            {
                query = "SELECT * FROM Admin WHERE Email = @Email AND Password = @Password";
            }
            else
            {
                return false; // Invalid user type
            }

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password); // Plain text — you may want to hash it

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new Patient
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
                    }
                    else if (userType == "Doctor")
                    {
                        user = new Doctor
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
                        };
                    }
                    else if (userType == "Admin")
                    {
                        user = new Admin
                        {
                            AdminID = Convert.ToInt32(reader["AdminID"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Password = reader["Password"].ToString()
                        };
                    }
                    return true;
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
        public bool RegisterAdmin(Admin admin)
        {
            string query = @"
                INSERT INTO Admin (FirstName, LastName, Email, Password)
                VALUES (@FirstName, @LastName, @Email, @Password)
            ";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@FirstName", admin.FirstName);
                cmd.Parameters.AddWithValue("@LastName", admin.LastName);
                cmd.Parameters.AddWithValue("@Email", admin.Email);
                cmd.Parameters.AddWithValue("@Password", admin.Password);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
using System;
using System.Data.SQLite;
using HospitalManagementSystem.Model;
using AppDatabase = HospitalManagementSystem.Data.Database;

namespace HospitalManagementSystem.Controller
{
    public class AuthController
    {
        private readonly AppDatabase _db;

        public AuthController(AppDatabase db)
        {
            _db = db;
        }

        public bool Login(string email, string password, string userType, out object user)
        {
            user = null;
            string query = "";
            // Determine the query based on user type
            if (userType == "Patient")
                query = "SELECT * FROM Patient WHERE Email = @Email AND Password = @Password";
            else if (userType == "Doctor")
                query = "SELECT * FROM Doctor WHERE Email = @Email AND Password = @Password";
            else if (userType == "Admin")
                query = "SELECT * FROM Admin WHERE Email = @Email AND Password = @Password";
            else
                return false;

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        switch (userType)
                        {
                            case "Patient":
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
                                break;
                            case "Doctor":
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
                                break;
                            case "Admin":
                                user = new Admin
                                {
                                    AdminID = Convert.ToInt32(reader["AdminID"]),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Password = reader["Password"].ToString()
                                };
                                break;
                        }
                        return true;
                    }
                }
            }

            return false;
        }
        // Register methods for each user type
        public bool Register(Patient patient)
        {
            string query = @"
                INSERT INTO Patient 
                (FirstName, LastName, DateOfBirth, Gender, ContactNumber, Email, Address, Password)
                VALUES 
                (@FirstName, @LastName, @DateOfBirth, @Gender, @ContactNumber, @Email, @Address, @Password)";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
                cmd.Parameters.AddWithValue("@LastName", patient.LastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@ContactNumber", patient.ContactNumber);
                cmd.Parameters.AddWithValue("@Email", patient.Email);
                cmd.Parameters.AddWithValue("@Address", patient.Address);
                cmd.Parameters.AddWithValue("@Password", patient.password);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool RegisterDoctor(Doctor doctor)
        {
            string query = @"
                INSERT INTO Doctor 
                (FirstName, LastName, DateOfBirth, Gender, Specialization, ContactNumber, Email, Password, Status) 
                VALUES 
                (@FirstName, @LastName, @DateOfBirth, @Gender, @Specialization, @ContactNumber, @Email, @Password, @Status)";

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
                cmd.Parameters.AddWithValue("@Status", doctor.Status ?? "Active");

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool RegisterAdmin(Admin admin)
        {
            string query = @"
                INSERT INTO Admin 
                (FirstName, LastName, Email, Password)
                VALUES 
                (@FirstName, @LastName, @Email, @Password)";

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

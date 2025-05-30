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

        // pang insert ng notification
        public bool InsertNotification(int patientId, string message, string type)
        {
            string query = @"
        INSERT INTO Notification (PatientID, Message, CreatedAt, Type)
        VALUES (@PatientID, @Message, datetime('now'), @Type)";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@PatientID", patientId);
                cmd.Parameters.AddWithValue("@Message", message);
                cmd.Parameters.AddWithValue("@Type", type);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        // pang get ng notification by patient id
        public List<Notification> GetNotificationsByPatientId(int patientId)
        {
            var notifications = new List<Notification>();
            string query = "SELECT * FROM Notification WHERE PatientID = @PatientID ORDER BY CreatedAt DESC";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@PatientID", patientId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        notifications.Add(new Notification
                        {
                            PatientID = Convert.ToInt32(reader["PatientID"]),
                            Message = reader.GetString(reader.GetOrdinal("Message")),
                            CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString()),
                            Type = reader.GetString(reader.GetOrdinal("Type"))
                        });
                    }
                }
            }

            return notifications;
        }
        // insert transactions
        public bool InsertTransaction(TransactionHistory transaction)
        {
            string query = @"
        INSERT INTO TransactionHistory (PatientID, DoctorID, TotalAmount, PaymentMethod, AppointmentType, AppointmentDate,CreatedAt)
        VALUES (@PatientId, @DoctorId, @TotalAmount, @PaymentMethod, @AppointmentType, @AppointmentDate, @CreatedAt)";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@PatientId", transaction.PatientID);
                cmd.Parameters.AddWithValue("@DoctorId", transaction.DoctorID);
                cmd.Parameters.AddWithValue("@TotalAmount", transaction.TotalAmount);
                cmd.Parameters.AddWithValue("@PaymentMethod", transaction.PaymentMethod);
                cmd.Parameters.AddWithValue("@AppointmentType", transaction.AppointmentType);
                cmd.Parameters.AddWithValue("@AppointmentDate", transaction.AppointmentDate.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@CreatedAt", transaction.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss"));

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // get all transactions

        public List<TransactionHistory> GetAllTransactions()
        {
            var transactions = new List<TransactionHistory>();
            string query = "SELECT * FROM TransactionHistory ORDER BY CreatedAt DESC";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    transactions.Add(new TransactionHistory
                    {
                        TransactionId = Convert.ToInt32(reader["TransactionId"]),
                        PatientID = Convert.ToInt32(reader["PatientID"]),
                        DoctorID = Convert.ToInt32(reader["DoctorID"]),
                        TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                        PaymentMethod = reader["PaymentMethod"].ToString(),
                        AppointmentType = reader["AppointmentType"].ToString(),
                        AppointmentDate = DateTime.Parse(reader["AppointmentDate"].ToString()),
                        CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString())
                    });
                }
            }

            return transactions;
        }

        // get transactions by patientid
        public List<TransactionHistory> GetTransactionsByPatientId(int patientId)
        {
            var transactions = new List<TransactionHistory>();
            string query = "SELECT * FROM TransactionHistory WHERE PatientID = @PatientID ORDER BY CreatedAt DESC";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@PatientId", patientId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        transactions.Add(new TransactionHistory
                        {
                            TransactionId = Convert.ToInt32(reader["TransactionId"]),
                            PatientID = Convert.ToInt32(reader["PatientID"]),
                            DoctorID = Convert.ToInt32(reader["DoctorID"]),
                            TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                            PaymentMethod = reader["PaymentMethod"].ToString(),
                            AppointmentType = reader["AppointmentType"].ToString(),
                            AppointmentDate = DateTime.Parse(reader["AppointmentDate"].ToString()),
                            CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString())
                        });
                    }
                }
            }

            return transactions;
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

using System.Collections.Generic;
using System.Data.SQLite;
using HospitalManagementSystem.Model;
using HospitalManagementSystem.Data;

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
    }
}

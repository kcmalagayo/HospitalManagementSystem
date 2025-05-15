using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using HospitalManagementSystem.Model;
using HospitalManagementSystem.Data;


namespace HospitalManagementSystem.Controller
{
    public class PatientController
    {
        private readonly Database _db;

        public PatientController(Database db)
        {
            _db = db;
        }

        public List<Patient> SearchPatient(string keyword)
        {
            List<Patient> result = new List<Patient>();
            string query = "SELECT * FROM Patient WHERE FirstName || ' ' || LastName LIKE @keyword";

            using (var cmd = new SQLiteCommand(query, _db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Patient
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
                        });
                    }
                }
            }

            return result;
        }
    }
}

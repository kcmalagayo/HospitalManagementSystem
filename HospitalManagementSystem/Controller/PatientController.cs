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
        public bool UpdatePatient(Patient patient)
        {
            try
            {
                using (var cmd = new SQLiteCommand(@"
            UPDATE Patient 
            SET FirstName = @FirstName, 
                LastName = @LastName, 
                Gender = @Gender, 
                ContactNumber = @ContactNumber, 
                Email = @Email, 
                Address = @Address, 
                Password = @Password, 
                DateOfBirth = @DateOfBirth 
            WHERE PatientID = @PatientID", _db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", patient.LastName);
                    cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                    cmd.Parameters.AddWithValue("@ContactNumber", patient.ContactNumber);
                    cmd.Parameters.AddWithValue("@Email", patient.Email);
                    cmd.Parameters.AddWithValue("@Address", patient.Address);
                    cmd.Parameters.AddWithValue("@Password", patient.password);
                    cmd.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@PatientID", patient.PatientID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error");
                return false;
            }
        }
    }
}

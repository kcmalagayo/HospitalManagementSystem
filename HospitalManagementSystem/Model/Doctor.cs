using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Model
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Specialization { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public string Status { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

        public Doctor(string firstName, string lastName, DateTime dateOfBirth, string gender,
                      string specialization, string contactNumber, string email, string password, string status = "Active")
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Specialization = specialization;
            ContactNumber = contactNumber;
            Email = email;
            Password = password;
            Status = status;
            Appointments = new List<Appointment>();
        }

        public Doctor() // Optional: parameterless constructor for flexibility
        {
            Appointments = new List<Appointment>();
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Model
{
    public class Notification
    {
        public int NotificationId { get; set; }                  
        public int PatientID { get; set; }              
        public string Message { get; set; }          
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Type { get; set; } 

        public Notification(int patientId, string message, DateTime createdAt, string type)
        {
            PatientID = patientId;
            Message = message;
            CreatedAt = createdAt;
            Type = type;
        }
        public Notification() { }

    }
}

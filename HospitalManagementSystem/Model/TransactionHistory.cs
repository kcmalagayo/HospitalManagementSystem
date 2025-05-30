using System;

namespace HospitalManagementSystem.Model
{
    public class TransactionHistory
    {
        public int TransactionId { get; set; }              // Primary key (optional if auto-increment in DB)
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string AppointmentType { get; set; }

        public DateTime AppointmentDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Constructors

        // Default constructor
        public TransactionHistory() { }

        // Full constructor
        public TransactionHistory(int patientId, int doctorId, decimal totalAmount, string paymentMethod, string appointmentType, DateTime appointmentDate, DateTime createdAt)
        {
            PatientID = patientId;
            DoctorID = doctorId;
            TotalAmount = totalAmount;
            PaymentMethod = paymentMethod;
            AppointmentType = appointmentType;
            AppointmentDate = appointmentDate;
            CreatedAt = createdAt;
        }
    }
}

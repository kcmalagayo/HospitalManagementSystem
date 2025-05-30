using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Controller;

namespace HospitalManagementSystem.Model
{
    public partial class TransactionHistoryItem : UserControl
    {
        TransactionHistory transacHistory;
        Patient patient;
        Doctor doctor;
        public TransactionHistoryItem()
        {
            InitializeComponent();
        }
        public void setTransactionData(TransactionHistory transaction)
        {
            transacHistory = transaction;
            AuthController controller = new AuthController(new Data.Database());
            DoctorController doctorController = new DoctorController(new Data.Database());
            patient = controller.GetPatientById(transacHistory.PatientID);
            doctor = doctorController.GetDoctorById(transacHistory.DoctorID);

            string doctorName = doctor.FirstName + " " + doctor.LastName;
            string specialization = doctor.Specialization;
            double price = 500.00;
            string patientName = patient.FirstName + " " + patient.LastName;
            string paymentMethod = transacHistory.PaymentMethod;
            string datetime = transacHistory.AppointmentDate.ToString("yyyy-MM-dd HH:mm:ss");
            string type = transacHistory.AppointmentType;
            doctorNameLb.Text = doctorName;
            specializationLb.Text = specialization;
            feeLb.Text = $"P{price}";
            label7.Text = patientName;
            amountLb.Text = $"P{price}";
            paymentMethodLb.Text = paymentMethod;
            appointmentDateLb.Text = datetime;
            appointmentTypeLb.Text = type;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

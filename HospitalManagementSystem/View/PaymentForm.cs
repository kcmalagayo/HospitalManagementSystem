using System.Data.SQLite;
using HospitalManagementSystem.Controller;
using HospitalManagementSystem.Model;

namespace HospitalManagementSystem
{
    public partial class PaymentForm : Form
    {
        public int doctorId;
        public int patientId;
        public DateTime appointmentDate;
        private Data.Database database;

        public PaymentForm(int doctorId, int patientId, DateTime appointmentDate)
        {
            this.doctorId = doctorId;
            this.patientId = patientId;
            this.appointmentDate = appointmentDate;
            database = new Data.Database();
            InitializeComponent();
            LoadDetails();
           
        }

        private void LoadDetails()
        {
            
            DoctorController doctorController = new DoctorController(database);

            var doctor = doctorController.GetDoctorById(doctorId);

            double price = 500.00; // fixed

            if (doctor != null)
            {
                doctorNameLb.Text = doctor.FirstName + " " + doctor.LastName;
                specializationLb.Text = doctor.Specialization;
                appointmentLb.Text = appointmentDate.ToString();
                priceLb.Text = "P" + price.ToString();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void confirmBtn_Click(object sender, EventArgs e)
        {

            decimal price = 500;

            string paymentMethod = gcashRb.Checked ? gcashRb.Text : creditRb.Text;

        
            var conn = database.GetConnection();

            string query = @"INSERT INTO Appointment (PatientID, DoctorID, AppointmentDateTime, Status)
                         VALUES (@PatientID, @DoctorID, @AppointmentDateTime, @Status)";

            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PatientID", patientId); // Replace with actual patient ID
                cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                cmd.Parameters.AddWithValue("@AppointmentDateTime", appointmentDate.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@Status", "Pending");

                cmd.ExecuteNonQuery();
            }
            AuthController controller = new AuthController(database);

            var transactionHistory = new TransactionHistory(

                patientId,
                doctorId,
                price,
            paymentMethod,
            "Online",
            appointmentDate,
            DateTime.Now
                );
            bool insertTransac = controller.InsertTransaction(transactionHistory);

            bool insertNotif = controller.InsertNotification(patientId, "Appointment has been successfully booked.", "Online");


            MessageBox.Show("Appointment booked successfully!");
        }
    }
}

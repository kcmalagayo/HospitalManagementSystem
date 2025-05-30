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
using HospitalManagementSystem.Model;

namespace HospitalManagementSystem.View
{
    public partial class NotificationForm : Form
    {
        private int patientId;
        public NotificationForm(int id)
        {
            patientId = id;
            InitializeComponent();
            LoadNotifications();
        }
        private void LoadNotifications()
        {

            AuthController controller = new AuthController(new Data.Database());

            List<Notification> notifications = controller.GetNotificationsByPatientId(patientId);

            

            foreach(Notification notifs in notifications)
            {
                NotificationItem item = new NotificationItem();
                item.setNotificationData(notifs);
                NOTIFPANEL.Controls.Add(item);
            }



        }
    }
}

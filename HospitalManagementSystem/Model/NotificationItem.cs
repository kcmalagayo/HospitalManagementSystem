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
    public partial class NotificationItem : UserControl
    {
        private Notification notif;
        public NotificationItem()
        {
            InitializeComponent();
        }
        public void setNotificationData(Notification notification)
        {
            notif = notification;
            string datetime = notification.CreatedAt.ToString("yyyy/mm/dd Hh:mm:ss");

            messageLb.Text = notification.Message;
            dateTimeLb.Text = datetime;

        }

        private void dateTimeLb_Click(object sender, EventArgs e)
        {

        }
    }
}

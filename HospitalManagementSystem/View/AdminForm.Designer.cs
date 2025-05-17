namespace HospitalManagementSystem.View
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            manageDoctorBtn = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            managePatientBtn = new Guna.UI2.WinForms.Guna2Button();
            bookAppointmentBtn = new Guna.UI2.WinForms.Guna2Button();
            logOutBtn = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // manageDoctorBtn
            // 
            manageDoctorBtn.CustomizableEdges = customizableEdges9;
            manageDoctorBtn.DisabledState.BorderColor = Color.DarkGray;
            manageDoctorBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            manageDoctorBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            manageDoctorBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            manageDoctorBtn.FillColor = Color.MediumSeaGreen;
            manageDoctorBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageDoctorBtn.ForeColor = Color.Black;
            manageDoctorBtn.Location = new Point(35, 127);
            manageDoctorBtn.Name = "manageDoctorBtn";
            manageDoctorBtn.ShadowDecoration.CustomizableEdges = customizableEdges10;
            manageDoctorBtn.Size = new Size(180, 45);
            manageDoctorBtn.TabIndex = 0;
            manageDoctorBtn.Text = "Manage Doctor";
            manageDoctorBtn.Click += manageDoctorBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 38);
            label1.Name = "label1";
            label1.Size = new Size(160, 48);
            label1.TabIndex = 1;
            label1.Text = "Hospital Name \r\nand Logo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // managePatientBtn
            // 
            managePatientBtn.CustomizableEdges = customizableEdges11;
            managePatientBtn.DisabledState.BorderColor = Color.DarkGray;
            managePatientBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            managePatientBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            managePatientBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            managePatientBtn.FillColor = Color.MediumSeaGreen;
            managePatientBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            managePatientBtn.ForeColor = Color.Black;
            managePatientBtn.Location = new Point(35, 191);
            managePatientBtn.Name = "managePatientBtn";
            managePatientBtn.ShadowDecoration.CustomizableEdges = customizableEdges12;
            managePatientBtn.Size = new Size(180, 45);
            managePatientBtn.TabIndex = 2;
            managePatientBtn.Text = "Manage Patient";
            managePatientBtn.Click += managePatientBtn_Click;
            // 
            // bookAppointmentBtn
            // 
            bookAppointmentBtn.CustomizableEdges = customizableEdges13;
            bookAppointmentBtn.DisabledState.BorderColor = Color.DarkGray;
            bookAppointmentBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            bookAppointmentBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bookAppointmentBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bookAppointmentBtn.FillColor = Color.MediumSeaGreen;
            bookAppointmentBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookAppointmentBtn.ForeColor = Color.Black;
            bookAppointmentBtn.Location = new Point(35, 252);
            bookAppointmentBtn.Name = "bookAppointmentBtn";
            bookAppointmentBtn.ShadowDecoration.CustomizableEdges = customizableEdges14;
            bookAppointmentBtn.Size = new Size(180, 45);
            bookAppointmentBtn.TabIndex = 3;
            bookAppointmentBtn.Text = "Book Appointment";
            // 
            // logOutBtn
            // 
            logOutBtn.CustomizableEdges = customizableEdges15;
            logOutBtn.DisabledState.BorderColor = Color.DarkGray;
            logOutBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            logOutBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            logOutBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            logOutBtn.FillColor = Color.MediumSeaGreen;
            logOutBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOutBtn.ForeColor = Color.Black;
            logOutBtn.Location = new Point(35, 316);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.ShadowDecoration.CustomizableEdges = customizableEdges16;
            logOutBtn.Size = new Size(180, 45);
            logOutBtn.TabIndex = 4;
            logOutBtn.Text = "Log Out ";
            logOutBtn.Click += logOutBtn_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(254, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 416);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 493);
            Controls.Add(panel1);
            Controls.Add(logOutBtn);
            Controls.Add(bookAppointmentBtn);
            Controls.Add(managePatientBtn);
            Controls.Add(label1);
            Controls.Add(manageDoctorBtn);
            MinimizeBox = false;
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Guna.UI2.WinForms.Guna2Button manageDoctorBtn;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button managePatientBtn;
        private Guna.UI2.WinForms.Guna2Button bookAppointmentBtn;
        private Guna.UI2.WinForms.Guna2Button logOutBtn;
        private Panel panel1;
    }
}
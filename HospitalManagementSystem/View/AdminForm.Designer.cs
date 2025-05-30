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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            manageDoctorBtn = new Guna.UI2.WinForms.Guna2Button();
            managePatientBtn = new Guna.UI2.WinForms.Guna2Button();
            bookAppointmentBtn = new Guna.UI2.WinForms.Guna2Button();
            logOutBtn = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            paymentBtn = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // manageDoctorBtn
            // 
            manageDoctorBtn.AutoRoundedCorners = true;
            manageDoctorBtn.CheckedState.BorderColor = Color.Black;
            manageDoctorBtn.CustomBorderColor = Color.Gray;
            manageDoctorBtn.CustomizableEdges = customizableEdges1;
            manageDoctorBtn.DisabledState.BorderColor = Color.DarkGray;
            manageDoctorBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            manageDoctorBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            manageDoctorBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            manageDoctorBtn.FillColor = Color.MediumSeaGreen;
            manageDoctorBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageDoctorBtn.ForeColor = Color.WhiteSmoke;
            manageDoctorBtn.Image = Properties.Resources.doctor_white;
            manageDoctorBtn.ImageAlign = HorizontalAlignment.Left;
            manageDoctorBtn.ImageSize = new Size(40, 40);
            manageDoctorBtn.Location = new Point(39, 301);
            manageDoctorBtn.Name = "manageDoctorBtn";
            manageDoctorBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            manageDoctorBtn.Size = new Size(204, 57);
            manageDoctorBtn.TabIndex = 0;
            manageDoctorBtn.Text = "Manage Doctor";
            manageDoctorBtn.TextAlign = HorizontalAlignment.Right;
            manageDoctorBtn.TextOffset = new Point(-9, 0);
            manageDoctorBtn.Click += manageDoctorBtn_Click;
            // 
            // managePatientBtn
            // 
            managePatientBtn.AutoRoundedCorners = true;
            managePatientBtn.CustomizableEdges = customizableEdges3;
            managePatientBtn.DisabledState.BorderColor = Color.DarkGray;
            managePatientBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            managePatientBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            managePatientBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            managePatientBtn.FillColor = Color.MediumSeaGreen;
            managePatientBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            managePatientBtn.ForeColor = Color.WhiteSmoke;
            managePatientBtn.Image = Properties.Resources.patient_white_icon;
            managePatientBtn.ImageAlign = HorizontalAlignment.Left;
            managePatientBtn.ImageOffset = new Point(-5, 0);
            managePatientBtn.ImageSize = new Size(45, 45);
            managePatientBtn.Location = new Point(39, 379);
            managePatientBtn.Name = "managePatientBtn";
            managePatientBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            managePatientBtn.Size = new Size(204, 59);
            managePatientBtn.TabIndex = 2;
            managePatientBtn.Text = "Manage Patient";
            managePatientBtn.TextAlign = HorizontalAlignment.Left;
            managePatientBtn.TextOffset = new Point(-5, 0);
            managePatientBtn.Click += managePatientBtn_Click;
            // 
            // bookAppointmentBtn
            // 
            bookAppointmentBtn.AutoRoundedCorners = true;
            bookAppointmentBtn.CustomizableEdges = customizableEdges5;
            bookAppointmentBtn.DisabledState.BorderColor = Color.DarkGray;
            bookAppointmentBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            bookAppointmentBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bookAppointmentBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bookAppointmentBtn.FillColor = Color.MediumSeaGreen;
            bookAppointmentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            bookAppointmentBtn.ForeColor = Color.WhiteSmoke;
            bookAppointmentBtn.Image = Properties.Resources.book_appointment_white;
            bookAppointmentBtn.ImageAlign = HorizontalAlignment.Left;
            bookAppointmentBtn.ImageSize = new Size(30, 30);
            bookAppointmentBtn.Location = new Point(39, 454);
            bookAppointmentBtn.Name = "bookAppointmentBtn";
            bookAppointmentBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            bookAppointmentBtn.Size = new Size(204, 56);
            bookAppointmentBtn.TabIndex = 3;
            bookAppointmentBtn.Text = "Book Appointment";
            bookAppointmentBtn.TextAlign = HorizontalAlignment.Right;
            bookAppointmentBtn.Click += bookAppointmentBtn_Click;
            // 
            // logOutBtn
            // 
            logOutBtn.AutoRoundedCorners = true;
            logOutBtn.CustomizableEdges = customizableEdges7;
            logOutBtn.DisabledState.BorderColor = Color.DarkGray;
            logOutBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            logOutBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            logOutBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            logOutBtn.FillColor = Color.MediumSeaGreen;
            logOutBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            logOutBtn.ForeColor = Color.WhiteSmoke;
            logOutBtn.Image = Properties.Resources.logout_white;
            logOutBtn.ImageAlign = HorizontalAlignment.Left;
            logOutBtn.ImageSize = new Size(40, 40);
            logOutBtn.Location = new Point(39, 670);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            logOutBtn.Size = new Size(204, 54);
            logOutBtn.TabIndex = 4;
            logOutBtn.Text = "Log Out ";
            logOutBtn.TextOffset = new Point(-13, 0);
            logOutBtn.Click += logOutBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(298, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1032, 747);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.Work_time_amico;
            pictureBox1.Location = new Point(52, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(940, 697);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(guna2Button1);
            panel2.Controls.Add(paymentBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(manageDoctorBtn);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(managePatientBtn);
            panel2.Controls.Add(bookAppointmentBtn);
            panel2.Controls.Add(logOutBtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 747);
            panel2.TabIndex = 6;
            // 
            // guna2Button1
            // 
            guna2Button1.AutoRoundedCorners = true;
            guna2Button1.CustomizableEdges = customizableEdges9;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.MediumSeaGreen;
            guna2Button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.WhiteSmoke;
            guna2Button1.Image = Properties.Resources.mage__checklist_note2;
            guna2Button1.ImageAlign = HorizontalAlignment.Left;
            guna2Button1.ImageSize = new Size(30, 30);
            guna2Button1.Location = new Point(39, 526);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button1.Size = new Size(204, 56);
            guna2Button1.TabIndex = 9;
            guna2Button1.Text = "View Appointments";
            guna2Button1.TextAlign = HorizontalAlignment.Right;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // paymentBtn
            // 
            paymentBtn.AutoRoundedCorners = true;
            paymentBtn.CustomizableEdges = customizableEdges11;
            paymentBtn.DisabledState.BorderColor = Color.DarkGray;
            paymentBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            paymentBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            paymentBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            paymentBtn.FillColor = Color.MediumSeaGreen;
            paymentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            paymentBtn.ForeColor = Color.WhiteSmoke;
            paymentBtn.Image = Properties.Resources.uil__transaction;
            paymentBtn.ImageAlign = HorizontalAlignment.Left;
            paymentBtn.ImageSize = new Size(30, 30);
            paymentBtn.Location = new Point(39, 599);
            paymentBtn.Name = "paymentBtn";
            paymentBtn.ShadowDecoration.CustomizableEdges = customizableEdges12;
            paymentBtn.Size = new Size(204, 56);
            paymentBtn.TabIndex = 8;
            paymentBtn.Text = "     Payment History";
            paymentBtn.Click += paymentBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(76, 257);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 7;
            label2.Text = "ADMIN CONTROLS";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Hospital_logo2png;
            pictureBox2.Location = new Point(-64, -69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(435, 407);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 747);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MinimizeBox = false;
            Name = "AdminForm";
            Text = " Admin Page";
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Guna.UI2.WinForms.Guna2Button manageDoctorBtn;
        private Guna.UI2.WinForms.Guna2Button managePatientBtn;
        private Guna.UI2.WinForms.Guna2Button bookAppointmentBtn;
        private Guna.UI2.WinForms.Guna2Button logOutBtn;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button paymentBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
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
            managePatientBtn = new Guna.UI2.WinForms.Guna2Button();
            bookAppointmentBtn = new Guna.UI2.WinForms.Guna2Button();
            logOutBtn = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
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
            manageDoctorBtn.CustomizableEdges = customizableEdges9;
            manageDoctorBtn.DisabledState.BorderColor = Color.DarkGray;
            manageDoctorBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            manageDoctorBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            manageDoctorBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            manageDoctorBtn.FillColor = Color.MediumSeaGreen;
            manageDoctorBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            manageDoctorBtn.ForeColor = Color.WhiteSmoke;
            manageDoctorBtn.Image = Properties.Resources.doctor;
            manageDoctorBtn.ImageAlign = HorizontalAlignment.Left;
            manageDoctorBtn.ImageSize = new Size(30, 30);
            manageDoctorBtn.Location = new Point(55, 252);
            manageDoctorBtn.Name = "manageDoctorBtn";
            manageDoctorBtn.ShadowDecoration.CustomizableEdges = customizableEdges10;
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
            managePatientBtn.CustomizableEdges = customizableEdges11;
            managePatientBtn.DisabledState.BorderColor = Color.DarkGray;
            managePatientBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            managePatientBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            managePatientBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            managePatientBtn.FillColor = Color.MediumSeaGreen;
            managePatientBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            managePatientBtn.ForeColor = Color.WhiteSmoke;
            managePatientBtn.Image = Properties.Resources.patient;
            managePatientBtn.ImageAlign = HorizontalAlignment.Left;
            managePatientBtn.ImageSize = new Size(30, 30);
            managePatientBtn.Location = new Point(55, 323);
            managePatientBtn.Name = "managePatientBtn";
            managePatientBtn.ShadowDecoration.CustomizableEdges = customizableEdges12;
            managePatientBtn.Size = new Size(204, 59);
            managePatientBtn.TabIndex = 2;
            managePatientBtn.Text = "Manage Patient";
            managePatientBtn.TextAlign = HorizontalAlignment.Left;
            managePatientBtn.TextOffset = new Point(8, 0);
            managePatientBtn.Click += managePatientBtn_Click;
            // 
            // bookAppointmentBtn
            // 
            bookAppointmentBtn.AutoRoundedCorners = true;
            bookAppointmentBtn.CustomizableEdges = customizableEdges13;
            bookAppointmentBtn.DisabledState.BorderColor = Color.DarkGray;
            bookAppointmentBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            bookAppointmentBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bookAppointmentBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bookAppointmentBtn.FillColor = Color.MediumSeaGreen;
            bookAppointmentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            bookAppointmentBtn.ForeColor = Color.WhiteSmoke;
            bookAppointmentBtn.Image = Properties.Resources.appointment;
            bookAppointmentBtn.ImageAlign = HorizontalAlignment.Left;
            bookAppointmentBtn.ImageSize = new Size(30, 30);
            bookAppointmentBtn.Location = new Point(55, 397);
            bookAppointmentBtn.Name = "bookAppointmentBtn";
            bookAppointmentBtn.ShadowDecoration.CustomizableEdges = customizableEdges14;
            bookAppointmentBtn.Size = new Size(204, 56);
            bookAppointmentBtn.TabIndex = 3;
            bookAppointmentBtn.Text = "Book Appointment";
            bookAppointmentBtn.TextAlign = HorizontalAlignment.Right;
            bookAppointmentBtn.Click += bookAppointmentBtn_Click;
            // 
            // logOutBtn
            // 
            logOutBtn.AutoRoundedCorners = true;
            logOutBtn.CustomizableEdges = customizableEdges15;
            logOutBtn.DisabledState.BorderColor = Color.DarkGray;
            logOutBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            logOutBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            logOutBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            logOutBtn.FillColor = Color.MediumSeaGreen;
            logOutBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            logOutBtn.ForeColor = Color.WhiteSmoke;
            logOutBtn.Image = Properties.Resources.exit;
            logOutBtn.ImageAlign = HorizontalAlignment.Left;
            logOutBtn.ImageOffset = new Point(4, 0);
            logOutBtn.Location = new Point(55, 467);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.ShadowDecoration.CustomizableEdges = customizableEdges16;
            logOutBtn.Size = new Size(204, 54);
            logOutBtn.TabIndex = 4;
            logOutBtn.Text = "Log Out ";
            logOutBtn.TextOffset = new Point(-13, 0);
            logOutBtn.Click += logOutBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(298, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1032, 677);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(381, 6);
            label1.Name = "label1";
            label1.Size = new Size(319, 53);
            label1.TabIndex = 1;
            label1.Text = "WELCOME ADMIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.Work_time_amico;
            pictureBox1.Location = new Point(-56, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1109, 632);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(manageDoctorBtn);
            panel2.Controls.Add(managePatientBtn);
            panel2.Controls.Add(bookAppointmentBtn);
            panel2.Controls.Add(logOutBtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 677);
            panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(68, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 142);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(84, 223);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 7;
            label2.Text = "ADMIN CONTROLS";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 677);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MinimizeBox = false;
            Name = "AdminForm";
            Text = " Admin Page";
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}
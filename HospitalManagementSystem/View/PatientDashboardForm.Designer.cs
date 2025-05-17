namespace HospitalManagementSystem.View
{
    partial class PatientDashboardForm
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
            logOutBtn = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // logOutBtn
            // 
            logOutBtn.Anchor = AnchorStyles.None;
            logOutBtn.CustomizableEdges = customizableEdges1;
            logOutBtn.DisabledState.BorderColor = Color.DarkGray;
            logOutBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            logOutBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            logOutBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            logOutBtn.FillColor = Color.MediumSeaGreen;
            logOutBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOutBtn.ForeColor = Color.Black;
            logOutBtn.Location = new Point(34, 256);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            logOutBtn.Size = new Size(180, 45);
            logOutBtn.TabIndex = 5;
            logOutBtn.Text = "Log Out ";
            logOutBtn.Click += logOutBtn_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.None;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.MediumSeaGreen;
            guna2Button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(34, 127);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 6;
            guna2Button1.Text = "Book Appointment";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.None;
            guna2Button2.CustomizableEdges = customizableEdges5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.MediumSeaGreen;
            guna2Button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Location = new Point(34, 193);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button2.Size = new Size(180, 45);
            guna2Button2.TabIndex = 7;
            guna2Button2.Text = "View Appointments";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 44);
            label1.Name = "label1";
            label1.Size = new Size(160, 48);
            label1.TabIndex = 8;
            label1.Text = "Hospital Name \r\nand Logo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Location = new Point(255, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 416);
            panel1.TabIndex = 9;
            // 
            // PatientDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 493);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(logOutBtn);
            MaximizeBox = false;
            Name = "PatientDashboardForm";
            Text = "Patient Form";
            Load += PatientDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button logOutBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Label label1;
        private Panel panel1;
    }
}
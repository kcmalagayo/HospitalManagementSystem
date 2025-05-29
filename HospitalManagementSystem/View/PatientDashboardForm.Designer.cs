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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            logOutBtn = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // logOutBtn
            // 
            logOutBtn.CustomizableEdges = customizableEdges1;
            logOutBtn.DisabledState.BorderColor = Color.DarkGray;
            logOutBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            logOutBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            logOutBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            logOutBtn.FillColor = Color.MediumSeaGreen;
            logOutBtn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logOutBtn.ForeColor = Color.Black;
            logOutBtn.Image = Properties.Resources.exit;
            logOutBtn.ImageAlign = HorizontalAlignment.Left;
            logOutBtn.ImageOffset = new Point(5, 0);
            logOutBtn.ImageSize = new Size(25, 25);
            logOutBtn.Location = new Point(46, 260);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            logOutBtn.Size = new Size(199, 45);
            logOutBtn.TabIndex = 5;
            logOutBtn.Text = "Log Out ";
            logOutBtn.TextAlign = HorizontalAlignment.Right;
            logOutBtn.TextOffset = new Point(-35, 0);
            logOutBtn.Click += logOutBtn_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.MediumSeaGreen;
            guna2Button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Image = Properties.Resources.appointment;
            guna2Button1.ImageAlign = HorizontalAlignment.Left;
            guna2Button1.ImageSize = new Size(30, 30);
            guna2Button1.Location = new Point(46, 104);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(199, 49);
            guna2Button1.TabIndex = 6;
            guna2Button1.Text = "Book Appointment";
            guna2Button1.TextAlign = HorizontalAlignment.Right;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.CustomizableEdges = customizableEdges5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.MediumSeaGreen;
            guna2Button2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Image = Properties.Resources.clipboard;
            guna2Button2.ImageAlign = HorizontalAlignment.Left;
            guna2Button2.ImageSize = new Size(30, 30);
            guna2Button2.Location = new Point(46, 158);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button2.Size = new Size(199, 45);
            guna2Button2.TabIndex = 7;
            guna2Button2.Text = "View Appointments";
            guna2Button2.TextAlign = HorizontalAlignment.Right;
            guna2Button2.TextOffset = new Point(3, 0);
            guna2Button2.Click += guna2Button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 18);
            label1.Name = "label1";
            label1.Size = new Size(248, 74);
            label1.TabIndex = 8;
            label1.Text = "Hospital Name \r\nand Logo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(304, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1161, 701);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.Ophthalmologist_bro;
            pictureBox1.Location = new Point(5, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1145, 692);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(guna2Button3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(logOutBtn);
            panel2.Controls.Add(guna2Button2);
            panel2.Controls.Add(guna2Button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 701);
            panel2.TabIndex = 10;
            panel2.Paint += panel2_Paint;
            // 
            // guna2Button3
            // 
            guna2Button3.CustomizableEdges = customizableEdges7;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.MediumSeaGreen;
            guna2Button3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button3.ForeColor = Color.Black;
            guna2Button3.Image = Properties.Resources.folder;
            guna2Button3.ImageAlign = HorizontalAlignment.Left;
            guna2Button3.ImageSize = new Size(30, 30);
            guna2Button3.Location = new Point(46, 209);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button3.Size = new Size(199, 45);
            guna2Button3.TabIndex = 9;
            guna2Button3.Text = "View Records";
            guna2Button3.TextAlign = HorizontalAlignment.Right;
            guna2Button3.TextOffset = new Point(-15, 0);
            guna2Button3.Click += guna2Button3_Click;
            // 
            // PatientDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 701);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "PatientDashboardForm";
            Text = "Patient Page";
            Load += PatientDashboardForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button logOutBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}
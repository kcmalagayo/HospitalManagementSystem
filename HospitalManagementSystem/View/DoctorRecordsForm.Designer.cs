namespace HospitalManagementSystem.View
{
    partial class DoctorRecordsForm
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
            label1 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            logOutBtn = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            AppointmentSearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(248, 74);
            label1.TabIndex = 18;
            label1.Text = "Hospital Name \r\nand Logo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.MediumSeaGreen;
            guna2Button1.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Image = Properties.Resources.appointment;
            guna2Button1.ImageAlign = HorizontalAlignment.Left;
            guna2Button1.ImageSize = new Size(30, 30);
            guna2Button1.Location = new Point(31, 237);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 16;
            guna2Button1.Text = "Appointment";
            guna2Button1.TextAlign = HorizontalAlignment.Right;
            guna2Button1.TextOffset = new Point(-7, 0);
            guna2Button1.Click += guna2Button1_Click;
            // 
            // logOutBtn
            // 
            logOutBtn.CustomizableEdges = customizableEdges3;
            logOutBtn.DisabledState.BorderColor = Color.DarkGray;
            logOutBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            logOutBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            logOutBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            logOutBtn.FillColor = Color.MediumSeaGreen;
            logOutBtn.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logOutBtn.ForeColor = Color.Black;
            logOutBtn.Image = Properties.Resources.exit;
            logOutBtn.ImageAlign = HorizontalAlignment.Left;
            logOutBtn.ImageOffset = new Point(3, 0);
            logOutBtn.ImageSize = new Size(30, 30);
            logOutBtn.Location = new Point(31, 297);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            logOutBtn.Size = new Size(180, 45);
            logOutBtn.TabIndex = 15;
            logOutBtn.Text = "Log Out ";
            logOutBtn.TextAlign = HorizontalAlignment.Right;
            logOutBtn.TextOffset = new Point(-20, 0);
            logOutBtn.Click += logOutBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(273, 31);
            label2.Name = "label2";
            label2.Size = new Size(231, 24);
            label2.TabIndex = 29;
            label2.Text = "Appointment Records";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(273, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(741, 313);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AppointmentSearchTxt
            // 
            AppointmentSearchTxt.Anchor = AnchorStyles.None;
            AppointmentSearchTxt.CustomizableEdges = customizableEdges5;
            AppointmentSearchTxt.DefaultText = "";
            AppointmentSearchTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            AppointmentSearchTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            AppointmentSearchTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            AppointmentSearchTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            AppointmentSearchTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            AppointmentSearchTxt.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppointmentSearchTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            AppointmentSearchTxt.Location = new Point(273, 109);
            AppointmentSearchTxt.Name = "AppointmentSearchTxt";
            AppointmentSearchTxt.PlaceholderText = "Search Appointment";
            AppointmentSearchTxt.SelectedText = "";
            AppointmentSearchTxt.ShadowDecoration.CustomizableEdges = customizableEdges6;
            AppointmentSearchTxt.Size = new Size(741, 36);
            AppointmentSearchTxt.TabIndex = 31;
            AppointmentSearchTxt.TextChanged += AppointmentSearchTxt_TextChanged;
            // 
            // DoctorRecordsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 548);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(AppointmentSearchTxt);
            Controls.Add(label1);
            Controls.Add(guna2Button1);
            Controls.Add(logOutBtn);
            Name = "DoctorRecordsForm";
            Text = "Doctor Page";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button logOutBtn;
        private Label label2;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox AppointmentSearchTxt;
    }
}
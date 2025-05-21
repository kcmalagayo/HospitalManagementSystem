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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            logOutBtn = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            doctorSearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 77);
            label1.Name = "label1";
            label1.Size = new Size(160, 48);
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
            guna2Button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(27, 182);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 16;
            guna2Button1.Text = "Appointment";
            // 
            // logOutBtn
            // 
            logOutBtn.CustomizableEdges = customizableEdges3;
            logOutBtn.DisabledState.BorderColor = Color.DarkGray;
            logOutBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            logOutBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            logOutBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            logOutBtn.FillColor = Color.MediumSeaGreen;
            logOutBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOutBtn.ForeColor = Color.Black;
            logOutBtn.Location = new Point(27, 302);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            logOutBtn.Size = new Size(180, 45);
            logOutBtn.TabIndex = 15;
            logOutBtn.Text = "Log Out ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(267, 55);
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
            dataGridView1.Location = new Point(267, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(741, 313);
            dataGridView1.TabIndex = 32;
            // 
            // doctorSearchTxt
            // 
            doctorSearchTxt.Anchor = AnchorStyles.None;
            doctorSearchTxt.CustomizableEdges = customizableEdges5;
            doctorSearchTxt.DefaultText = "";
            doctorSearchTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            doctorSearchTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            doctorSearchTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            doctorSearchTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            doctorSearchTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            doctorSearchTxt.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorSearchTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            doctorSearchTxt.Location = new Point(295, 97);
            doctorSearchTxt.Name = "doctorSearchTxt";
            doctorSearchTxt.PlaceholderText = "Search doctor fields";
            doctorSearchTxt.SelectedText = "";
            doctorSearchTxt.ShadowDecoration.CustomizableEdges = customizableEdges6;
            doctorSearchTxt.Size = new Size(530, 36);
            doctorSearchTxt.TabIndex = 31;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.None;
            guna2Button2.BackColor = Color.PaleGreen;
            guna2Button2.CustomizableEdges = customizableEdges7;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.MediumSeaGreen;
            guna2Button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Location = new Point(850, 97);
            guna2Button2.Margin = new Padding(3, 2, 3, 2);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button2.Size = new Size(158, 36);
            guna2Button2.TabIndex = 30;
            guna2Button2.Text = "Register Doctor";
            // 
            // DoctorRecordsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 548);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(doctorSearchTxt);
            Controls.Add(guna2Button2);
            Controls.Add(label1);
            Controls.Add(guna2Button1);
            Controls.Add(logOutBtn);
            Name = "DoctorRecordsForm";
            Text = "DoctorRecordsForm";
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
        private Guna.UI2.WinForms.Guna2TextBox doctorSearchTxt;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}
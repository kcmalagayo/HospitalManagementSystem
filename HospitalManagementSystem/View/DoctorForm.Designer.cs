namespace HospitalManagementSystem.View
{
    partial class DoctorForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            AppointmentSearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 21);
            label2.Name = "label2";
            label2.Size = new Size(152, 24);
            label2.TabIndex = 36;
            label2.Text = "Appointments";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(741, 380);
            dataGridView1.TabIndex = 39;
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
            AppointmentSearchTxt.Location = new Point(28, 66);
            AppointmentSearchTxt.Name = "AppointmentSearchTxt";
            AppointmentSearchTxt.PlaceholderText = "Search Appointments";
            AppointmentSearchTxt.SelectedText = "";
            AppointmentSearchTxt.ShadowDecoration.CustomizableEdges = customizableEdges6;
            AppointmentSearchTxt.Size = new Size(741, 36);
            AppointmentSearchTxt.TabIndex = 38;
            AppointmentSearchTxt.TextChanged += AppointmentSearchTxt_TextChanged;
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
            guna2Button2.Location = new Point(155, 108);
            guna2Button2.Margin = new Padding(3, 2, 3, 2);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button2.Size = new Size(135, 23);
            guna2Button2.TabIndex = 37;
            guna2Button2.Text = "Update";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(28, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 40;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(AppointmentSearchTxt);
            Controls.Add(guna2Button2);
            Name = "DoctorForm";
            Text = "DoctorForm";
            Load += DoctorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox AppointmentSearchTxt;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private ComboBox comboBox1;
    }
}
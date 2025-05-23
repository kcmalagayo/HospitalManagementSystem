namespace HospitalManagementSystem.View
{
    partial class PatientViewAppointment
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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            AppointmentSearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 34);
            label2.Name = "label2";
            label2.Size = new Size(214, 35);
            label2.TabIndex = 41;
            label2.Text = "Appointments";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 179);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(847, 417);
            dataGridView1.TabIndex = 44;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AppointmentSearchTxt
            // 
            AppointmentSearchTxt.Anchor = AnchorStyles.None;
            AppointmentSearchTxt.CustomizableEdges = customizableEdges1;
            AppointmentSearchTxt.DefaultText = "";
            AppointmentSearchTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            AppointmentSearchTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            AppointmentSearchTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            AppointmentSearchTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            AppointmentSearchTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            AppointmentSearchTxt.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppointmentSearchTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            AppointmentSearchTxt.Location = new Point(34, 96);
            AppointmentSearchTxt.Margin = new Padding(3, 5, 3, 5);
            AppointmentSearchTxt.Name = "AppointmentSearchTxt";
            AppointmentSearchTxt.PlaceholderText = "Search Appointments";
            AppointmentSearchTxt.SelectedText = "";
            AppointmentSearchTxt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            AppointmentSearchTxt.Size = new Size(606, 48);
            AppointmentSearchTxt.TabIndex = 43;
            AppointmentSearchTxt.TextChanged += AppointmentSearchTxt_TextChanged;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.None;
            guna2Button2.BackColor = Color.PaleGreen;
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.MediumSeaGreen;
            guna2Button2.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Location = new Point(700, 96);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(181, 48);
            guna2Button2.TabIndex = 42;
            guna2Button2.Text = "Record";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // PatientViewAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 607);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(AppointmentSearchTxt);
            Controls.Add(guna2Button2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientViewAppointment";
            Text = "Appointments";
            Load += PatientViewAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox AppointmentSearchTxt;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}
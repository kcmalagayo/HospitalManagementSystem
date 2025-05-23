namespace HospitalManagementSystem.View
{
    partial class ManagePatientForm
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
            dataGridView1 = new DataGridView();
            patientSearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            btnRegister = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(741, 333);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // patientSearchTxt
            // 
            patientSearchTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            patientSearchTxt.CustomizableEdges = customizableEdges5;
            patientSearchTxt.DefaultText = "";
            patientSearchTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            patientSearchTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            patientSearchTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            patientSearchTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            patientSearchTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            patientSearchTxt.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientSearchTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            patientSearchTxt.Location = new Point(32, 12);
            patientSearchTxt.Name = "patientSearchTxt";
            patientSearchTxt.PlaceholderText = "Search patient fields";
            patientSearchTxt.SelectedText = "";
            patientSearchTxt.ShadowDecoration.CustomizableEdges = customizableEdges6;
            patientSearchTxt.Size = new Size(564, 36);
            patientSearchTxt.TabIndex = 23;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegister.BackColor = Color.PaleGreen;
            btnRegister.CustomizableEdges = customizableEdges7;
            btnRegister.DisabledState.BorderColor = Color.DarkGray;
            btnRegister.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRegister.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRegister.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRegister.FillColor = Color.MediumSeaGreen;
            btnRegister.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(615, 12);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnRegister.Size = new Size(158, 36);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "Register Patient";
            btnRegister.Click += btnRegister_Click;
            // 
            // ManagePatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 455);
            Controls.Add(dataGridView1);
            Controls.Add(patientSearchTxt);
            Controls.Add(btnRegister);
            Name = "ManagePatientForm";
            Text = "Manage Patient";
            Load += ManagePatientForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox patientSearchTxt;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
    }
}
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGridView1 = new DataGridView();
            patientSearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            btnRegister = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(741, 396);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // patientSearchTxt
            // 
            patientSearchTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            patientSearchTxt.CustomizableEdges = customizableEdges13;
            patientSearchTxt.DefaultText = "";
            patientSearchTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            patientSearchTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            patientSearchTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            patientSearchTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            patientSearchTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            patientSearchTxt.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientSearchTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            patientSearchTxt.Location = new Point(29, 90);
            patientSearchTxt.Name = "patientSearchTxt";
            patientSearchTxt.PlaceholderText = "Search patient fields";
            patientSearchTxt.SelectedText = "";
            patientSearchTxt.ShadowDecoration.CustomizableEdges = customizableEdges14;
            patientSearchTxt.Size = new Size(564, 36);
            patientSearchTxt.TabIndex = 23;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegister.BackColor = Color.PaleGreen;
            btnRegister.CustomizableEdges = customizableEdges15;
            btnRegister.DisabledState.BorderColor = Color.DarkGray;
            btnRegister.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRegister.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRegister.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRegister.FillColor = Color.MediumSeaGreen;
            btnRegister.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(612, 90);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnRegister.Size = new Size(158, 36);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "Register Patient";
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 9);
            label2.Name = "label2";
            label2.Size = new Size(177, 24);
            label2.TabIndex = 31;
            label2.Text = "Manage Patients";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManagePatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(patientSearchTxt);
            Controls.Add(btnRegister);
            Name = "ManagePatientForm";
            Text = "Manage Patient";
            Load += ManagePatientForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox patientSearchTxt;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private Label label2;
    }
}
﻿namespace HospitalManagementSystem.View
{
    partial class ManageDoctorForm
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
            doctorSearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            dataGridView1 = new DataGridView();
            btnRegister = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // doctorSearchTxt
            // 
            doctorSearchTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            doctorSearchTxt.CustomizableEdges = customizableEdges1;
            doctorSearchTxt.DefaultText = "";
            doctorSearchTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            doctorSearchTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            doctorSearchTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            doctorSearchTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            doctorSearchTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            doctorSearchTxt.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorSearchTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            doctorSearchTxt.Location = new Point(27, 95);
            doctorSearchTxt.Name = "doctorSearchTxt";
            doctorSearchTxt.PlaceholderText = "Search doctor fields";
            doctorSearchTxt.SelectedText = "";
            doctorSearchTxt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            doctorSearchTxt.Size = new Size(576, 36);
            doctorSearchTxt.TabIndex = 20;
            doctorSearchTxt.TextChanged += guna2TextBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(745, 374);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegister.AutoRoundedCorners = true;
            btnRegister.BackColor = Color.Transparent;
            btnRegister.CustomizableEdges = customizableEdges3;
            btnRegister.DisabledState.BorderColor = Color.DarkGray;
            btnRegister.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRegister.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRegister.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRegister.FillColor = Color.MediumSeaGreen;
            btnRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.WhiteSmoke;
            btnRegister.Location = new Point(621, 95);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnRegister.Size = new Size(151, 36);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register Doctor";
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 22);
            label2.Name = "label2";
            label2.Size = new Size(181, 24);
            label2.TabIndex = 30;
            label2.Text = "Manage Doctors ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageDoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 539);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(doctorSearchTxt);
            Controls.Add(btnRegister);
            Name = "ManageDoctorForm";
            Text = "Manage Doctor";
            Load += ManageDoctorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox doctorSearchTxt;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private Label label2;
    }
}
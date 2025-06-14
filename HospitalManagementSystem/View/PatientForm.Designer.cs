﻿namespace HospitalManagementSystem.View
{
    partial class PatientForm
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
            dataGridView2 = new DataGridView();
            specializaitionDropBox = new Guna.UI2.WinForms.Guna2ComboBox();
            doctorSearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            label6 = new Label();
            label1 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(260, 79);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(706, 357);
            dataGridView2.TabIndex = 3;
            // 
            // specializaitionDropBox
            // 
            specializaitionDropBox.BackColor = Color.MediumSeaGreen;
            specializaitionDropBox.CustomizableEdges = customizableEdges1;
            specializaitionDropBox.DrawMode = DrawMode.OwnerDrawFixed;
            specializaitionDropBox.DropDownStyle = ComboBoxStyle.DropDownList;
            specializaitionDropBox.FocusedColor = Color.FromArgb(94, 148, 255);
            specializaitionDropBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            specializaitionDropBox.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specializaitionDropBox.ForeColor = Color.FromArgb(68, 88, 112);
            specializaitionDropBox.ItemHeight = 25;
            specializaitionDropBox.Location = new Point(12, 46);
            specializaitionDropBox.Name = "specializaitionDropBox";
            specializaitionDropBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            specializaitionDropBox.Size = new Size(197, 31);
            specializaitionDropBox.TabIndex = 4;
            specializaitionDropBox.SelectedIndexChanged += specializaitionDropBox_SelectedIndexChanged;
            // 
            // doctorSearchTxt
            // 
            doctorSearchTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            doctorSearchTxt.CustomizableEdges = customizableEdges3;
            doctorSearchTxt.DefaultText = "";
            doctorSearchTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            doctorSearchTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            doctorSearchTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            doctorSearchTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            doctorSearchTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            doctorSearchTxt.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorSearchTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            doctorSearchTxt.Location = new Point(260, 31);
            doctorSearchTxt.Margin = new Padding(3, 4, 3, 4);
            doctorSearchTxt.Name = "doctorSearchTxt";
            doctorSearchTxt.PlaceholderText = "Search for doctor ";
            doctorSearchTxt.SelectedText = "";
            doctorSearchTxt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            doctorSearchTxt.Size = new Size(706, 34);
            doctorSearchTxt.TabIndex = 21;
            doctorSearchTxt.TextChanged += doctorSearchTxt_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 25);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 58;
            label6.Text = "Specialization";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 86);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 60;
            label1.Text = "Appointments";
            label1.Click += label1_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.AutoRoundedCorners = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.MediumSeaGreen;
            guna2Button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.WhiteSmoke;
            guna2Button1.Location = new Point(9, 221);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(197, 32);
            guna2Button1.TabIndex = 61;
            guna2Button1.Text = "Book Appointment";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2DateTimePicker1
            // 
            guna2DateTimePicker1.Checked = true;
            guna2DateTimePicker1.CustomizableEdges = customizableEdges7;
            guna2DateTimePicker1.FillColor = Color.Honeydew;
            guna2DateTimePicker1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DateTimePicker1.Format = DateTimePickerFormat.Long;
            guna2DateTimePicker1.Location = new Point(11, 119);
            guna2DateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            guna2DateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2DateTimePicker1.Size = new Size(197, 33);
            guna2DateTimePicker1.TabIndex = 62;
            guna2DateTimePicker1.Value = new DateTime(2025, 5, 23, 22, 21, 41, 396);
            guna2DateTimePicker1.ValueChanged += guna2DateTimePicker1_ValueChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(guna2DateTimePicker1);
            panel1.Controls.Add(guna2Button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(doctorSearchTxt);
            panel1.Controls.Add(specializaitionDropBox);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 455);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(229, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(750, 455);
            panel2.TabIndex = 63;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 455);
            Controls.Add(panel1);
            Name = "PatientForm";
            Text = "Book Appointment";
            Load += PatientForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView2;
        private Guna.UI2.WinForms.Guna2ComboBox specializaitionDropBox;
        private Guna.UI2.WinForms.Guna2TextBox doctorSearchTxt;
        private Label label6;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Panel panel1;
        private Panel panel2;
    }
}
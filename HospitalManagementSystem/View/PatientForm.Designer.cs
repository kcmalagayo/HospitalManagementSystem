namespace HospitalManagementSystem.View
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
            panel1 = new Panel();
            label1 = new Label();
            monthCalendar1 = new MonthCalendar();
            label6 = new Label();
            doctorSearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            specializaitionDropBox = new Guna.UI2.WinForms.Guna2ComboBox();
            dataGridView2 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(doctorSearchTxt);
            panel1.Controls.Add(specializaitionDropBox);
            panel1.Controls.Add(dataGridView2);
            panel1.Location = new Point(5, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 431);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 60;
            label1.Text = "Appointments";
            label1.Click += label1_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(13, 103);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 24);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 58;
            label6.Text = "Specialization";
            // 
            // doctorSearchTxt
            // 
            doctorSearchTxt.CustomizableEdges = customizableEdges1;
            doctorSearchTxt.DefaultText = "";
            doctorSearchTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            doctorSearchTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            doctorSearchTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            doctorSearchTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            doctorSearchTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            doctorSearchTxt.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorSearchTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            doctorSearchTxt.Location = new Point(325, 25);
            doctorSearchTxt.Name = "doctorSearchTxt";
            doctorSearchTxt.PlaceholderText = "Search doctor fields";
            doctorSearchTxt.SelectedText = "";
            doctorSearchTxt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            doctorSearchTxt.Size = new Size(445, 41);
            doctorSearchTxt.TabIndex = 21;
            // 
            // specializaitionDropBox
            // 
            specializaitionDropBox.BackColor = Color.MediumSeaGreen;
            specializaitionDropBox.CustomizableEdges = customizableEdges3;
            specializaitionDropBox.DrawMode = DrawMode.OwnerDrawFixed;
            specializaitionDropBox.DropDownStyle = ComboBoxStyle.DropDownList;
            specializaitionDropBox.FocusedColor = Color.FromArgb(94, 148, 255);
            specializaitionDropBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            specializaitionDropBox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specializaitionDropBox.ForeColor = Color.FromArgb(68, 88, 112);
            specializaitionDropBox.ItemHeight = 18;
            specializaitionDropBox.Location = new Point(12, 42);
            specializaitionDropBox.Name = "specializaitionDropBox";
            specializaitionDropBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            specializaitionDropBox.Size = new Size(301, 24);
            specializaitionDropBox.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(325, 74);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(445, 333);
            dataGridView2.TabIndex = 3;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 455);
            Controls.Add(panel1);
            Name = "PatientForm";
            Text = "PatientForm";
            Load += PatientForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView2;
        private Guna.UI2.WinForms.Guna2ComboBox specializaitionDropBox;
        private Guna.UI2.WinForms.Guna2TextBox doctorSearchTxt;
        private Label label6;
        private Label label1;
        private MonthCalendar monthCalendar1;
    }
}
namespace HospitalManagementSystem.View
{
    partial class RegisterFormDoctor
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
            patientBtn = new Guna.UI2.WinForms.Guna2Button();
            label9 = new Label();
            doctorBtn = new Guna.UI2.WinForms.Guna2Button();
            dobPicker = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            emailTxt = new TextBox();
            specializationTxt = new TextBox();
            contactTxt = new TextBox();
            genderComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lastNameTxt = new TextBox();
            firstNameTxt = new TextBox();
            registerPanelDoctor = new Panel();
            btnRegister = new Guna.UI2.WinForms.Guna2Button();
            registerPanelDoctor.SuspendLayout();
            SuspendLayout();
            // 
            // patientBtn
            // 
            patientBtn.CustomizableEdges = customizableEdges1;
            patientBtn.DisabledState.BorderColor = Color.DarkGray;
            patientBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            patientBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            patientBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            patientBtn.Font = new Font("Segoe UI", 9F);
            patientBtn.ForeColor = Color.White;
            patientBtn.Location = new Point(547, 277);
            patientBtn.Name = "patientBtn";
            patientBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            patientBtn.Size = new Size(225, 133);
            patientBtn.TabIndex = 43;
            patientBtn.Text = "Patient";
            patientBtn.Click += patientBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(140, 10);
            label9.Name = "label9";
            label9.Size = new Size(123, 20);
            label9.TabIndex = 42;
            label9.Text = "Account Creation";
            // 
            // doctorBtn
            // 
            doctorBtn.CustomizableEdges = customizableEdges3;
            doctorBtn.DisabledState.BorderColor = Color.DarkGray;
            doctorBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            doctorBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            doctorBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            doctorBtn.Font = new Font("Segoe UI", 9F);
            doctorBtn.ForeColor = Color.White;
            doctorBtn.Location = new Point(547, 105);
            doctorBtn.Name = "doctorBtn";
            doctorBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            doctorBtn.Size = new Size(225, 133);
            doctorBtn.TabIndex = 41;
            doctorBtn.Text = "Doctor";
            doctorBtn.Click += doctorBtn_Click;
            // 
            // dobPicker
            // 
            dobPicker.Format = DateTimePickerFormat.Short;
            dobPicker.Location = new Point(42, 188);
            dobPicker.Name = "dobPicker";
            dobPicker.Size = new Size(382, 27);
            dobPicker.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 374);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 37;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 330);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 36;
            label6.Text = "Specialization";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 277);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 35;
            label5.Text = "Contact No.";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(42, 393);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(382, 27);
            emailTxt.TabIndex = 34;
            // 
            // specializationTxt
            // 
            specializationTxt.Location = new Point(42, 344);
            specializationTxt.Name = "specializationTxt";
            specializationTxt.Size = new Size(382, 27);
            specializationTxt.TabIndex = 33;
            // 
            // contactTxt
            // 
            contactTxt.Location = new Point(41, 300);
            contactTxt.Name = "contactTxt";
            contactTxt.Size = new Size(382, 27);
            contactTxt.TabIndex = 32;
            // 
            // genderComboBox
            // 
            genderComboBox.BackColor = Color.Transparent;
            genderComboBox.CustomizableEdges = customizableEdges5;
            genderComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            genderComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            genderComboBox.Font = new Font("Segoe UI", 10F);
            genderComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            genderComboBox.ItemHeight = 30;
            genderComboBox.Location = new Point(42, 241);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            genderComboBox.Size = new Size(382, 36);
            genderComboBox.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 218);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 30;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 164);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 29;
            label3.Text = "Date of Birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 96);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 28;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 40);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 27;
            label1.Text = "First Name";
            // 
            // lastNameTxt
            // 
            lastNameTxt.Location = new Point(42, 126);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(382, 27);
            lastNameTxt.TabIndex = 26;
            // 
            // firstNameTxt
            // 
            firstNameTxt.Location = new Point(42, 66);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(382, 27);
            firstNameTxt.TabIndex = 25;
            // 
            // registerPanelDoctor
            // 
            registerPanelDoctor.Controls.Add(btnRegister);
            registerPanelDoctor.Location = new Point(29, 33);
            registerPanelDoctor.Name = "registerPanelDoctor";
            registerPanelDoctor.Size = new Size(481, 557);
            registerPanelDoctor.TabIndex = 44;
            // 
            // btnRegister
            // 
            btnRegister.CustomizableEdges = customizableEdges7;
            btnRegister.DisabledState.BorderColor = Color.DarkGray;
            btnRegister.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRegister.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRegister.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRegister.Font = new Font("Segoe UI", 9F);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(13, 414);
            btnRegister.Name = "btnRegister";
            btnRegister.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnRegister.Size = new Size(382, 56);
            btnRegister.TabIndex = 45;
            btnRegister.Text = "Register Doctor";
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterFormDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 601);
            Controls.Add(patientBtn);
            Controls.Add(label9);
            Controls.Add(doctorBtn);
            Controls.Add(dobPicker);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(emailTxt);
            Controls.Add(specializationTxt);
            Controls.Add(contactTxt);
            Controls.Add(genderComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lastNameTxt);
            Controls.Add(firstNameTxt);
            Controls.Add(registerPanelDoctor);
            Name = "RegisterFormDoctor";
            Text = "RegisterFormDoctor";
            registerPanelDoctor.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button patientBtn;
        private Label label9;
        private Guna.UI2.WinForms.Guna2Button doctorBtn;
        private DateTimePicker dobPicker;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox emailTxt;
        private TextBox specializationTxt;
        private TextBox contactTxt;
        private Guna.UI2.WinForms.Guna2ComboBox genderComboBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox lastNameTxt;
        private TextBox firstNameTxt;
        private Panel registerPanelDoctor;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
    }
}
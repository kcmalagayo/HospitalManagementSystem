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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnRegister = new Guna.UI2.WinForms.Guna2Button();
            registerPanelDoctor = new Panel();
            firstNameTxt = new TextBox();
            lastNameTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            genderComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            contactTxt = new TextBox();
            emailTxt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dobPicker = new DateTimePicker();
            label9 = new Label();
            specializaitionDropBox = new Guna.UI2.WinForms.Guna2ComboBox();
            registerPanelDoctor.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.CustomizableEdges = customizableEdges1;
            btnRegister.DisabledState.BorderColor = Color.DarkGray;
            btnRegister.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRegister.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRegister.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRegister.FillColor = Color.MediumSeaGreen;
            btnRegister.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(155, 450);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnRegister.Size = new Size(334, 42);
            btnRegister.TabIndex = 45;
            btnRegister.Text = "Register Doctor";
            btnRegister.Click += btnRegister_Click;
            // 
            // registerPanelDoctor
            // 
            registerPanelDoctor.Controls.Add(specializaitionDropBox);
            registerPanelDoctor.Location = new Point(79, 49);
            registerPanelDoctor.Margin = new Padding(3, 2, 3, 2);
            registerPanelDoctor.Name = "registerPanelDoctor";
            registerPanelDoctor.Size = new Size(495, 462);
            registerPanelDoctor.TabIndex = 44;
            // 
            // firstNameTxt
            // 
            firstNameTxt.Location = new Point(153, 87);
            firstNameTxt.Margin = new Padding(3, 2, 3, 2);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(335, 23);
            firstNameTxt.TabIndex = 25;
            // 
            // lastNameTxt
            // 
            lastNameTxt.Location = new Point(154, 141);
            lastNameTxt.Margin = new Padding(3, 2, 3, 2);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(335, 23);
            lastNameTxt.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 66);
            label1.Name = "label1";
            label1.Size = new Size(71, 16);
            label1.TabIndex = 27;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(154, 122);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 28;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 175);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 29;
            label3.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 229);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 30;
            label4.Text = "Gender";
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
            genderComboBox.ItemHeight = 18;
            genderComboBox.Location = new Point(153, 246);
            genderComboBox.Margin = new Padding(3, 2, 3, 2);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            genderComboBox.Size = new Size(335, 24);
            genderComboBox.TabIndex = 31;
            genderComboBox.SelectedIndexChanged += genderComboBox_SelectedIndexChanged;
            // 
            // contactTxt
            // 
            contactTxt.Location = new Point(153, 305);
            contactTxt.Margin = new Padding(3, 2, 3, 2);
            contactTxt.Name = "contactTxt";
            contactTxt.Size = new Size(335, 23);
            contactTxt.TabIndex = 32;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(153, 412);
            emailTxt.Margin = new Padding(3, 2, 3, 2);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(335, 23);
            emailTxt.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 285);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 35;
            label5.Text = "Contact No.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 338);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 36;
            label6.Text = "Specialization";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(154, 393);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 37;
            label7.Text = "Email";
            // 
            // dobPicker
            // 
            dobPicker.Format = DateTimePickerFormat.Short;
            dobPicker.Location = new Point(154, 193);
            dobPicker.Margin = new Padding(3, 2, 3, 2);
            dobPicker.Name = "dobPicker";
            dobPicker.Size = new Size(335, 23);
            dobPicker.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(492, 13);
            label9.Name = "label9";
            label9.Size = new Size(196, 19);
            label9.TabIndex = 42;
            label9.Text = "Register Doctor Account";
            label9.Click += label9_Click;
            // 
            // specializaitionDropBox
            // 
            specializaitionDropBox.BackColor = Color.Transparent;
            specializaitionDropBox.CustomizableEdges = customizableEdges3;
            specializaitionDropBox.DrawMode = DrawMode.OwnerDrawFixed;
            specializaitionDropBox.DropDownStyle = ComboBoxStyle.DropDownList;
            specializaitionDropBox.FocusedColor = Color.FromArgb(94, 148, 255);
            specializaitionDropBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            specializaitionDropBox.Font = new Font("Segoe UI", 10F);
            specializaitionDropBox.ForeColor = Color.FromArgb(68, 88, 112);
            specializaitionDropBox.ItemHeight = 18;
            specializaitionDropBox.Location = new Point(74, 305);
            specializaitionDropBox.Name = "specializaitionDropBox";
            specializaitionDropBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            specializaitionDropBox.Size = new Size(336, 24);
            specializaitionDropBox.TabIndex = 0;
            // 
            // RegisterFormDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 538);
            Controls.Add(btnRegister);
            Controls.Add(label9);
            Controls.Add(dobPicker);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(emailTxt);
            Controls.Add(contactTxt);
            Controls.Add(genderComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lastNameTxt);
            Controls.Add(firstNameTxt);
            Controls.Add(registerPanelDoctor);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "RegisterFormDoctor";
            Text = "RegisterFormDoctor";
            Load += RegisterFormDoctor_Load;
            registerPanelDoctor.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private Panel registerPanelDoctor;
        private TextBox firstNameTxt;
        private TextBox lastNameTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox genderComboBox;
        private TextBox contactTxt;
        private TextBox emailTxt;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dobPicker;
        private Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox specializaitionDropBox;
    }
}
namespace HospitalManagementSystem.View
{
    partial class RegisterFormPatient
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
            firstNameTxt = new TextBox();
            lastNameTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            genderComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            contactTxt = new TextBox();
            emailTxt = new TextBox();
            addressTxt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnRegister = new Guna.UI2.WinForms.Guna2Button();
            dobPicker = new DateTimePicker();
            label9 = new Label();
            registerPanelPatient = new Panel();
            registerPanelPatient.SuspendLayout();
            SuspendLayout();
            // 
            // firstNameTxt
            // 
            firstNameTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            firstNameTxt.Location = new Point(143, 31);
            firstNameTxt.Margin = new Padding(3, 2, 3, 2);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(403, 23);
            firstNameTxt.TabIndex = 0;
            // 
            // lastNameTxt
            // 
            lastNameTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lastNameTxt.Location = new Point(143, 77);
            lastNameTxt.Margin = new Padding(3, 2, 3, 2);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(403, 23);
            lastNameTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 14);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(143, 60);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(143, 102);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 6;
            label3.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(143, 144);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Gender";
            // 
            // genderComboBox
            // 
            genderComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            genderComboBox.BackColor = Color.Transparent;
            genderComboBox.CustomizableEdges = customizableEdges1;
            genderComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            genderComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            genderComboBox.Font = new Font("Segoe UI", 10F);
            genderComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            genderComboBox.ItemHeight = 30;
            genderComboBox.Location = new Point(143, 161);
            genderComboBox.Margin = new Padding(3, 2, 3, 2);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            genderComboBox.Size = new Size(403, 36);
            genderComboBox.TabIndex = 9;
            // 
            // contactTxt
            // 
            contactTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contactTxt.Location = new Point(143, 216);
            contactTxt.Margin = new Padding(3, 2, 3, 2);
            contactTxt.Name = "contactTxt";
            contactTxt.Size = new Size(403, 23);
            contactTxt.TabIndex = 10;
            // 
            // emailTxt
            // 
            emailTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            emailTxt.Location = new Point(143, 258);
            emailTxt.Margin = new Padding(3, 2, 3, 2);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(403, 23);
            emailTxt.TabIndex = 11;
            // 
            // addressTxt
            // 
            addressTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addressTxt.Location = new Point(143, 300);
            addressTxt.Margin = new Padding(3, 2, 3, 2);
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(403, 23);
            addressTxt.TabIndex = 12;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(143, 199);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 13;
            label5.Text = "Contact No.";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(143, 241);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 14;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(143, 283);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 15;
            label7.Text = "Address";
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegister.BackColor = Color.PaleGreen;
            btnRegister.CustomizableEdges = customizableEdges3;
            btnRegister.DisabledState.BorderColor = Color.DarkGray;
            btnRegister.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRegister.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRegister.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRegister.FillColor = Color.MediumSeaGreen;
            btnRegister.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(170, 355);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnRegister.Size = new Size(334, 42);
            btnRegister.TabIndex = 18;
            btnRegister.Text = "Register";
            btnRegister.Click += registerBtn1_Click;
            // 
            // dobPicker
            // 
            dobPicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dobPicker.Format = DateTimePickerFormat.Short;
            dobPicker.Location = new Point(143, 119);
            dobPicker.Margin = new Padding(3, 2, 3, 2);
            dobPicker.Name = "dobPicker";
            dobPicker.Size = new Size(403, 23);
            dobPicker.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(561, 5);
            label9.Name = "label9";
            label9.Size = new Size(126, 16);
            label9.TabIndex = 22;
            label9.Text = "Register a Account";
            // 
            // registerPanelPatient
            // 
            registerPanelPatient.Controls.Add(btnRegister);
            registerPanelPatient.Controls.Add(label1);
            registerPanelPatient.Controls.Add(label2);
            registerPanelPatient.Controls.Add(label3);
            registerPanelPatient.Controls.Add(dobPicker);
            registerPanelPatient.Controls.Add(firstNameTxt);
            registerPanelPatient.Controls.Add(lastNameTxt);
            registerPanelPatient.Controls.Add(addressTxt);
            registerPanelPatient.Controls.Add(label4);
            registerPanelPatient.Controls.Add(genderComboBox);
            registerPanelPatient.Controls.Add(label5);
            registerPanelPatient.Controls.Add(label6);
            registerPanelPatient.Controls.Add(contactTxt);
            registerPanelPatient.Controls.Add(label7);
            registerPanelPatient.Controls.Add(emailTxt);
            registerPanelPatient.Location = new Point(12, 22);
            registerPanelPatient.Margin = new Padding(3, 2, 3, 2);
            registerPanelPatient.Name = "registerPanelPatient";
            registerPanelPatient.Size = new Size(676, 418);
            registerPanelPatient.TabIndex = 24;
            // 
            // RegisterFormPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(700, 451);
            Controls.Add(label9);
            Controls.Add(registerPanelPatient);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegisterFormPatient";
            Text = "RegisterFormPatient";
            Load += RegisterForm_Load;
            registerPanelPatient.ResumeLayout(false);
            registerPanelPatient.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTxt;
        private TextBox lastNameTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox genderComboBox;
        private TextBox contactTxt;
        private TextBox emailTxt;
        private TextBox addressTxt;
        private Label label5;
        private Label label6;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private DateTimePicker dobPicker;
        private Label label9;
        private Panel registerPanelPatient;
    }
}
namespace HospitalManagementSystem.View
{
    partial class RegisterFormAdmin
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
            btnRegister = new Guna.UI2.WinForms.Guna2Button();
            label9 = new Label();
            label7 = new Label();
            emailTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lastNameTxt = new TextBox();
            firstNameTxt = new TextBox();
            registerPanelDoctor = new Panel();
            registerPanelDoctor.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.AutoRoundedCorners = true;
            btnRegister.BackColor = Color.Transparent;
            btnRegister.CustomizableEdges = customizableEdges1;
            btnRegister.DisabledState.BorderColor = Color.DarkGray;
            btnRegister.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRegister.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRegister.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRegister.FillColor = Color.MediumSeaGreen;
            btnRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnRegister.ForeColor = Color.WhiteSmoke;
            btnRegister.Location = new Point(73, 268);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnRegister.Size = new Size(334, 42);
            btnRegister.TabIndex = 63;
            btnRegister.Text = "Register Admin";
            btnRegister.Click += btnRegister_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 23);
            label9.Name = "label9";
            label9.Size = new Size(192, 19);
            label9.TabIndex = 61;
            label9.Text = "Register Admin Account";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(73, 182);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 59;
            label7.Text = "Email";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(75, 210);
            emailTxt.Margin = new Padding(3, 2, 3, 2);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(335, 23);
            emailTxt.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 105);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 50;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 36);
            label1.Name = "label1";
            label1.Size = new Size(71, 16);
            label1.TabIndex = 49;
            label1.Text = "First Name";
            // 
            // lastNameTxt
            // 
            lastNameTxt.Location = new Point(73, 135);
            lastNameTxt.Margin = new Padding(3, 2, 3, 2);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(335, 23);
            lastNameTxt.TabIndex = 48;
            // 
            // firstNameTxt
            // 
            firstNameTxt.Location = new Point(73, 66);
            firstNameTxt.Margin = new Padding(3, 2, 3, 2);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(335, 23);
            firstNameTxt.TabIndex = 47;
            // 
            // registerPanelDoctor
            // 
            registerPanelDoctor.Anchor = AnchorStyles.None;
            registerPanelDoctor.Controls.Add(label7);
            registerPanelDoctor.Controls.Add(btnRegister);
            registerPanelDoctor.Controls.Add(label1);
            registerPanelDoctor.Controls.Add(label2);
            registerPanelDoctor.Controls.Add(firstNameTxt);
            registerPanelDoctor.Controls.Add(emailTxt);
            registerPanelDoctor.Controls.Add(lastNameTxt);
            registerPanelDoctor.Location = new Point(15, 65);
            registerPanelDoctor.Margin = new Padding(3, 2, 3, 2);
            registerPanelDoctor.Name = "registerPanelDoctor";
            registerPanelDoctor.Size = new Size(495, 348);
            registerPanelDoctor.TabIndex = 62;
            // 
            // RegisterFormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 454);
            Controls.Add(label9);
            Controls.Add(registerPanelDoctor);
            MaximizeBox = false;
            Name = "RegisterFormAdmin";
            Text = "RegisterFormAdmin";
            registerPanelDoctor.ResumeLayout(false);
            registerPanelDoctor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private Label label9;
        private Label label7;
        private TextBox emailTxt;
        private Label label2;
        private Label label1;
        private TextBox lastNameTxt;
        private TextBox firstNameTxt;
        private Panel registerPanelDoctor;
    }
}
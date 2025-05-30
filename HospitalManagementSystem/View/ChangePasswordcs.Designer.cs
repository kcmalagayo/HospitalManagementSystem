namespace HospitalManagementSystem.View
{
    partial class ChangePasswordcs
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
            label2 = new Label();
            showPasswordCheckBox = new CheckBox();
            newPasswordTextBox = new TextBox();
            label3 = new Label();
            confirmNewPasswordTextBox = new TextBox();
            label1 = new Label();
            loginBtn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(14, 33);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 8;
            label2.Text = "CHANGE PASSWORD";
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.Anchor = AnchorStyles.None;
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPasswordCheckBox.Location = new Point(279, 228);
            showPasswordCheckBox.Margin = new Padding(4, 3, 4, 3);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(142, 23);
            showPasswordCheckBox.TabIndex = 28;
            showPasswordCheckBox.Text = "Show password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Anchor = AnchorStyles.None;
            newPasswordTextBox.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPasswordTextBox.Location = new Point(88, 120);
            newPasswordTextBox.Margin = new Padding(4, 3, 4, 3);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PlaceholderText = "new password";
            newPasswordTextBox.Size = new Size(333, 27);
            newPasswordTextBox.TabIndex = 21;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 167);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 19);
            label3.TabIndex = 24;
            label3.Text = "Confirm Password";
            // 
            // confirmNewPasswordTextBox
            // 
            confirmNewPasswordTextBox.Anchor = AnchorStyles.None;
            confirmNewPasswordTextBox.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmNewPasswordTextBox.Location = new Point(88, 189);
            confirmNewPasswordTextBox.Margin = new Padding(4, 3, 4, 3);
            confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            confirmNewPasswordTextBox.PlaceholderText = "*********";
            confirmNewPasswordTextBox.Size = new Size(333, 32);
            confirmNewPasswordTextBox.TabIndex = 23;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 98);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 19);
            label1.TabIndex = 22;
            label1.Text = "Change Password";
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.None;
            loginBtn.AutoRoundedCorners = true;
            loginBtn.BackColor = Color.Transparent;
            loginBtn.CheckedState.CustomBorderColor = Color.Gray;
            loginBtn.CustomizableEdges = customizableEdges1;
            loginBtn.DisabledState.BorderColor = Color.DarkGray;
            loginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            loginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            loginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            loginBtn.FillColor = Color.MediumSeaGreen;
            loginBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.WhiteSmoke;
            loginBtn.Location = new Point(151, 287);
            loginBtn.Margin = new Padding(4, 3, 4, 3);
            loginBtn.Name = "loginBtn";
            loginBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            loginBtn.Size = new Size(178, 36);
            loginBtn.TabIndex = 25;
            loginBtn.Text = "Change Password ";
            // 
            // ChangePasswordcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 387);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(newPasswordTextBox);
            Controls.Add(label3);
            Controls.Add(confirmNewPasswordTextBox);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            MaximizeBox = false;
            Name = "ChangePasswordcs";
            Text = "ChangePasswordcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private CheckBox showPasswordCheckBox;
        private TextBox newPasswordTextBox;
        private Label label3;
        private TextBox confirmNewPasswordTextBox;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
    }
}
namespace HospitalManagementSystem.View
{
    partial class LoginForm
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
            label4 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            loginBtn = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            passwordTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            emailTextBox = new TextBox();
            selectRoleComboBox = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 245);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 17;
            label4.Text = "image here";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Location = new Point(320, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 293);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(76, 381);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(112, 16);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.None;
            loginBtn.CustomizableEdges = customizableEdges1;
            loginBtn.DisabledState.BorderColor = Color.DarkGray;
            loginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            loginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            loginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            loginBtn.FillColor = Color.MediumSeaGreen;
            loginBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.Black;
            loginBtn.Location = new Point(70, 339);
            loginBtn.Name = "loginBtn";
            loginBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            loginBtn.Size = new Size(123, 30);
            loginBtn.TabIndex = 14;
            loginBtn.Text = "Login";
            loginBtn.Click += loginBtn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 215);
            label3.Name = "label3";
            label3.Size = new Size(64, 16);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(38, 234);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(203, 26);
            passwordTextBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 152);
            label2.Name = "label2";
            label2.Size = new Size(40, 16);
            label2.TabIndex = 11;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 79);
            label1.Name = "label1";
            label1.Size = new Size(154, 24);
            label1.TabIndex = 10;
            label1.Text = "Hospital Name";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top;
            emailTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(38, 176);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(203, 26);
            emailTextBox.TabIndex = 9;
            // 
            // selectRoleComboBox
            // 
            selectRoleComboBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectRoleComboBox.FormattingEnabled = true;
            selectRoleComboBox.Location = new Point(38, 292);
            selectRoleComboBox.Name = "selectRoleComboBox";
            selectRoleComboBox.Size = new Size(121, 26);
            selectRoleComboBox.TabIndex = 18;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 273);
            label5.Name = "label5";
            label5.Size = new Size(74, 16);
            label5.TabIndex = 19;
            label5.Text = "Select Role";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 465);
            Controls.Add(label5);
            Controls.Add(selectRoleComboBox);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(loginBtn);
            Controls.Add(label3);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(emailTextBox);
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Login Page";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Label label3;
        private TextBox passwordTextBox;
        private Label label2;
        private Label label1;
        private TextBox emailTextBox;
        private ComboBox selectRoleComboBox;
        private Label label5;
    }
}
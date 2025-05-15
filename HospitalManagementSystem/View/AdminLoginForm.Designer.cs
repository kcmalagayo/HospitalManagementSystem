namespace HospitalManagementSystem.View
{
    partial class AdminLoginForm
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
            label1 = new Label();
            logInBtn = new Guna.UI2.WinForms.Guna2Button();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            forgotPasswordLabel = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 76);
            label1.Name = "label1";
            label1.Size = new Size(187, 24);
            label1.TabIndex = 0;
            label1.Text = "Welcome, Admin!";
            label1.Click += label1_Click;
            // 
            // logInBtn
            // 
            logInBtn.CustomizableEdges = customizableEdges1;
            logInBtn.DisabledState.BorderColor = Color.DarkGray;
            logInBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            logInBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            logInBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            logInBtn.FillColor = Color.MediumSeaGreen;
            logInBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInBtn.ForeColor = Color.Black;
            logInBtn.Location = new Point(62, 292);
            logInBtn.Name = "logInBtn";
            logInBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            logInBtn.Size = new Size(154, 29);
            logInBtn.TabIndex = 1;
            logInBtn.Text = "Login";
            logInBtn.Click += logInBtn_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(42, 152);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(215, 26);
            emailTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(42, 214);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(215, 26);
            passwordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 133);
            label2.Name = "label2";
            label2.Size = new Size(40, 16);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 195);
            label3.Name = "label3";
            label3.Size = new Size(64, 16);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // forgotPasswordLabel
            // 
            forgotPasswordLabel.AutoSize = true;
            forgotPasswordLabel.Location = new Point(42, 253);
            forgotPasswordLabel.Name = "forgotPasswordLabel";
            forgotPasswordLabel.Size = new Size(105, 16);
            forgotPasswordLabel.TabIndex = 6;
            forgotPasswordLabel.TabStop = true;
            forgotPasswordLabel.Text = "Forgot Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(297, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 305);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 410);
            Controls.Add(pictureBox1);
            Controls.Add(forgotPasswordLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(logInBtn);
            Controls.Add(label1);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button logInBtn;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Label label2;
        private Label label3;
        private LinkLabel forgotPasswordLabel;
        private PictureBox pictureBox1;
    }
}
namespace HospitalManagementSystem.View
{
    partial class AdminFormLogin
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
            emailTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            passwordTextBox = new TextBox();
            loginBtn = new Guna.UI2.WinForms.Guna2Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top;
            emailTextBox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(46, 195);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(187, 22);
            emailTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 90);
            label1.Name = "label1";
            label1.Size = new Size(187, 24);
            label1.TabIndex = 1;
            label1.Text = "Welcome, Admin!";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 171);
            label2.Name = "label2";
            label2.Size = new Size(40, 16);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 234);
            label3.Name = "label3";
            label3.Size = new Size(64, 16);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(46, 253);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(187, 22);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.Bottom;
            loginBtn.CustomizableEdges = customizableEdges1;
            loginBtn.DisabledState.BorderColor = Color.DarkGray;
            loginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            loginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            loginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            loginBtn.FillColor = Color.MediumSeaGreen;
            loginBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.Black;
            loginBtn.Location = new Point(66, 292);
            loginBtn.Name = "loginBtn";
            loginBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            loginBtn.Size = new Size(139, 30);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.Click += loginBtn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(77, 339);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(112, 16);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Location = new Point(303, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 293);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(424, 215);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 8;
            label4.Text = "image here";
            // 
            // AdminFormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 420);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(loginBtn);
            Controls.Add(label3);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(emailTextBox);
            Name = "AdminFormLogin";
            Text = "Admin Login Form";
            Load += AdminFormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
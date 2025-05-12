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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            logInButton = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(21, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 26);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 89);
            label1.Name = "label1";
            label1.Size = new Size(48, 18);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 153);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(20, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(310, 26);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 224);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(20, 224);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(83, 37);
            label4.Name = "label4";
            label4.Size = new Size(172, 24);
            label4.TabIndex = 7;
            label4.Text = "Hospital System";
            // 
            // logInButton
            // 
            logInButton.CustomizableEdges = customizableEdges1;
            logInButton.DisabledState.BorderColor = Color.DarkGray;
            logInButton.DisabledState.CustomBorderColor = Color.DarkGray;
            logInButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            logInButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            logInButton.FillColor = Color.MediumSeaGreen;
            logInButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInButton.ForeColor = Color.Black;
            logInButton.Location = new Point(22, 261);
            logInButton.Name = "logInButton";
            logInButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            logInButton.Size = new Size(311, 32);
            logInButton.TabIndex = 8;
            logInButton.Text = "Log In";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(395, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 331);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(logInButton);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button logInButton;
        private PictureBox pictureBox1;
    }
}
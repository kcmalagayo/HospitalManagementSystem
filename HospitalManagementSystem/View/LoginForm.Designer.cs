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
            label3 = new Label();
            passwordTextBox = new TextBox();
            label2 = new Label();
            emailTextBox = new TextBox();
            linkLabel1 = new LinkLabel();
            showPasswordCheckBox = new CheckBox();
            loginBtn = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label5 = new Label();
            selectRoleComboBox = new ComboBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(633, 355);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 17;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 332);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(74, 361);
            passwordTextBox.Margin = new Padding(5, 4, 5, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "*********";
            passwordTextBox.Size = new Size(380, 38);
            passwordTextBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 240);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 11;
            label2.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.None;
            emailTextBox.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(74, 269);
            emailTextBox.Margin = new Padding(5, 4, 5, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "hospital@gmail.com";
            emailTextBox.Size = new Size(380, 32);
            emailTextBox.TabIndex = 9;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(74, 605);
            linkLabel1.Margin = new Padding(5, 0, 5, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(190, 25);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.Anchor = AnchorStyles.None;
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPasswordCheckBox.Location = new Point(267, 407);
            showPasswordCheckBox.Margin = new Padding(5, 4, 5, 4);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(187, 29);
            showPasswordCheckBox.TabIndex = 20;
            showPasswordCheckBox.Text = "Show password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
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
            loginBtn.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.Black;
            loginBtn.Location = new Point(170, 535);
            loginBtn.Margin = new Padding(5, 4, 5, 4);
            loginBtn.Name = "loginBtn";
            loginBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            loginBtn.Size = new Size(138, 48);
            loginBtn.TabIndex = 14;
            loginBtn.Text = "Login";
            loginBtn.Click += loginBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 124);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 46);
            label1.TabIndex = 10;
            label1.Text = "Hospital Name";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(74, 436);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 19;
            label5.Text = "Select Role";
            // 
            // selectRoleComboBox
            // 
            selectRoleComboBox.Anchor = AnchorStyles.None;
            selectRoleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectRoleComboBox.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectRoleComboBox.FormattingEnabled = true;
            selectRoleComboBox.Location = new Point(74, 465);
            selectRoleComboBox.Margin = new Padding(5, 4, 5, 4);
            selectRoleComboBox.Name = "selectRoleComboBox";
            selectRoleComboBox.Size = new Size(371, 32);
            selectRoleComboBox.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.hospital_bed_concept_illustration_114360_8239;
            pictureBox1.Location = new Point(561, 124);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(525, 528);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(showPasswordCheckBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 769);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(493, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(641, 769);
            panel2.TabIndex = 22;
            panel2.Paint += panel2_Paint_1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 769);
            Controls.Add(pictureBox1);
            Controls.Add(selectRoleComboBox);
            Controls.Add(loginBtn);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(passwordTextBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(emailTextBox);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(5, 4, 5, 4);
            Name = "LoginForm";
            Text = "Login Page";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private TextBox passwordTextBox;
        private Label label2;
        private TextBox emailTextBox;
        private LinkLabel linkLabel1;
        private CheckBox showPasswordCheckBox;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Label label1;
        private Label label5;
        private ComboBox selectRoleComboBox;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
    }
}
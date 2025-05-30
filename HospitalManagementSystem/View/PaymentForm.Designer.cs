namespace HospitalManagementSystem
{
    partial class PaymentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            doctorNameLb = new Label();
            appointmentLb = new Label();
            priceLb = new Label();
            label7 = new Label();
            cashRb = new RadioButton();
            gcashRb = new RadioButton();
            creditRb = new RadioButton();
            confirmBtn = new Button();
            label8 = new Label();
            specializationLb = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 186);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 21);
            label1.TabIndex = 0;
            label1.Text = "Consultation Price: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(13, 143);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 1;
            label2.Text = "Appointment Date: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(13, 51);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 2;
            label3.Text = "Doctor Name: ";
            // 
            // doctorNameLb
            // 
            doctorNameLb.AutoSize = true;
            doctorNameLb.Font = new Font("Segoe UI", 12F);
            doctorNameLb.Location = new Point(179, 51);
            doctorNameLb.Margin = new Padding(4, 0, 4, 0);
            doctorNameLb.Name = "doctorNameLb";
            doctorNameLb.Size = new Size(88, 21);
            doctorNameLb.TabIndex = 3;
            doctorNameLb.Text = "John Smith";
            // 
            // appointmentLb
            // 
            appointmentLb.AutoSize = true;
            appointmentLb.Font = new Font("Segoe UI", 12F);
            appointmentLb.Location = new Point(230, 143);
            appointmentLb.Margin = new Padding(4, 0, 4, 0);
            appointmentLb.Name = "appointmentLb";
            appointmentLb.Size = new Size(94, 21);
            appointmentLb.TabIndex = 4;
            appointmentLb.Text = "05/30/2025";
            // 
            // priceLb
            // 
            priceLb.AutoSize = true;
            priceLb.Font = new Font("Segoe UI", 12F);
            priceLb.Location = new Point(231, 186);
            priceLb.Margin = new Padding(4, 0, 4, 0);
            priceLb.Name = "priceLb";
            priceLb.Size = new Size(40, 21);
            priceLb.TabIndex = 5;
            priceLb.Text = "0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(18, 238);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(176, 21);
            label7.TabIndex = 6;
            label7.Text = "Select Payment Method:";
            // 
            // cashRb
            // 
            cashRb.AutoSize = true;
            cashRb.Font = new Font("Segoe UI", 12F);
            cashRb.Location = new Point(23, 288);
            cashRb.Margin = new Padding(4);
            cashRb.Name = "cashRb";
            cashRb.Size = new Size(62, 25);
            cashRb.TabIndex = 7;
            cashRb.TabStop = true;
            cashRb.Text = "Cash";
            cashRb.UseVisualStyleBackColor = true;
            // 
            // gcashRb
            // 
            gcashRb.AutoSize = true;
            gcashRb.Font = new Font("Segoe UI", 12F);
            gcashRb.Location = new Point(143, 288);
            gcashRb.Margin = new Padding(4);
            gcashRb.Name = "gcashRb";
            gcashRb.Size = new Size(73, 25);
            gcashRb.TabIndex = 8;
            gcashRb.TabStop = true;
            gcashRb.Text = "GCash";
            gcashRb.UseVisualStyleBackColor = true;
            // 
            // creditRb
            // 
            creditRb.AutoSize = true;
            creditRb.Font = new Font("Segoe UI", 12F);
            creditRb.Location = new Point(267, 288);
            creditRb.Margin = new Padding(4);
            creditRb.Name = "creditRb";
            creditRb.Size = new Size(107, 25);
            creditRb.TabIndex = 9;
            creditRb.TabStop = true;
            creditRb.Text = "Credit Card";
            creditRb.UseVisualStyleBackColor = true;
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.MediumSeaGreen;
            confirmBtn.FlatStyle = FlatStyle.Flat;
            confirmBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            confirmBtn.ForeColor = Color.WhiteSmoke;
            confirmBtn.Location = new Point(121, 375);
            confirmBtn.Margin = new Padding(4);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(393, 75);
            confirmBtn.TabIndex = 10;
            confirmBtn.Text = "Confirm Booking";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(14, 98);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 21);
            label8.TabIndex = 11;
            label8.Text = "Specialization: ";
            // 
            // specializationLb
            // 
            specializationLb.AutoSize = true;
            specializationLb.Font = new Font("Segoe UI", 12F);
            specializationLb.Location = new Point(179, 98);
            specializationLb.Margin = new Padding(4, 0, 4, 0);
            specializationLb.Name = "specializationLb";
            specializationLb.Size = new Size(118, 21);
            specializationLb.TabIndex = 12;
            specializationLb.Text = "Opthalmologist";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 499);
            Controls.Add(specializationLb);
            Controls.Add(label8);
            Controls.Add(confirmBtn);
            Controls.Add(creditRb);
            Controls.Add(gcashRb);
            Controls.Add(cashRb);
            Controls.Add(label7);
            Controls.Add(priceLb);
            Controls.Add(appointmentLb);
            Controls.Add(doctorNameLb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(5);
            Name = "PaymentForm";
            Text = "Payment";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label doctorNameLb;
        private Label appointmentLb;
        private Label priceLb;
        private Label label7;
        private RadioButton cashRb;
        private RadioButton gcashRb;
        private RadioButton creditRb;
        private Button confirmBtn;
        private Label label8;
        private Label specializationLb;
    }
}

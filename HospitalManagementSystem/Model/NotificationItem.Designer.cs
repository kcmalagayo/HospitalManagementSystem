namespace HospitalManagementSystem.Model
{
    partial class NotificationItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            messageLb = new Label();
            dateTimeLb = new Label();
            SuspendLayout();
            // 
            // messageLb
            // 
            messageLb.AutoSize = true;
            messageLb.Font = new Font("Segoe UI", 12F);
            messageLb.Location = new Point(85, 81);
            messageLb.Name = "messageLb";
            messageLb.Size = new Size(341, 32);
            messageLb.TabIndex = 0;
            messageLb.Text = "NOTIFICATION MESSAGE HERE";
            // 
            // dateTimeLb
            // 
            dateTimeLb.AutoSize = true;
            dateTimeLb.Font = new Font("Segoe UI", 10F);
            dateTimeLb.Location = new Point(938, 163);
            dateTimeLb.Name = "dateTimeLb";
            dateTimeLb.Size = new Size(176, 28);
            dateTimeLb.TabIndex = 1;
            dateTimeLb.Text = "DATE + TIME HERE";
            dateTimeLb.Click += dateTimeLb_Click;
            // 
            // NotificationItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(dateTimeLb);
            Controls.Add(messageLb);
            Margin = new Padding(20);
            Name = "NotificationItem";
            Size = new Size(1210, 200);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label messageLb;
        private Label dateTimeLb;
    }
}

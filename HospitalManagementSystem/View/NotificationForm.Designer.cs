namespace HospitalManagementSystem.View
{
    partial class NotificationForm
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
            NOTIFPANEL = new FlowLayoutPanel();
            notifLabel = new Label();
            SuspendLayout();
            // 
            // NOTIFPANEL
            // 
            NOTIFPANEL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NOTIFPANEL.AutoScroll = true;
            NOTIFPANEL.FlowDirection = FlowDirection.TopDown;
            NOTIFPANEL.Location = new Point(0, 67);
            NOTIFPANEL.Name = "NOTIFPANEL";
            NOTIFPANEL.Size = new Size(1142, 705);
            NOTIFPANEL.TabIndex = 0;
            NOTIFPANEL.WrapContents = false;
            // 
            // notifLabel
            // 
            notifLabel.AutoSize = true;
            notifLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notifLabel.Location = new Point(12, 9);
            notifLabel.Name = "notifLabel";
            notifLabel.Size = new Size(202, 41);
            notifLabel.TabIndex = 1;
            notifLabel.Text = "Notifications";
            // 
            // NotificationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 772);
            Controls.Add(notifLabel);
            Controls.Add(NOTIFPANEL);
            Name = "NotificationForm";
            Text = "NotificationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel NOTIFPANEL;
        private Label notifLabel;
    }
}
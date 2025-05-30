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
            label2 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 8;
            label2.Text = "CHANGE PASSWORD";
            // 
            // ChangePasswordcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 454);
            Controls.Add(label2);
            MaximizeBox = false;
            Name = "ChangePasswordcs";
            Text = "ChangePasswordcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
    }
}
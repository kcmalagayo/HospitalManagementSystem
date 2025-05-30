namespace HospitalManagementSystem.View
{
    partial class TransactionHistoryForm
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
            transacFlowPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // transacFlowPanel
            // 
            transacFlowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            transacFlowPanel.AutoScroll = true;
            transacFlowPanel.AutoSize = true;
            transacFlowPanel.FlowDirection = FlowDirection.TopDown;
            transacFlowPanel.Location = new Point(0, 0);
            transacFlowPanel.Name = "transacFlowPanel";
            transacFlowPanel.Size = new Size(1142, 842);
            transacFlowPanel.TabIndex = 3;
            transacFlowPanel.WrapContents = false;
            // 
            // TransactionHistoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1142, 844);
            Controls.Add(transacFlowPanel);
            Name = "TransactionHistoryForm";
            Text = "TransactionHistoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel transacFlowPanel;
    }
}
namespace Group_Project
{
    partial class SalesReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportForm));
            this.SalesReportListBox = new System.Windows.Forms.ListBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalesReportListBox
            // 
            this.SalesReportListBox.FormattingEnabled = true;
            this.SalesReportListBox.Location = new System.Drawing.Point(99, 32);
            this.SalesReportListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SalesReportListBox.Name = "SalesReportListBox";
            this.SalesReportListBox.Size = new System.Drawing.Size(305, 199);
            this.SalesReportListBox.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(425, 238);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(79, 32);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SalesReportListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SalesReportForm";
            this.Text = "Sales Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SalesReportListBox;
        private System.Windows.Forms.Button ExitButton;
    }
}
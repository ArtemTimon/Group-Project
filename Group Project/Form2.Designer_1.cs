namespace Group_Project
{
    partial class StockLevelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockLevelForm));
            this.StockLevelBox = new System.Windows.Forms.ListBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StockLevelBox
            // 
            this.StockLevelBox.FormattingEnabled = true;
            this.StockLevelBox.Location = new System.Drawing.Point(71, 30);
            this.StockLevelBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StockLevelBox.Name = "StockLevelBox";
            this.StockLevelBox.Size = new System.Drawing.Size(321, 199);
            this.StockLevelBox.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(421, 242);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 31);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // StockLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StockLevelBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StockLevelForm";
            this.Text = "Stock level";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StockLevelBox;
        private System.Windows.Forms.Button ExitButton;
    }
}
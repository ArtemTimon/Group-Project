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
            this.StockLevelBox.ItemHeight = 20;
            this.StockLevelBox.Location = new System.Drawing.Point(107, 46);
            this.StockLevelBox.Name = "StockLevelBox";
            this.StockLevelBox.Size = new System.Drawing.Size(480, 304);
            this.StockLevelBox.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(632, 372);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(113, 47);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // StockLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StockLevelBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockLevelForm";
            this.Text = "Stock level";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StockLevelBox;
        private System.Windows.Forms.Button ExitButton;
    }
}
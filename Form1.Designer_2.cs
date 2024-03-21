namespace Group_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.ColourListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ViewStockButton = new System.Windows.Forms.Button();
            this.BagButton = new System.Windows.Forms.Button();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.ColourLabel = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.TransactionSummaryListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearSearchButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchListBox = new System.Windows.Forms.ListBox();
            this.SalesButton = new System.Windows.Forms.Button();
            this.TransactionNoRadioButton = new System.Windows.Forms.RadioButton();
            this.DateRadioButton = new System.Windows.Forms.RadioButton();
            this.ClearBagButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 20;
            this.ItemListBox.Items.AddRange(new object[] {
            "Earrings",
            "Ring",
            "Necklace",
            "Bangle",
            "Cufflinks",
            "Watch",
            "Anklet",
            "Belly Button Piercing",
            "Nose Piercing",
            "Bracelet",
            "Hairband",
            "Belly Chain"});
            this.ItemListBox.Location = new System.Drawing.Point(44, 61);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(200, 244);
            this.ItemListBox.TabIndex = 0;
            // 
            // ColourListBox
            // 
            this.ColourListBox.FormattingEnabled = true;
            this.ColourListBox.ItemHeight = 20;
            this.ColourListBox.Items.AddRange(new object[] {
            "Gold",
            "Silver",
            "Rose Gold",
            "Mixed Metal",
            "Purple",
            "Blue"});
            this.ColourListBox.Location = new System.Drawing.Point(298, 61);
            this.ColourListBox.Name = "ColourListBox";
            this.ColourListBox.Size = new System.Drawing.Size(113, 124);
            this.ColourListBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.SalesButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.ViewStockButton);
            this.panel1.Location = new System.Drawing.Point(1101, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 281);
            this.panel1.TabIndex = 3;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(30, 212);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(129, 46);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(30, 150);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(129, 46);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // ViewStockButton
            // 
            this.ViewStockButton.Location = new System.Drawing.Point(30, 89);
            this.ViewStockButton.Name = "ViewStockButton";
            this.ViewStockButton.Size = new System.Drawing.Size(129, 46);
            this.ViewStockButton.TabIndex = 1;
            this.ViewStockButton.Text = "View Stock";
            this.ViewStockButton.UseVisualStyleBackColor = true;
            // 
            // BagButton
            // 
            this.BagButton.Enabled = false;
            this.BagButton.Location = new System.Drawing.Point(453, 61);
            this.BagButton.Name = "BagButton";
            this.BagButton.Size = new System.Drawing.Size(110, 38);
            this.BagButton.TabIndex = 9;
            this.BagButton.Text = "Add To Bag";
            this.BagButton.UseVisualStyleBackColor = true;
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Location = new System.Drawing.Point(54, 29);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(41, 20);
            this.ItemLabel.TabIndex = 5;
            this.ItemLabel.Text = "Item";
            // 
            // ColourLabel
            // 
            this.ColourLabel.AutoSize = true;
            this.ColourLabel.Location = new System.Drawing.Point(294, 29);
            this.ColourLabel.Name = "ColourLabel";
            this.ColourLabel.Size = new System.Drawing.Size(55, 20);
            this.ColourLabel.TabIndex = 7;
            this.ColourLabel.Text = "Colour";
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(801, 418);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(129, 46);
            this.BuyButton.TabIndex = 8;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            // 
            // TransactionSummaryListBox
            // 
            this.TransactionSummaryListBox.FormattingEnabled = true;
            this.TransactionSummaryListBox.ItemHeight = 20;
            this.TransactionSummaryListBox.Location = new System.Drawing.Point(630, 61);
            this.TransactionSummaryListBox.Name = "TransactionSummaryListBox";
            this.TransactionSummaryListBox.Size = new System.Drawing.Size(456, 264);
            this.TransactionSummaryListBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(741, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Colour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(851, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(963, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Unit Price";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalLabel.Location = new System.Drawing.Point(864, 353);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(2, 22);
            this.TotalLabel.TabIndex = 15;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.DateRadioButton);
            this.SearchGroupBox.Controls.Add(this.TransactionNoRadioButton);
            this.SearchGroupBox.Controls.Add(this.ClearSearchButton);
            this.SearchGroupBox.Controls.Add(this.SearchButton);
            this.SearchGroupBox.Controls.Add(this.SearchTextBox);
            this.SearchGroupBox.Controls.Add(this.SearchListBox);
            this.SearchGroupBox.Location = new System.Drawing.Point(44, 327);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(552, 291);
            this.SearchGroupBox.TabIndex = 17;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            // 
            // ClearSearchButton
            // 
            this.ClearSearchButton.Location = new System.Drawing.Point(421, 91);
            this.ClearSearchButton.Name = "ClearSearchButton";
            this.ClearSearchButton.Size = new System.Drawing.Size(98, 27);
            this.ClearSearchButton.TabIndex = 3;
            this.ClearSearchButton.Text = "Clear";
            this.ClearSearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(421, 43);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(98, 27);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(42, 45);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(149, 26);
            this.SearchTextBox.TabIndex = 1;
            // 
            // SearchListBox
            // 
            this.SearchListBox.FormattingEnabled = true;
            this.SearchListBox.ItemHeight = 20;
            this.SearchListBox.Location = new System.Drawing.Point(23, 109);
            this.SearchListBox.Name = "SearchListBox";
            this.SearchListBox.Size = new System.Drawing.Size(373, 164);
            this.SearchListBox.TabIndex = 0;
            // 
            // SalesButton
            // 
            this.SalesButton.Location = new System.Drawing.Point(30, 23);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(129, 46);
            this.SalesButton.TabIndex = 18;
            this.SalesButton.Text = "View Sales";
            this.SalesButton.UseVisualStyleBackColor = true;
            // 
            // TransactionNoRadioButton
            // 
            this.TransactionNoRadioButton.AutoSize = true;
            this.TransactionNoRadioButton.Location = new System.Drawing.Point(219, 25);
            this.TransactionNoRadioButton.Name = "TransactionNoRadioButton";
            this.TransactionNoRadioButton.Size = new System.Drawing.Size(177, 24);
            this.TransactionNoRadioButton.TabIndex = 4;
            this.TransactionNoRadioButton.TabStop = true;
            this.TransactionNoRadioButton.Text = "Transaction Number";
            this.TransactionNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // DateRadioButton
            // 
            this.DateRadioButton.AutoSize = true;
            this.DateRadioButton.Location = new System.Drawing.Point(219, 65);
            this.DateRadioButton.Name = "DateRadioButton";
            this.DateRadioButton.Size = new System.Drawing.Size(69, 24);
            this.DateRadioButton.TabIndex = 5;
            this.DateRadioButton.TabStop = true;
            this.DateRadioButton.Text = "Date";
            this.DateRadioButton.UseVisualStyleBackColor = true;
            // 
            // ClearBagButton
            // 
            this.ClearBagButton.Enabled = false;
            this.ClearBagButton.Location = new System.Drawing.Point(453, 267);
            this.ClearBagButton.Name = "ClearBagButton";
            this.ClearBagButton.Size = new System.Drawing.Size(110, 38);
            this.ClearBagButton.TabIndex = 18;
            this.ClearBagButton.Text = "Clear Bag";
            this.ClearBagButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 658);
            this.Controls.Add(this.ClearBagButton);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BagButton);
            this.Controls.Add(this.TransactionSummaryListBox);
            this.Controls.Add(this.ColourLabel);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ColourListBox);
            this.Controls.Add(this.ItemListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Crystal Dreams Jewellery";
            this.panel1.ResumeLayout(false);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.ListBox ColourListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label ColourLabel;
        private System.Windows.Forms.Button ViewStockButton;
        private System.Windows.Forms.Button BagButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.ListBox TransactionSummaryListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.ListBox SearchListBox;
        private System.Windows.Forms.Button ClearSearchButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.RadioButton DateRadioButton;
        private System.Windows.Forms.RadioButton TransactionNoRadioButton;
        private System.Windows.Forms.Button ClearBagButton;
    }
}


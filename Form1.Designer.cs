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
            this.DisplayButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ViewStocksButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.DateRadioButton = new System.Windows.Forms.RadioButton();
            this.TransactionNoRadioButton = new System.Windows.Forms.RadioButton();
            this.ClearSearchButton = new System.Windows.Forms.Button();
            this.SearchDataButton = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SearchListBox = new System.Windows.Forms.ListBox();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.ColourLabel = new System.Windows.Forms.Label();
            this.BagButton = new System.Windows.Forms.Button();
            this.ClearBagButton = new System.Windows.Forms.Button();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TransactionSummaryListBox = new System.Windows.Forms.ListBox();
            this.TransactionSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.DoubleConfirmButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TransactionNumberLabel = new System.Windows.Forms.Label();
            this.Transaction = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.BookingEvent = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TransactionDisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.TransactionDataGrid = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComfirmButton = new System.Windows.Forms.Button();
            this.AddGroupBox = new System.Windows.Forms.GroupBox();
            this.WomanGiftButton = new System.Windows.Forms.RadioButton();
            this.ManGistButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.TransactionSummaryGroupBox.SuspendLayout();
            this.BookingEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TransactionDisplayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGrid)).BeginInit();
            this.AddGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
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
            this.ItemListBox.Location = new System.Drawing.Point(97, 32);
            this.ItemListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(135, 160);
            this.ItemListBox.TabIndex = 0;
            // 
            // ColourListBox
            // 
            this.ColourListBox.FormattingEnabled = true;
            this.ColourListBox.Items.AddRange(new object[] {
            "Gold",
            "Silver",
            "Rose Gold",
            "Mixed Metal",
            "Purple",
            "Blue"});
            this.ColourListBox.Location = new System.Drawing.Point(254, 32);
            this.ColourListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ColourListBox.Name = "ColourListBox";
            this.ColourListBox.Size = new System.Drawing.Size(77, 82);
            this.ColourListBox.TabIndex = 1;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayButton.Location = new System.Drawing.Point(22, 18);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(86, 27);
            this.DisplayButton.TabIndex = 21;
            this.DisplayButton.Text = "&Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.Location = new System.Drawing.Point(489, 188);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(86, 27);
            this.RegisterButton.TabIndex = 22;
            this.RegisterButton.Text = "&Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(22, 205);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(86, 30);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(22, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 27);
            this.button2.TabIndex = 23;
            this.button2.Text = "&View Sales";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ViewStocksButton
            // 
            this.ViewStocksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewStocksButton.Location = new System.Drawing.Point(22, 132);
            this.ViewStocksButton.Name = "ViewStocksButton";
            this.ViewStocksButton.Size = new System.Drawing.Size(86, 27);
            this.ViewStocksButton.TabIndex = 24;
            this.ViewStocksButton.Text = "&View Stocks";
            this.ViewStocksButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(22, 169);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(86, 27);
            this.ClearButton.TabIndex = 25;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(22, 55);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(86, 27);
            this.SearchButton.TabIndex = 26;
            this.SearchButton.Text = "&Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.ViewStocksButton);
            this.panel1.Controls.Add(this.SearchGroupBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.DisplayButton);
            this.panel1.Location = new System.Drawing.Point(672, 171);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 244);
            this.panel1.TabIndex = 3;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.DateRadioButton);
            this.SearchGroupBox.Controls.Add(this.TransactionNoRadioButton);
            this.SearchGroupBox.Controls.Add(this.ClearSearchButton);
            this.SearchGroupBox.Controls.Add(this.SearchDataButton);
            this.SearchGroupBox.Controls.Add(this.BuyButton);
            this.SearchGroupBox.Controls.Add(this.SearchTextBox);
            this.SearchGroupBox.Controls.Add(this.TotalLabel);
            this.SearchGroupBox.Controls.Add(this.SearchListBox);
            this.SearchGroupBox.Location = new System.Drawing.Point(131, 46);
            this.SearchGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SearchGroupBox.Size = new System.Drawing.Size(389, 189);
            this.SearchGroupBox.TabIndex = 17;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            this.SearchGroupBox.Visible = false;
            // 
            // DateRadioButton
            // 
            this.DateRadioButton.AutoSize = true;
            this.DateRadioButton.Location = new System.Drawing.Point(146, 42);
            this.DateRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.DateRadioButton.Name = "DateRadioButton";
            this.DateRadioButton.Size = new System.Drawing.Size(48, 17);
            this.DateRadioButton.TabIndex = 5;
            this.DateRadioButton.TabStop = true;
            this.DateRadioButton.Text = "Date";
            this.DateRadioButton.UseVisualStyleBackColor = true;
            // 
            // TransactionNoRadioButton
            // 
            this.TransactionNoRadioButton.AutoSize = true;
            this.TransactionNoRadioButton.Location = new System.Drawing.Point(146, 16);
            this.TransactionNoRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.TransactionNoRadioButton.Name = "TransactionNoRadioButton";
            this.TransactionNoRadioButton.Size = new System.Drawing.Size(121, 17);
            this.TransactionNoRadioButton.TabIndex = 4;
            this.TransactionNoRadioButton.TabStop = true;
            this.TransactionNoRadioButton.Text = "Transaction Number";
            this.TransactionNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // ClearSearchButton
            // 
            this.ClearSearchButton.Location = new System.Drawing.Point(296, 128);
            this.ClearSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearSearchButton.Name = "ClearSearchButton";
            this.ClearSearchButton.Size = new System.Drawing.Size(65, 30);
            this.ClearSearchButton.TabIndex = 3;
            this.ClearSearchButton.Text = "Clear";
            this.ClearSearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchDataButton
            // 
            this.SearchDataButton.Location = new System.Drawing.Point(296, 52);
            this.SearchDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchDataButton.Name = "SearchDataButton";
            this.SearchDataButton.Size = new System.Drawing.Size(65, 27);
            this.SearchDataButton.TabIndex = 2;
            this.SearchDataButton.Text = "Search";
            this.SearchDataButton.UseVisualStyleBackColor = true;
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(383, 291);
            this.BuyButton.Margin = new System.Windows.Forms.Padding(2);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(86, 30);
            this.BuyButton.TabIndex = 8;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(28, 29);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(101, 20);
            this.SearchTextBox.TabIndex = 1;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalLabel.Location = new System.Drawing.Point(425, 248);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(2, 15);
            this.TotalLabel.TabIndex = 15;
            // 
            // SearchListBox
            // 
            this.SearchListBox.FormattingEnabled = true;
            this.SearchListBox.Location = new System.Drawing.Point(15, 71);
            this.SearchListBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchListBox.Name = "SearchListBox";
            this.SearchListBox.Size = new System.Drawing.Size(250, 108);
            this.SearchListBox.TabIndex = 0;
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Location = new System.Drawing.Point(104, 11);
            this.ItemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(27, 13);
            this.ItemLabel.TabIndex = 5;
            this.ItemLabel.Text = "Item";
            // 
            // ColourLabel
            // 
            this.ColourLabel.AutoSize = true;
            this.ColourLabel.Location = new System.Drawing.Point(256, 11);
            this.ColourLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColourLabel.Name = "ColourLabel";
            this.ColourLabel.Size = new System.Drawing.Size(37, 13);
            this.ColourLabel.TabIndex = 7;
            this.ColourLabel.Text = "Colour";
            // 
            // BagButton
            // 
            this.BagButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BagButton.Location = new System.Drawing.Point(707, 26);
            this.BagButton.Margin = new System.Windows.Forms.Padding(2);
            this.BagButton.Name = "BagButton";
            this.BagButton.Size = new System.Drawing.Size(73, 25);
            this.BagButton.TabIndex = 9;
            this.BagButton.Text = "&Add To Bag";
            this.BagButton.UseVisualStyleBackColor = true;
            this.BagButton.Click += new System.EventHandler(this.BagButton_Click);
            // 
            // ClearBagButton
            // 
            this.ClearBagButton.Enabled = false;
            this.ClearBagButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBagButton.Location = new System.Drawing.Point(707, 70);
            this.ClearBagButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearBagButton.Name = "ClearBagButton";
            this.ClearBagButton.Size = new System.Drawing.Size(73, 25);
            this.ClearBagButton.TabIndex = 18;
            this.ClearBagButton.Text = "&Clear Bag";
            this.ClearBagButton.UseVisualStyleBackColor = true;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(394, 11);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.QuantityLabel.TabIndex = 19;
            this.QuantityLabel.Text = "Quantity";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(371, 32);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantityTextBox.TabIndex = 20;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Item";
            // 
            // TransactionSummaryListBox
            // 
            this.TransactionSummaryListBox.FormattingEnabled = true;
            this.TransactionSummaryListBox.Location = new System.Drawing.Point(143, 25);
            this.TransactionSummaryListBox.Margin = new System.Windows.Forms.Padding(2);
            this.TransactionSummaryListBox.Name = "TransactionSummaryListBox";
            this.TransactionSummaryListBox.Size = new System.Drawing.Size(305, 212);
            this.TransactionSummaryListBox.TabIndex = 10;
            // 
            // TransactionSummaryGroupBox
            // 
            this.TransactionSummaryGroupBox.Controls.Add(this.DoubleConfirmButton);
            this.TransactionSummaryGroupBox.Controls.Add(this.label10);
            this.TransactionSummaryGroupBox.Controls.Add(this.label9);
            this.TransactionSummaryGroupBox.Controls.Add(this.label5);
            this.TransactionSummaryGroupBox.Controls.Add(this.label3);
            this.TransactionSummaryGroupBox.Controls.Add(this.TransactionSummaryListBox);
            this.TransactionSummaryGroupBox.Controls.Add(this.label2);
            this.TransactionSummaryGroupBox.Controls.Add(this.label4);
            this.TransactionSummaryGroupBox.Location = new System.Drawing.Point(171, 98);
            this.TransactionSummaryGroupBox.Name = "TransactionSummaryGroupBox";
            this.TransactionSummaryGroupBox.Size = new System.Drawing.Size(541, 303);
            this.TransactionSummaryGroupBox.TabIndex = 21;
            this.TransactionSummaryGroupBox.TabStop = false;
            this.TransactionSummaryGroupBox.Text = "TransactionSummary";
            // 
            // DoubleConfirmButton
            // 
            this.DoubleConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoubleConfirmButton.Location = new System.Drawing.Point(434, 252);
            this.DoubleConfirmButton.Name = "DoubleConfirmButton";
            this.DoubleConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.DoubleConfirmButton.TabIndex = 18;
            this.DoubleConfirmButton.Text = "&Confirm";
            this.DoubleConfirmButton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Transaction Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 13;
            // 
            // TransactionNumberLabel
            // 
            this.TransactionNumberLabel.AutoSize = true;
            this.TransactionNumberLabel.Location = new System.Drawing.Point(532, 22);
            this.TransactionNumberLabel.Name = "TransactionNumberLabel";
            this.TransactionNumberLabel.Size = new System.Drawing.Size(43, 13);
            this.TransactionNumberLabel.TabIndex = 0;
            this.TransactionNumberLabel.Text = "123456";
            // 
            // Transaction
            // 
            this.Transaction.AutoSize = true;
            this.Transaction.Location = new System.Drawing.Point(430, 22);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(106, 13);
            this.Transaction.TabIndex = 1;
            this.Transaction.Text = "Transaction Number:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmailTextBox.Location = new System.Drawing.Point(233, 182);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(197, 20);
            this.EmailTextBox.TabIndex = 2;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(233, 144);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(197, 20);
            this.PhoneTextBox.TabIndex = 3;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(233, 55);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(197, 20);
            this.FirstNameTextBox.TabIndex = 4;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(233, 98);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(197, 20);
            this.SurnameTextBox.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(87, 60);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 16);
            this.label21.TabIndex = 12;
            this.label21.Text = "First Name";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(87, 102);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 16);
            this.label24.TabIndex = 12;
            this.label24.Text = "Surname";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(87, 144);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(140, 16);
            this.label25.TabIndex = 12;
            this.label25.Text = "Telephone Number";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(87, 180);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(107, 16);
            this.label26.TabIndex = 12;
            this.label26.Text = "Email address";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(26, 25);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(33, 13);
            this.label28.TabIndex = 14;
            this.label28.Text = "Date:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(55, 25);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(61, 13);
            this.DateLabel.TabIndex = 15;
            this.DateLabel.Text = "20.12.2022";
            // 
            // BookingEvent
            // 
            this.BookingEvent.Controls.Add(this.DateLabel);
            this.BookingEvent.Controls.Add(this.label28);
            this.BookingEvent.Controls.Add(this.label26);
            this.BookingEvent.Controls.Add(this.label25);
            this.BookingEvent.Controls.Add(this.label24);
            this.BookingEvent.Controls.Add(this.RegisterButton);
            this.BookingEvent.Controls.Add(this.label21);
            this.BookingEvent.Controls.Add(this.SurnameTextBox);
            this.BookingEvent.Controls.Add(this.FirstNameTextBox);
            this.BookingEvent.Controls.Add(this.PhoneTextBox);
            this.BookingEvent.Controls.Add(this.EmailTextBox);
            this.BookingEvent.Controls.Add(this.Transaction);
            this.BookingEvent.Controls.Add(this.TransactionNumberLabel);
            this.BookingEvent.Location = new System.Drawing.Point(66, 161);
            this.BookingEvent.Name = "BookingEvent";
            this.BookingEvent.Size = new System.Drawing.Size(603, 235);
            this.BookingEvent.TabIndex = 28;
            this.BookingEvent.TabStop = false;
            this.BookingEvent.Text = "Booking";
            this.BookingEvent.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // TransactionDisplayGroupBox
            // 
            this.TransactionDisplayGroupBox.Controls.Add(this.TransactionDataGrid);
            this.TransactionDisplayGroupBox.Controls.Add(this.ComfirmButton);
            this.TransactionDisplayGroupBox.Location = new System.Drawing.Point(76, 141);
            this.TransactionDisplayGroupBox.Name = "TransactionDisplayGroupBox";
            this.TransactionDisplayGroupBox.Size = new System.Drawing.Size(559, 292);
            this.TransactionDisplayGroupBox.TabIndex = 22;
            this.TransactionDisplayGroupBox.TabStop = false;
            this.TransactionDisplayGroupBox.Text = "TransactionDisplay";
            this.TransactionDisplayGroupBox.Visible = false;
            // 
            // TransactionDataGrid
            // 
            this.TransactionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Colour,
            this.Quantity,
            this.Unit,
            this.Total});
            this.TransactionDataGrid.Location = new System.Drawing.Point(0, 19);
            this.TransactionDataGrid.Name = "TransactionDataGrid";
            this.TransactionDataGrid.Size = new System.Drawing.Size(520, 230);
            this.TransactionDataGrid.TabIndex = 17;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Colour
            // 
            this.Colour.HeaderText = "Colour";
            this.Colour.Name = "Colour";
            this.Colour.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // ComfirmButton
            // 
            this.ComfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComfirmButton.Location = new System.Drawing.Point(418, 257);
            this.ComfirmButton.Name = "ComfirmButton";
            this.ComfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ComfirmButton.TabIndex = 16;
            this.ComfirmButton.Text = "&Confirm";
            this.ComfirmButton.UseVisualStyleBackColor = true;
            this.ComfirmButton.Click += new System.EventHandler(this.ComfirmButton_Click);
            // 
            // AddGroupBox
            // 
            this.AddGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddGroupBox.Controls.Add(this.TransactionSummaryGroupBox);
            this.AddGroupBox.Controls.Add(this.WomanGiftButton);
            this.AddGroupBox.Controls.Add(this.ManGistButton);
            this.AddGroupBox.Location = new System.Drawing.Point(504, 11);
            this.AddGroupBox.Name = "AddGroupBox";
            this.AddGroupBox.Size = new System.Drawing.Size(180, 131);
            this.AddGroupBox.TabIndex = 30;
            this.AddGroupBox.TabStop = false;
            this.AddGroupBox.Text = "AdditionalBox";
            // 
            // WomanGiftButton
            // 
            this.WomanGiftButton.AutoSize = true;
            this.WomanGiftButton.Location = new System.Drawing.Point(45, 76);
            this.WomanGiftButton.Name = "WomanGiftButton";
            this.WomanGiftButton.Size = new System.Drawing.Size(102, 17);
            this.WomanGiftButton.TabIndex = 2;
            this.WomanGiftButton.TabStop = true;
            this.WomanGiftButton.Text = "Woman Gift Box";
            this.WomanGiftButton.UseVisualStyleBackColor = true;
            // 
            // ManGistButton
            // 
            this.ManGistButton.AutoSize = true;
            this.ManGistButton.Location = new System.Drawing.Point(45, 30);
            this.ManGistButton.Name = "ManGistButton";
            this.ManGistButton.Size = new System.Drawing.Size(86, 17);
            this.ManGistButton.TabIndex = 0;
            this.ManGistButton.TabStop = true;
            this.ManGistButton.Text = "Man Gift Box";
            this.ManGistButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 428);
            this.Controls.Add(this.TransactionDisplayGroupBox);
            this.Controls.Add(this.AddGroupBox);
            this.Controls.Add(this.BookingEvent);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ClearBagButton);
            this.Controls.Add(this.BagButton);
            this.Controls.Add(this.ColourLabel);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ColourListBox);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Crystal Dreams Jewellery";
            this.panel1.ResumeLayout(false);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.TransactionSummaryGroupBox.ResumeLayout(false);
            this.TransactionSummaryGroupBox.PerformLayout();
            this.BookingEvent.ResumeLayout(false);
            this.BookingEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TransactionDisplayGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGrid)).EndInit();
            this.AddGroupBox.ResumeLayout(false);
            this.AddGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.ListBox ColourListBox;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ViewStocksButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label ColourLabel;
        private System.Windows.Forms.Button BagButton;
        private System.Windows.Forms.Button ClearBagButton;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox TransactionSummaryListBox;
        private System.Windows.Forms.GroupBox TransactionSummaryGroupBox;
        private System.Windows.Forms.Label TransactionNumberLabel;
        private System.Windows.Forms.Label Transaction;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.RadioButton DateRadioButton;
        private System.Windows.Forms.RadioButton TransactionNoRadioButton;
        private System.Windows.Forms.Button ClearSearchButton;
        private System.Windows.Forms.Button SearchDataButton;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.ListBox SearchListBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.GroupBox BookingEvent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox TransactionDisplayGroupBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox AddGroupBox;
        private System.Windows.Forms.RadioButton WomanGiftButton;
        private System.Windows.Forms.RadioButton ManGistButton;
        private System.Windows.Forms.Button ComfirmButton;
        private System.Windows.Forms.Button DoubleConfirmButton;
        private System.Windows.Forms.DataGridView TransactionDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}


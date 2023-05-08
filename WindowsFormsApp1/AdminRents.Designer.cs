namespace WindowsFormsApp1
{
    partial class AdminRents
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
            this.label11 = new System.Windows.Forms.Label();
            this.LastDay_textBox = new System.Windows.Forms.TextBox();
            this.Time_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Date_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PaymentContent = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchFilters_ComboBox = new System.Windows.Forms.ComboBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(395, 162);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Payment type";
            // 
            // LastDay_textBox
            // 
            this.LastDay_textBox.Location = new System.Drawing.Point(171, 89);
            this.LastDay_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.LastDay_textBox.Name = "LastDay_textBox";
            this.LastDay_textBox.Size = new System.Drawing.Size(132, 22);
            this.LastDay_textBox.TabIndex = 22;
            // 
            // Time_textBox
            // 
            this.Time_textBox.Location = new System.Drawing.Point(171, 58);
            this.Time_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Time_textBox.Name = "Time_textBox";
            this.Time_textBox.Size = new System.Drawing.Size(132, 22);
            this.Time_textBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "LastPaymentDay";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Date";
            // 
            // Date_textBox
            // 
            this.Date_textBox.Location = new System.Drawing.Point(171, 26);
            this.Date_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Date_textBox.Name = "Date_textBox";
            this.Date_textBox.Size = new System.Drawing.Size(132, 22);
            this.Date_textBox.TabIndex = 17;
            this.Date_textBox.TextChanged += new System.EventHandler(this.Date_textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Payed sum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date&Time of Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student ID";
            // 
            // PaymentContent
            // 
            this.PaymentContent.Enabled = false;
            this.PaymentContent.ForeColor = System.Drawing.SystemColors.Window;
            this.PaymentContent.FormattingEnabled = true;
            this.PaymentContent.ItemHeight = 16;
            this.PaymentContent.Location = new System.Drawing.Point(27, 182);
            this.PaymentContent.Margin = new System.Windows.Forms.Padding(4);
            this.PaymentContent.Name = "PaymentContent";
            this.PaymentContent.ScrollAlwaysVisible = true;
            this.PaymentContent.Size = new System.Drawing.Size(631, 276);
            this.PaymentContent.TabIndex = 10;
            this.PaymentContent.SelectedIndexChanged += new System.EventHandler(this.PaymentContent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by:";
            // 
            // SearchFilters_ComboBox
            // 
            this.SearchFilters_ComboBox.AllowDrop = true;
            this.SearchFilters_ComboBox.FormattingEnabled = true;
            this.SearchFilters_ComboBox.Items.AddRange(new object[] {
            "Show all",
            "Month",
            "Student ID"});
            this.SearchFilters_ComboBox.Location = new System.Drawing.Point(740, 26);
            this.SearchFilters_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchFilters_ComboBox.Name = "SearchFilters_ComboBox";
            this.SearchFilters_ComboBox.Size = new System.Drawing.Size(160, 24);
            this.SearchFilters_ComboBox.TabIndex = 13;
            this.SearchFilters_ComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchFilters_ComboBox_SelectedIndexChanged);
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(800, 128);
            this.Search_button.Margin = new System.Windows.Forms.Padding(4);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(100, 28);
            this.Search_button.TabIndex = 14;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(740, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(638, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID/MonthNo.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Show all",
            "Rent",
            "Penalty"});
            this.comboBox1.Location = new System.Drawing.Point(740, 87);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(648, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Search by:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LastDay_textBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Time_textBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.PaymentContent);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Date_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SearchFilters_ComboBox);
            this.groupBox1.Controls.Add(this.Search_button);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 495);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rents";
            // 
            // AdminRents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 524);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminRents";
            this.Text = "Rents";
            this.Load += new System.EventHandler(this.Rents_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox PaymentContent;
        private System.Windows.Forms.TextBox LastDay_textBox;
        private System.Windows.Forms.TextBox Time_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Date_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.ComboBox SearchFilters_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
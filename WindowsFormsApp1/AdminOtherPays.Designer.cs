namespace StudentDormApp
{
    partial class AdminOtherPays
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeOfPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastDay_textBox = new System.Windows.Forms.TextBox();
            this.Time_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Date_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchFilters_ComboBox = new System.Windows.Forms.ComboBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Controls.Add(this.LastDay_textBox);
            this.groupBox1.Controls.Add(this.Time_textBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Date_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SearchFilters_ComboBox);
            this.groupBox1.Controls.Add(this.Search_button);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 461);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rents";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.PaymentID,
            this.Status,
            this.DateTimeOfPayment,
            this.PaymentType,
            this.PaidSum});
            this.dataGridView.Location = new System.Drawing.Point(16, 203);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(726, 246);
            this.dataGridView.TabIndex = 31;
            // 
            // StudentID
            // 
            this.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.DefaultCellStyle = dataGridViewCellStyle1;
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.MinimumWidth = 4;
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 90;
            // 
            // PaymentID
            // 
            this.PaymentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentID.DefaultCellStyle = dataGridViewCellStyle2;
            this.PaymentID.HeaderText = "Payment ID";
            this.PaymentID.MinimumWidth = 6;
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.Width = 97;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 73;
            // 
            // DateTimeOfPayment
            // 
            this.DateTimeOfPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DateTimeOfPayment.HeaderText = "Date&Time of Payment";
            this.DateTimeOfPayment.MinimumWidth = 6;
            this.DateTimeOfPayment.Name = "DateTimeOfPayment";
            this.DateTimeOfPayment.Width = 112;
            // 
            // PaymentType
            // 
            this.PaymentType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PaymentType.HeaderText = "Payment type";
            this.PaymentType.MinimumWidth = 6;
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.Width = 109;
            // 
            // PaidSum
            // 
            this.PaidSum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PaidSum.HeaderText = "Paid sum";
            this.PaidSum.MinimumWidth = 6;
            this.PaidSum.Name = "PaidSum";
            this.PaidSum.Width = 85;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Type:";
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
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Show all",
            "Football Pitch",
            "Swimming Pool"});
            this.comboBox1.Location = new System.Drawing.Point(550, 85);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 25;
            // 
            // Date_textBox
            // 
            this.Date_textBox.Location = new System.Drawing.Point(171, 26);
            this.Date_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Date_textBox.Name = "Date_textBox";
            this.Date_textBox.Size = new System.Drawing.Size(132, 22);
            this.Date_textBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 32);
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
            this.SearchFilters_ComboBox.Location = new System.Drawing.Point(550, 24);
            this.SearchFilters_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchFilters_ComboBox.Name = "SearchFilters_ComboBox";
            this.SearchFilters_ComboBox.Size = new System.Drawing.Size(160, 24);
            this.SearchFilters_ComboBox.TabIndex = 13;
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(610, 126);
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
            this.textBox1.Location = new System.Drawing.Point(550, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID/MonthNo.";
            // 
            // AdminOtherPays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminOtherPays";
            this.Text = "AdminOtherPays";
            this.Load += new System.EventHandler(this.AdminOtherPays_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeOfPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidSum;
        private System.Windows.Forms.TextBox LastDay_textBox;
        private System.Windows.Forms.TextBox Time_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Date_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SearchFilters_ComboBox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}
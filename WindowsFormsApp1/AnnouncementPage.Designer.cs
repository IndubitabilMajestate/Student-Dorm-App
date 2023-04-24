namespace WindowsFormsApp1
{
    partial class AnnouncementPage
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
            this.AnnouncementPage_CAT_tb = new System.Windows.Forms.TextBox();
            this.AnnouncementPage_CAD_dp = new System.Windows.Forms.DateTimePicker();
            this.AnnouncementPage_CA_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AnnouncementPage_SA_lb = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AnnouncementPage_CAC_tb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnnouncementPage_CAT_tb
            // 
            this.AnnouncementPage_CAT_tb.Location = new System.Drawing.Point(53, 27);
            this.AnnouncementPage_CAT_tb.Name = "AnnouncementPage_CAT_tb";
            this.AnnouncementPage_CAT_tb.Size = new System.Drawing.Size(200, 20);
            this.AnnouncementPage_CAT_tb.TabIndex = 0;
            // 
            // AnnouncementPage_CAD_dp
            // 
            this.AnnouncementPage_CAD_dp.Location = new System.Drawing.Point(53, 228);
            this.AnnouncementPage_CAD_dp.Name = "AnnouncementPage_CAD_dp";
            this.AnnouncementPage_CAD_dp.Size = new System.Drawing.Size(200, 20);
            this.AnnouncementPage_CAD_dp.TabIndex = 1;
            this.AnnouncementPage_CAD_dp.Value = new System.DateTime(2023, 4, 21, 12, 28, 50, 0);
            // 
            // AnnouncementPage_CA_btn
            // 
            this.AnnouncementPage_CA_btn.Location = new System.Drawing.Point(95, 263);
            this.AnnouncementPage_CA_btn.Name = "AnnouncementPage_CA_btn";
            this.AnnouncementPage_CA_btn.Size = new System.Drawing.Size(126, 23);
            this.AnnouncementPage_CA_btn.TabIndex = 2;
            this.AnnouncementPage_CA_btn.Text = "Create Announcement";
            this.AnnouncementPage_CA_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AnnouncementPage_CAC_tb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.AnnouncementPage_CAT_tb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AnnouncementPage_CAD_dp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AnnouncementPage_CA_btn);
            this.panel1.Location = new System.Drawing.Point(297, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 312);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Create Announcements";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AnnouncementPage_SA_lb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 311);
            this.panel2.TabIndex = 4;
            // 
            // AnnouncementPage_SA_lb
            // 
            this.AnnouncementPage_SA_lb.FormattingEnabled = true;
            this.AnnouncementPage_SA_lb.Location = new System.Drawing.Point(3, 16);
            this.AnnouncementPage_SA_lb.Name = "AnnouncementPage_SA_lb";
            this.AnnouncementPage_SA_lb.Size = new System.Drawing.Size(273, 290);
            this.AnnouncementPage_SA_lb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Create Announcements";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Content";
            // 
            // AnnouncementPage_CAC_tb
            // 
            this.AnnouncementPage_CAC_tb.Location = new System.Drawing.Point(53, 53);
            this.AnnouncementPage_CAC_tb.Multiline = true;
            this.AnnouncementPage_CAC_tb.Name = "AnnouncementPage_CAC_tb";
            this.AnnouncementPage_CAC_tb.Size = new System.Drawing.Size(200, 169);
            this.AnnouncementPage_CAC_tb.TabIndex = 0;
            // 
            // AnnouncementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 336);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(589, 375);
            this.MinimumSize = new System.Drawing.Size(589, 375);
            this.Name = "AnnouncementPage";
            this.Text = "AnnouncementPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox AnnouncementPage_CAT_tb;
        private System.Windows.Forms.DateTimePicker AnnouncementPage_CAD_dp;
        private System.Windows.Forms.Button AnnouncementPage_CA_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox AnnouncementPage_SA_lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AnnouncementPage_CAC_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
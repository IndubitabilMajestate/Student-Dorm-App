namespace WindowsFormsApp1
{
    partial class FrontPage_Form
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
            this.FrontPage_UN_tb = new System.Windows.Forms.TextBox();
            this.FrontPage_PW_tb = new System.Windows.Forms.TextBox();
            this.FrontPage_UN_lbl = new System.Windows.Forms.Label();
            this.FrontPage_PW_lbl = new System.Windows.Forms.Label();
            this.FrontPage_ST_rbtn = new System.Windows.Forms.RadioButton();
            this.FrontPage_AD_rbtn = new System.Windows.Forms.RadioButton();
            this.FrontPage_LI_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FrontPage_UN_tb
            // 
            this.FrontPage_UN_tb.Location = new System.Drawing.Point(77, 12);
            this.FrontPage_UN_tb.Name = "FrontPage_UN_tb";
            this.FrontPage_UN_tb.Size = new System.Drawing.Size(128, 22);
            this.FrontPage_UN_tb.TabIndex = 0;
            // 
            // FrontPage_PW_tb
            // 
            this.FrontPage_PW_tb.Location = new System.Drawing.Point(77, 38);
            this.FrontPage_PW_tb.Name = "FrontPage_PW_tb";
            this.FrontPage_PW_tb.Size = new System.Drawing.Size(128, 22);
            this.FrontPage_PW_tb.TabIndex = 0;
            // 
            // FrontPage_UN_lbl
            // 
            this.FrontPage_UN_lbl.AutoSize = true;
            this.FrontPage_UN_lbl.Location = new System.Drawing.Point(1, 15);
            this.FrontPage_UN_lbl.Name = "FrontPage_UN_lbl";
            this.FrontPage_UN_lbl.Size = new System.Drawing.Size(73, 16);
            this.FrontPage_UN_lbl.TabIndex = 1;
            this.FrontPage_UN_lbl.Text = "Username:";
            // 
            // FrontPage_PW_lbl
            // 
            this.FrontPage_PW_lbl.AutoSize = true;
            this.FrontPage_PW_lbl.Location = new System.Drawing.Point(1, 44);
            this.FrontPage_PW_lbl.Name = "FrontPage_PW_lbl";
            this.FrontPage_PW_lbl.Size = new System.Drawing.Size(70, 16);
            this.FrontPage_PW_lbl.TabIndex = 1;
            this.FrontPage_PW_lbl.Text = "Password:";
            // 
            // FrontPage_ST_rbtn
            // 
            this.FrontPage_ST_rbtn.AutoSize = true;
            this.FrontPage_ST_rbtn.Location = new System.Drawing.Point(77, 64);
            this.FrontPage_ST_rbtn.Name = "FrontPage_ST_rbtn";
            this.FrontPage_ST_rbtn.Size = new System.Drawing.Size(70, 20);
            this.FrontPage_ST_rbtn.TabIndex = 2;
            this.FrontPage_ST_rbtn.TabStop = true;
            this.FrontPage_ST_rbtn.Text = "Student";
            this.FrontPage_ST_rbtn.UseVisualStyleBackColor = true;
            // 
            // FrontPage_AD_rbtn
            // 
            this.FrontPage_AD_rbtn.AutoSize = true;
            this.FrontPage_AD_rbtn.Location = new System.Drawing.Point(151, 64);
            this.FrontPage_AD_rbtn.Name = "FrontPage_AD_rbtn";
            this.FrontPage_AD_rbtn.Size = new System.Drawing.Size(63, 20);
            this.FrontPage_AD_rbtn.TabIndex = 2;
            this.FrontPage_AD_rbtn.TabStop = true;
            this.FrontPage_AD_rbtn.Text = "Admin";
            this.FrontPage_AD_rbtn.UseVisualStyleBackColor = true;
            // 
            // FrontPage_LI_btn
            // 
            this.FrontPage_LI_btn.Location = new System.Drawing.Point(211, 12);
            this.FrontPage_LI_btn.Name = "FrontPage_LI_btn";
            this.FrontPage_LI_btn.Size = new System.Drawing.Size(52, 69);
            this.FrontPage_LI_btn.TabIndex = 3;
            this.FrontPage_LI_btn.Text = "Log In";
            this.FrontPage_LI_btn.UseVisualStyleBackColor = true;
            this.FrontPage_LI_btn.Click += new System.EventHandler(this.FrontPage_LI_btn_Click);
            // 
            // FrontPage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 93);
            this.Controls.Add(this.FrontPage_LI_btn);
            this.Controls.Add(this.FrontPage_AD_rbtn);
            this.Controls.Add(this.FrontPage_ST_rbtn);
            this.Controls.Add(this.FrontPage_PW_lbl);
            this.Controls.Add(this.FrontPage_UN_lbl);
            this.Controls.Add(this.FrontPage_PW_tb);
            this.Controls.Add(this.FrontPage_UN_tb);
            this.Name = "FrontPage_Form";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FrontPage_UN_tb;
        private System.Windows.Forms.TextBox FrontPage_PW_tb;
        private System.Windows.Forms.Label FrontPage_UN_lbl;
        private System.Windows.Forms.Label FrontPage_PW_lbl;
        private System.Windows.Forms.RadioButton FrontPage_ST_rbtn;
        private System.Windows.Forms.RadioButton FrontPage_AD_rbtn;
        private System.Windows.Forms.Button FrontPage_LI_btn;
    }
}


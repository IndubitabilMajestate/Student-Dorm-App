namespace WindowsFormsApp1
{
    partial class ComplaintsPage
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ComplaintsPage_CC_lb = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ComplaintsPage_CC_lb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 265);
            this.panel2.TabIndex = 5;
            // 
            // ComplaintsPage_CC_lb
            // 
            this.ComplaintsPage_CC_lb.FormattingEnabled = true;
            this.ComplaintsPage_CC_lb.Location = new System.Drawing.Point(6, 16);
            this.ComplaintsPage_CC_lb.Name = "ComplaintsPage_CC_lb";
            this.ComplaintsPage_CC_lb.Size = new System.Drawing.Size(369, 238);
            this.ComplaintsPage_CC_lb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Complaints";
            // 
            // ComplaintsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 289);
            this.Controls.Add(this.panel2);
            this.Name = "ComplaintsPage";
            this.Text = "ComplaintsPage";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox ComplaintsPage_CC_lb;
        private System.Windows.Forms.Label label3;
    }
}
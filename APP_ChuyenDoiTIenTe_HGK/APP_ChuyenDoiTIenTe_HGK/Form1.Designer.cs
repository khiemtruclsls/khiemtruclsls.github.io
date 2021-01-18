namespace APP_ChuyenDoiTIenTe_HGK
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
            this.btnchuyendoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUSD = new System.Windows.Forms.TextBox();
            this.txtJpy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnchuyendoi
            // 
            this.btnchuyendoi.Location = new System.Drawing.Point(309, -1);
            this.btnchuyendoi.Name = "btnchuyendoi";
            this.btnchuyendoi.Size = new System.Drawing.Size(75, 23);
            this.btnchuyendoi.TabIndex = 0;
            this.btnchuyendoi.Text = "Quy đổi";
            this.btnchuyendoi.UseVisualStyleBackColor = true;
            this.btnchuyendoi.Click += new System.EventHandler(this.btnchuyendoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "USD";
            // 
            // txtUSD
            // 
            this.txtUSD.Location = new System.Drawing.Point(104, 2);
            this.txtUSD.Name = "txtUSD";
            this.txtUSD.ReadOnly = true;
            this.txtUSD.Size = new System.Drawing.Size(174, 20);
            this.txtUSD.TabIndex = 4;
            this.txtUSD.Text = "1 $";
            // 
            // txtJpy
            // 
            this.txtJpy.Location = new System.Drawing.Point(104, 28);
            this.txtJpy.Name = "txtJpy";
            this.txtJpy.ReadOnly = true;
            this.txtJpy.Size = new System.Drawing.Size(174, 20);
            this.txtJpy.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "JPY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 89);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJpy);
            this.Controls.Add(this.txtUSD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnchuyendoi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnchuyendoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUSD;
        private System.Windows.Forms.TextBox txtJpy;
        private System.Windows.Forms.Label label3;
    }
}


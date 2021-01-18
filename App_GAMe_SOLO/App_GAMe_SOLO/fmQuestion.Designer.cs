namespace App_GAMe_SOLO
{
    partial class fmQuestion
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.txtCauHoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckTrue = new System.Windows.Forms.CheckBox();
            this.ckFalse = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Question :";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(120, 44);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 2;
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.Location = new System.Drawing.Point(120, 74);
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(100, 20);
            this.txtCauHoi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Câu Hỏi : ";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(120, 100);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(100, 20);
            this.txtDiem.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Điểm :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "đáp án :";
            // 
            // ckTrue
            // 
            this.ckTrue.AutoSize = true;
            this.ckTrue.Location = new System.Drawing.Point(120, 132);
            this.ckTrue.Name = "ckTrue";
            this.ckTrue.Size = new System.Drawing.Size(48, 17);
            this.ckTrue.TabIndex = 8;
            this.ckTrue.Text = "True";
            this.ckTrue.UseVisualStyleBackColor = true;
            // 
            // ckFalse
            // 
            this.ckFalse.AutoSize = true;
            this.ckFalse.Location = new System.Drawing.Point(120, 155);
            this.ckFalse.Name = "ckFalse";
            this.ckFalse.Size = new System.Drawing.Size(51, 17);
            this.ckFalse.TabIndex = 9;
            this.ckFalse.Text = "False";
            this.ckFalse.UseVisualStyleBackColor = true;
            // 
            // fmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 260);
            this.Controls.Add(this.ckFalse);
            this.Controls.Add(this.ckTrue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCauHoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "fmQuestion";
            this.Text = "fmQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox txtCauHoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckTrue;
        private System.Windows.Forms.CheckBox ckFalse;
    }
}
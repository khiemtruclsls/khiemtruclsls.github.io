namespace Simulation_Freaking_math_HGK
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDung = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSai = new System.Windows.Forms.Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.btnKetqua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "FreaKing Math";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 53);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1 + 2 = 3";
            // 
            // btnDung
            // 
            this.btnDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDung.Location = new System.Drawing.Point(100, 164);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(131, 48);
            this.btnDung.TabIndex = 2;
            this.btnDung.Text = "O";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnChonKetQua);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSai
            // 
            this.btnSai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSai.Location = new System.Drawing.Point(272, 164);
            this.btnSai.Name = "btnSai";
            this.btnSai.Size = new System.Drawing.Size(131, 48);
            this.btnSai.TabIndex = 3;
            this.btnSai.Text = "X";
            this.btnSai.UseVisualStyleBackColor = true;
            this.btnSai.Click += new System.EventHandler(this.btnChonKetQua);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(12, 277);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(163, 46);
            this.lbltime.TabIndex = 4;
            this.lbltime.Text = "Time : 3";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark.Location = new System.Drawing.Point(301, 277);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(163, 46);
            this.lblMark.TabIndex = 5;
            this.lblMark.Text = "Mark : 0";
            // 
            // btnKetqua
            // 
            this.btnKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetqua.Location = new System.Drawing.Point(195, 277);
            this.btnKetqua.Name = "btnKetqua";
            this.btnKetqua.Size = new System.Drawing.Size(91, 42);
            this.btnKetqua.TabIndex = 6;
            this.btnKetqua.Text = "Kết quả";
            this.btnKetqua.UseVisualStyleBackColor = true;
            this.btnKetqua.Click += new System.EventHandler(this.btnKetqua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 331);
            this.Controls.Add(this.btnKetqua);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btnSai);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSai;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Button btnKetqua;
    }
}


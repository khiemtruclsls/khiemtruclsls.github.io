namespace Fighting_Game_HGK
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
            this.pbHP1 = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbHP2 = new System.Windows.Forms.ProgressBar();
            this.pbPower1 = new System.Windows.Forms.ProgressBar();
            this.pbPower2 = new System.Windows.Forms.ProgressBar();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiChiếnThắngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbHP1
            // 
            this.pbHP1.Location = new System.Drawing.Point(20, 99);
            this.pbHP1.Maximum = 1000;
            this.pbHP1.Name = "pbHP1";
            this.pbHP1.Size = new System.Drawing.Size(172, 42);
            this.pbHP1.TabIndex = 0;
            this.pbHP1.Value = 1000;
            this.pbHP1.Click += new System.EventHandler(this.pbHP1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // pbHP2
            // 
            this.pbHP2.Location = new System.Drawing.Point(297, 99);
            this.pbHP2.Maximum = 1000;
            this.pbHP2.Name = "pbHP2";
            this.pbHP2.Size = new System.Drawing.Size(172, 42);
            this.pbHP2.TabIndex = 1;
            this.pbHP2.Value = 1000;
            this.pbHP2.Click += new System.EventHandler(this.pbHP2_Click);
            // 
            // pbPower1
            // 
            this.pbPower1.Location = new System.Drawing.Point(20, 157);
            this.pbPower1.Name = "pbPower1";
            this.pbPower1.Size = new System.Drawing.Size(172, 42);
            this.pbPower1.TabIndex = 2;
            this.pbPower1.Click += new System.EventHandler(this.pbPower1_Click);
            // 
            // pbPower2
            // 
            this.pbPower2.Location = new System.Drawing.Point(297, 157);
            this.pbPower2.Name = "pbPower2";
            this.pbPower2.Size = new System.Drawing.Size(172, 42);
            this.pbPower2.TabIndex = 3;
            this.pbPower2.Click += new System.EventHandler(this.pbPower2_Click);
            // 
            // pBox1
            // 
            this.pBox1.Location = new System.Drawing.Point(65, 208);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(170, 208);
            this.pBox1.TabIndex = 4;
            this.pBox1.TabStop = false;
            // 
            // pBox2
            // 
            this.pBox2.Location = new System.Drawing.Point(241, 248);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(173, 208);
            this.pBox2.TabIndex = 5;
            this.pBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Người Chơi 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Người chơi 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lực đánh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lực đánh ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitGameToolStripMenuItem,
            this.ngườiChiếnThắngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.exitGameToolStripMenuItem.Text = "@Exit Game";
            // 
            // ngườiChiếnThắngToolStripMenuItem
            // 
            this.ngườiChiếnThắngToolStripMenuItem.Name = "ngườiChiếnThắngToolStripMenuItem";
            this.ngườiChiếnThắngToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.ngườiChiếnThắngToolStripMenuItem.Text = "&Người Chiến Thắng";
            this.ngườiChiếnThắngToolStripMenuItem.Click += new System.EventHandler(this.ngườiChiếnThắngToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Game Vui 88";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(495, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBox2);
            this.Controls.Add(this.pBox1);
            this.Controls.Add(this.pbPower2);
            this.Controls.Add(this.pbPower1);
            this.Controls.Add(this.pbHP2);
            this.Controls.Add(this.pbHP1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbHP1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ProgressBar pbHP2;
        private System.Windows.Forms.ProgressBar pbPower1;
        private System.Windows.Forms.ProgressBar pbPower2;
        private System.Windows.Forms.PictureBox pBox2;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiChiếnThắngToolStripMenuItem;
        private System.Windows.Forms.Label label5;
    }
}


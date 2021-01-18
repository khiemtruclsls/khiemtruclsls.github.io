namespace Form_QLCV_BY_HGK
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoidung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbtt = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCongViec = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.themMoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpngaytao = new System.Windows.Forms.DateTimePicker();
            this.dtpngayhoanthanh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtidcv = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lọcCôngViệcTheoTrạngTháiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_Cv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayhoanthanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongViec)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày tạo công việc :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nội dung công việc :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dự kiến ngày hoàn thành :";
            // 
            // txtNoidung
            // 
            this.txtNoidung.Location = new System.Drawing.Point(199, 161);
            this.txtNoidung.Multiline = true;
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(299, 99);
            this.txtNoidung.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trạng thái  :";
            // 
            // cbtt
            // 
            this.cbtt.FormattingEnabled = true;
            this.cbtt.Location = new System.Drawing.Point(199, 108);
            this.cbtt.Name = "cbtt";
            this.cbtt.Size = new System.Drawing.Size(121, 21);
            this.cbtt.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(504, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(199, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 27);
            this.label5.TabIndex = 19;
            this.label5.Text = "Quản lý công việc ";
            // 
            // dgvCongViec
            // 
            this.dgvCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Cv,
            this.ngaytao,
            this.ID_tt,
            this.ngayhoanthanh,
            this.Noidung});
            this.dgvCongViec.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCongViec.Location = new System.Drawing.Point(33, 266);
            this.dgvCongViec.Name = "dgvCongViec";
            this.dgvCongViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongViec.Size = new System.Drawing.Size(542, 290);
            this.dgvCongViec.TabIndex = 20;
            this.dgvCongViec.SelectionChanged += new System.EventHandler(this.dgvCongViec_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themMoiToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 70);
            // 
            // themMoiToolStripMenuItem
            // 
            this.themMoiToolStripMenuItem.Name = "themMoiToolStripMenuItem";
            this.themMoiToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.themMoiToolStripMenuItem.Text = "Them Moi";
            this.themMoiToolStripMenuItem.Click += new System.EventHandler(this.themMoiToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // dtpngaytao
            // 
            this.dtpngaytao.Location = new System.Drawing.Point(199, 82);
            this.dtpngaytao.Name = "dtpngaytao";
            this.dtpngaytao.Size = new System.Drawing.Size(200, 20);
            this.dtpngaytao.TabIndex = 23;
            // 
            // dtpngayhoanthanh
            // 
            this.dtpngayhoanthanh.Location = new System.Drawing.Point(199, 135);
            this.dtpngayhoanthanh.Name = "dtpngayhoanthanh";
            this.dtpngayhoanthanh.Size = new System.Drawing.Size(200, 20);
            this.dtpngayhoanthanh.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "ID Công việc : ";
            // 
            // txtidcv
            // 
            this.txtidcv.Location = new System.Drawing.Point(199, 60);
            this.txtidcv.Name = "txtidcv";
            this.txtidcv.ReadOnly = true;
            this.txtidcv.Size = new System.Drawing.Size(100, 20);
            this.txtidcv.TabIndex = 26;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.lọcCôngViệcTheoTrạngTháiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.exitToolStripMenuItem.Text = "&Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lọcCôngViệcTheoTrạngTháiToolStripMenuItem
            // 
            this.lọcCôngViệcTheoTrạngTháiToolStripMenuItem.Name = "lọcCôngViệcTheoTrạngTháiToolStripMenuItem";
            this.lọcCôngViệcTheoTrạngTháiToolStripMenuItem.Size = new System.Drawing.Size(173, 20);
            this.lọcCôngViệcTheoTrạngTháiToolStripMenuItem.Text = "&Lọc công việc theo trạng thái";
            // 
            // ID_Cv
            // 
            this.ID_Cv.DataPropertyName = "ID_Cv";
            this.ID_Cv.HeaderText = "ID Công việc";
            this.ID_Cv.Name = "ID_Cv";
            // 
            // ngaytao
            // 
            this.ngaytao.DataPropertyName = "ngaytao";
            this.ngaytao.HeaderText = "Ngày Tạo Công Việc";
            this.ngaytao.Name = "ngaytao";
            // 
            // ID_tt
            // 
            this.ID_tt.DataPropertyName = "ID_TT";
            this.ID_tt.HeaderText = "ID trạng thái ";
            this.ID_tt.Name = "ID_tt";
            // 
            // ngayhoanthanh
            // 
            this.ngayhoanthanh.DataPropertyName = "ngayhoanthanh";
            this.ngayhoanthanh.HeaderText = "Dự kiến Ngày Hoàn thành ";
            this.ngayhoanthanh.Name = "ngayhoanthanh";
            // 
            // Noidung
            // 
            this.Noidung.DataPropertyName = "Noidung";
            this.Noidung.HeaderText = "Nội Dung Công Việc";
            this.Noidung.Name = "Noidung";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(603, 566);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtidcv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpngayhoanthanh);
            this.Controls.Add(this.dtpngaytao);
            this.Controls.Add(this.dgvCongViec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbtt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNoidung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongViec)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoidung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbtt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCongViec;
        private System.Windows.Forms.DateTimePicker dtpngaytao;
        private System.Windows.Forms.DateTimePicker dtpngayhoanthanh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtidcv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themMoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lọcCôngViệcTheoTrạngTháiToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayhoanthanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Noidung;
    }
}


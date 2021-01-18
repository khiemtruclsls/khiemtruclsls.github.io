namespace Form_ET_dathang_HGK
{
    partial class Caterogy
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtIDcate = new System.Windows.Forms.TextBox();
            this.dgvCate = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.themMoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refsehToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNameCate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCate)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Management";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(208, 72);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtIDcate
            // 
            this.txtIDcate.Enabled = false;
            this.txtIDcate.Location = new System.Drawing.Point(76, 46);
            this.txtIDcate.Name = "txtIDcate";
            this.txtIDcate.ReadOnly = true;
            this.txtIDcate.Size = new System.Drawing.Size(82, 20);
            this.txtIDcate.TabIndex = 2;
            // 
            // dgvCate
            // 
            this.dgvCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCate.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCate.Location = new System.Drawing.Point(15, 98);
            this.dgvCate.Name = "dgvCate";
            this.dgvCate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCate.Size = new System.Drawing.Size(268, 150);
            this.dgvCate.TabIndex = 3;
            this.dgvCate.SelectionChanged += new System.EventHandler(this.dgvCate_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themMoiToolStripMenuItem,
            this.xoaToolStripMenuItem,
            this.refsehToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            this.contextMenuStrip1.Text = "Quick Menu";
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // themMoiToolStripMenuItem
            // 
            this.themMoiToolStripMenuItem.Name = "themMoiToolStripMenuItem";
            this.themMoiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.themMoiToolStripMenuItem.Text = "ThemMoi";
            this.themMoiToolStripMenuItem.Click += new System.EventHandler(this.themMoiToolStripMenuItem_Click);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xoaToolStripMenuItem.Text = "Xoa";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xoaToolStripMenuItem_Click);
            // 
            // refsehToolStripMenuItem
            // 
            this.refsehToolStripMenuItem.Name = "refsehToolStripMenuItem";
            this.refsehToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refsehToolStripMenuItem.Text = "Refresh";
            this.refsehToolStripMenuItem.Click += new System.EventHandler(this.refsehToolStripMenuItem_Click);
            // 
            // txtNameCate
            // 
            this.txtNameCate.Location = new System.Drawing.Point(76, 72);
            this.txtNameCate.Name = "txtNameCate";
            this.txtNameCate.Size = new System.Drawing.Size(126, 20);
            this.txtNameCate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID Cate : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name Cate : ";
            // 
            // Caterogy
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(296, 256);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameCate);
            this.Controls.Add(this.dgvCate);
            this.Controls.Add(this.txtIDcate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Caterogy";
            this.Text = "Category _ HGK";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCate)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtIDcate;
        private System.Windows.Forms.DataGridView dgvCate;
        private System.Windows.Forms.TextBox txtNameCate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themMoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refsehToolStripMenuItem;
    }
}
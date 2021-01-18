namespace Form_QLHH_LamQuen_Voi_Business_common_By_HGK
{
    partial class Form_Category
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
            this.txtNameCate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.txtNameID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCateList = new System.Windows.Forms.DataGridView();
            this.BtnReload = new System.Windows.Forms.Button();
            this.btnDetele = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCateList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNameCate
            // 
            this.txtNameCate.Location = new System.Drawing.Point(110, 102);
            this.txtNameCate.Name = "txtNameCate";
            this.txtNameCate.Size = new System.Drawing.Size(128, 20);
            this.txtNameCate.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name Cate : ";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(104, 30);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(289, 31);
            this.Category.TabIndex = 8;
            this.Category.Text = "Category Management";
            // 
            // txtNameID
            // 
            this.txtNameID.Location = new System.Drawing.Point(110, 76);
            this.txtNameID.Name = "txtNameID";
            this.txtNameID.ReadOnly = true;
            this.txtNameID.Size = new System.Drawing.Size(128, 20);
            this.txtNameID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cate ID : ";
            // 
            // dgvCateList
            // 
            this.dgvCateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCateList.Location = new System.Drawing.Point(23, 128);
            this.dgvCateList.Name = "dgvCateList";
            this.dgvCateList.Size = new System.Drawing.Size(377, 141);
            this.dgvCateList.TabIndex = 14;
            this.dgvCateList.SelectionChanged += new System.EventHandler(this.dgvCateList_SelectionChanged);
            // 
            // BtnReload
            // 
            this.BtnReload.Location = new System.Drawing.Point(325, 73);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(75, 23);
            this.BtnReload.TabIndex = 18;
            this.BtnReload.Text = "Reload";
            this.BtnReload.UseVisualStyleBackColor = true;
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // btnDetele
            // 
            this.btnDetele.Location = new System.Drawing.Point(325, 99);
            this.btnDetele.Name = "btnDetele";
            this.btnDetele.Size = new System.Drawing.Size(75, 23);
            this.btnDetele.TabIndex = 17;
            this.btnDetele.Text = "Delete";
            this.btnDetele.UseVisualStyleBackColor = true;
            this.btnDetele.Click += new System.EventHandler(this.btnDetele_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(244, 99);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(244, 73);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(412, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(412, 280);
            this.Controls.Add(this.BtnReload);
            this.Controls.Add(this.btnDetele);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvCateList);
            this.Controls.Add(this.txtNameCate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.txtNameID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Category";
            this.Text = "Form_Category";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCateList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameCate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.TextBox txtNameID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCateList;
        private System.Windows.Forms.Button BtnReload;
        private System.Windows.Forms.Button btnDetele;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
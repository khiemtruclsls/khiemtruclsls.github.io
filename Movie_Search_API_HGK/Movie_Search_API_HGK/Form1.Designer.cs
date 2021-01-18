namespace Movie_Search_API_HGK
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvMovieList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtReleased = new System.Windows.Forms.TextBox();
            this.txtRuntime = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtActors = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbltrangthaitim = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Movie";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(202, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(339, 30);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Location = new System.Drawing.Point(547, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvMovieList
            // 
            this.dgvMovieList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovieList.Location = new System.Drawing.Point(3, 61);
            this.dgvMovieList.Name = "dgvMovieList";
            this.dgvMovieList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovieList.Size = new System.Drawing.Size(652, 177);
            this.dgvMovieList.TabIndex = 3;
            this.dgvMovieList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovieList_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPlot);
            this.groupBox1.Controls.Add(this.txtLanguage);
            this.groupBox1.Controls.Add(this.txtActors);
            this.groupBox1.Controls.Add(this.txtDirector);
            this.groupBox1.Controls.Add(this.txtGenre);
            this.groupBox1.Controls.Add(this.txtRuntime);
            this.groupBox1.Controls.Add(this.txtReleased);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.pbPoster);
            this.groupBox1.Location = new System.Drawing.Point(3, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(922, 335);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // pbPoster
            // 
            this.pbPoster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPoster.Location = new System.Drawing.Point(6, 10);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(278, 319);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoster.TabIndex = 0;
            this.pbPoster.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(304, 10);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(580, 23);
            this.txtTitle.TabIndex = 2;
            // 
            // txtReleased
            // 
            this.txtReleased.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReleased.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtReleased.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReleased.Location = new System.Drawing.Point(304, 46);
            this.txtReleased.Name = "txtReleased";
            this.txtReleased.Size = new System.Drawing.Size(226, 23);
            this.txtReleased.TabIndex = 3;
            // 
            // txtRuntime
            // 
            this.txtRuntime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRuntime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRuntime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRuntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuntime.Location = new System.Drawing.Point(658, 46);
            this.txtRuntime.Name = "txtRuntime";
            this.txtRuntime.Size = new System.Drawing.Size(226, 23);
            this.txtRuntime.TabIndex = 4;
            // 
            // txtGenre
            // 
            this.txtGenre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGenre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(304, 82);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(226, 23);
            this.txtGenre.TabIndex = 5;
            // 
            // txtDirector
            // 
            this.txtDirector.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDirector.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDirector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirector.Location = new System.Drawing.Point(658, 82);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(226, 23);
            this.txtDirector.TabIndex = 6;
            // 
            // txtActors
            // 
            this.txtActors.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtActors.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtActors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActors.Location = new System.Drawing.Point(304, 118);
            this.txtActors.Name = "txtActors";
            this.txtActors.Size = new System.Drawing.Size(226, 23);
            this.txtActors.TabIndex = 7;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLanguage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLanguage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanguage.Location = new System.Drawing.Point(658, 118);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(226, 23);
            this.txtLanguage.TabIndex = 8;
            // 
            // txtPlot
            // 
            this.txtPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPlot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlot.Location = new System.Drawing.Point(303, 154);
            this.txtPlot.Multiline = true;
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.ReadOnly = true;
            this.txtPlot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPlot.Size = new System.Drawing.Size(613, 175);
            this.txtPlot.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbltrangthaitim});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(937, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbltrangthaitim
            // 
            this.lbltrangthaitim.Name = "lbltrangthaitim";
            this.lbltrangthaitim.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(937, 598);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMovieList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvMovieList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.TextBox txtRuntime;
        private System.Windows.Forms.TextBox txtReleased;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.TextBox txtActors;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbltrangthaitim;
    }
}


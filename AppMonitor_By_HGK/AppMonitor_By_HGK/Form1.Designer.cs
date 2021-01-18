namespace AppMonitor_By_HGK
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
            this.btnMonitor = new System.Windows.Forms.Button();
            this.dgvProcessMonitor = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnSaveJson = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessMonitor)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(15, 27);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(75, 23);
            this.btnMonitor.TabIndex = 0;
            this.btnMonitor.Text = "Start Monitor";
            this.btnMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // dgvProcessMonitor
            // 
            this.dgvProcessMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcessMonitor.Location = new System.Drawing.Point(12, 56);
            this.dgvProcessMonitor.Name = "dgvProcessMonitor";
            this.dgvProcessMonitor.Size = new System.Drawing.Size(395, 231);
            this.dgvProcessMonitor.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblstatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(419, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnSaveJson
            // 
            this.btnSaveJson.Location = new System.Drawing.Point(177, 27);
            this.btnSaveJson.Name = "btnSaveJson";
            this.btnSaveJson.Size = new System.Drawing.Size(75, 23);
            this.btnSaveJson.TabIndex = 3;
            this.btnSaveJson.Text = "Save Json";
            this.btnSaveJson.UseVisualStyleBackColor = true;
            this.btnSaveJson.Click += new System.EventHandler(this.btnSaveJson_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(96, 27);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblstatus.LinkColor = System.Drawing.Color.Linen;
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(86, 17);
            this.lblstatus.Text = "NOT RUNNING";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(419, 322);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSaveJson);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvProcessMonitor);
            this.Controls.Add(this.btnMonitor);
            this.Name = "Form1";
            this.Text = "Application Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessMonitor)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.DataGridView dgvProcessMonitor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnSaveJson;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ToolStripStatusLabel lblstatus;
    }
}


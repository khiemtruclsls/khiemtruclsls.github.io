namespace Game_Trac_Nghiem
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
            this.txtxID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbFalse = new System.Windows.Forms.CheckBox();
            this.cbTrue = new System.Windows.Forms.CheckBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScores = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvQuestion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // txtxID
            // 
            this.txtxID.Location = new System.Drawing.Point(110, 40);
            this.txtxID.Name = "txtxID";
            this.txtxID.ReadOnly = true;
            this.txtxID.Size = new System.Drawing.Size(100, 20);
            this.txtxID.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(110, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbFalse
            // 
            this.cbFalse.AutoSize = true;
            this.cbFalse.Location = new System.Drawing.Point(110, 150);
            this.cbFalse.Name = "cbFalse";
            this.cbFalse.Size = new System.Drawing.Size(51, 17);
            this.cbFalse.TabIndex = 3;
            this.cbFalse.Text = "False";
            this.cbFalse.UseVisualStyleBackColor = true;
            // 
            // cbTrue
            // 
            this.cbTrue.AutoSize = true;
            this.cbTrue.Location = new System.Drawing.Point(184, 151);
            this.cbTrue.Name = "cbTrue";
            this.cbTrue.Size = new System.Drawing.Size(48, 17);
            this.cbTrue.TabIndex = 4;
            this.cbTrue.Text = "True";
            this.cbTrue.UseVisualStyleBackColor = true;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(110, 76);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(122, 33);
            this.txtQuestion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Question";
            // 
            // txtScores
            // 
            this.txtScores.Location = new System.Drawing.Point(110, 115);
            this.txtScores.Name = "txtScores";
            this.txtScores.Size = new System.Drawing.Size(100, 20);
            this.txtScores.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Scores : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Many_answer :";
            // 
            // dgvQuestion
            // 
            this.dgvQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestion.Location = new System.Drawing.Point(15, 232);
            this.dgvQuestion.Name = "dgvQuestion";
            this.dgvQuestion.Size = new System.Drawing.Size(295, 150);
            this.dgvQuestion.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 417);
            this.Controls.Add(this.dgvQuestion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtScores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTrue);
            this.Controls.Add(this.cbFalse);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtxID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtxID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbFalse;
        private System.Windows.Forms.CheckBox cbTrue;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvQuestion;
    }
}


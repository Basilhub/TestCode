namespace Test
{
    partial class FmFinish
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
            this.lbResults = new System.Windows.Forms.Label();
            this.lbQuestions = new System.Windows.Forms.ListBox();
            this.teResults = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbResults
            // 
            this.lbResults.AutoSize = true;
            this.lbResults.Location = new System.Drawing.Point(12, 9);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(197, 13);
            this.lbResults.TabIndex = 0;
            this.lbResults.Text = "Верный ответ дан на 0 вопросов из 0";
            // 
            // lbQuestions
            // 
            this.lbQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuestions.FormattingEnabled = true;
            this.lbQuestions.Location = new System.Drawing.Point(15, 35);
            this.lbQuestions.Name = "lbQuestions";
            this.lbQuestions.Size = new System.Drawing.Size(574, 199);
            this.lbQuestions.TabIndex = 1;
            this.lbQuestions.Click += new System.EventHandler(this.lbQuestions_Click);
            // 
            // teResults
            // 
            this.teResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.teResults.Location = new System.Drawing.Point(15, 243);
            this.teResults.Multiline = true;
            this.teResults.Name = "teResults";
            this.teResults.Size = new System.Drawing.Size(574, 151);
            this.teResults.TabIndex = 2;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Location = new System.Drawing.Point(514, 400);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Процент верных ответов:";
            // 
            // lbPercent
            // 
            this.lbPercent.AutoSize = true;
            this.lbPercent.Location = new System.Drawing.Point(374, 9);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(21, 13);
            this.lbPercent.TabIndex = 5;
            this.lbPercent.Text = "0%";
            // 
            // FmFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 435);
            this.Controls.Add(this.lbPercent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.teResults);
            this.Controls.Add(this.lbQuestions);
            this.Controls.Add(this.lbResults);
            this.MaximumSize = new System.Drawing.Size(617, 474);
            this.MinimumSize = new System.Drawing.Size(617, 474);
            this.Name = "FmFinish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты теста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbResults;
        private System.Windows.Forms.ListBox lbQuestions;
        private System.Windows.Forms.TextBox teResults;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPercent;
    }
}
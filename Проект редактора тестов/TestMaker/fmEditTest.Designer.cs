namespace TestMaker
{
    partial class fmEditTest
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
            this.btSave = new System.Windows.Forms.Button();
            this.btEditQuestion = new System.Windows.Forms.Button();
            this.btAddQuestion = new System.Windows.Forms.Button();
            this.lbTestQuestions = new System.Windows.Forms.ListBox();
            this.lbQuestionCount = new System.Windows.Forms.Label();
            this.btDeleteTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Location = new System.Drawing.Point(464, 330);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(102, 23);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Сохранить тест";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btEditQuestion
            // 
            this.btEditQuestion.Location = new System.Drawing.Point(120, 330);
            this.btEditQuestion.Name = "btEditQuestion";
            this.btEditQuestion.Size = new System.Drawing.Size(102, 23);
            this.btEditQuestion.TabIndex = 3;
            this.btEditQuestion.Text = "Редактировать...";
            this.btEditQuestion.UseVisualStyleBackColor = true;
            this.btEditQuestion.Click += new System.EventHandler(this.btEditQuestion_Click);
            // 
            // btAddQuestion
            // 
            this.btAddQuestion.Location = new System.Drawing.Point(12, 330);
            this.btAddQuestion.Name = "btAddQuestion";
            this.btAddQuestion.Size = new System.Drawing.Size(102, 23);
            this.btAddQuestion.TabIndex = 2;
            this.btAddQuestion.Text = "Добавить...";
            this.btAddQuestion.UseVisualStyleBackColor = true;
            this.btAddQuestion.Click += new System.EventHandler(this.btAddQuestion_Click);
            // 
            // lbTestQuestions
            // 
            this.lbTestQuestions.FormattingEnabled = true;
            this.lbTestQuestions.Location = new System.Drawing.Point(12, 25);
            this.lbTestQuestions.Name = "lbTestQuestions";
            this.lbTestQuestions.Size = new System.Drawing.Size(554, 290);
            this.lbTestQuestions.TabIndex = 1;
            // 
            // lbQuestionCount
            // 
            this.lbQuestionCount.AutoSize = true;
            this.lbQuestionCount.Location = new System.Drawing.Point(12, 9);
            this.lbQuestionCount.Name = "lbQuestionCount";
            this.lbQuestionCount.Size = new System.Drawing.Size(129, 13);
            this.lbQuestionCount.TabIndex = 4;
            this.lbQuestionCount.Text = "Количество вопросов: 0";
            // 
            // btDeleteTest
            // 
            this.btDeleteTest.Location = new System.Drawing.Point(228, 330);
            this.btDeleteTest.Name = "btDeleteTest";
            this.btDeleteTest.Size = new System.Drawing.Size(102, 23);
            this.btDeleteTest.TabIndex = 4;
            this.btDeleteTest.Text = "Удалить ";
            this.btDeleteTest.UseVisualStyleBackColor = true;
            this.btDeleteTest.Click += new System.EventHandler(this.btDeleteTest_Click);
            // 
            // fmEditTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 365);
            this.Controls.Add(this.lbQuestionCount);
            this.Controls.Add(this.lbTestQuestions);
            this.Controls.Add(this.btAddQuestion);
            this.Controls.Add(this.btDeleteTest);
            this.Controls.Add(this.btEditQuestion);
            this.Controls.Add(this.btSave);
            this.Name = "fmEditTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmEditTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btEditQuestion;
        private System.Windows.Forms.Button btAddQuestion;
        private System.Windows.Forms.ListBox lbTestQuestions;
        private System.Windows.Forms.Label lbQuestionCount;
        private System.Windows.Forms.Button btDeleteTest;
    }
}
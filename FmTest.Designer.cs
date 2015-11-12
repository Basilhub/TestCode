namespace Test
{
    partial class FmTest
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
            this.lbQuestionCounter = new System.Windows.Forms.Label();
            this.gbQuestion = new System.Windows.Forms.GroupBox();
            this.teQuestion = new System.Windows.Forms.TextBox();
            this.rbAnswerFour = new System.Windows.Forms.RadioButton();
            this.rbAnswerThree = new System.Windows.Forms.RadioButton();
            this.rbAnswerTwo = new System.Windows.Forms.RadioButton();
            this.rbNoAnswer = new System.Windows.Forms.RadioButton();
            this.rbAnswerOne = new System.Windows.Forms.RadioButton();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.btPrevious = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btFinish = new System.Windows.Forms.Button();
            this.gbQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество вопросов:";
            // 
            // lbQuestionCounter
            // 
            this.lbQuestionCounter.AutoSize = true;
            this.lbQuestionCounter.Location = new System.Drawing.Point(127, 10);
            this.lbQuestionCounter.Name = "lbQuestionCounter";
            this.lbQuestionCounter.Size = new System.Drawing.Size(13, 13);
            this.lbQuestionCounter.TabIndex = 0;
            this.lbQuestionCounter.Text = "0";
            // 
            // gbQuestion
            // 
            this.gbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbQuestion.Controls.Add(this.teQuestion);
            this.gbQuestion.Controls.Add(this.rbAnswerFour);
            this.gbQuestion.Controls.Add(this.rbAnswerThree);
            this.gbQuestion.Controls.Add(this.rbAnswerTwo);
            this.gbQuestion.Controls.Add(this.rbNoAnswer);
            this.gbQuestion.Controls.Add(this.rbAnswerOne);
            this.gbQuestion.Controls.Add(this.lbQuestion);
            this.gbQuestion.Location = new System.Drawing.Point(12, 26);
            this.gbQuestion.Name = "gbQuestion";
            this.gbQuestion.Size = new System.Drawing.Size(445, 232);
            this.gbQuestion.TabIndex = 1;
            this.gbQuestion.TabStop = false;
            this.gbQuestion.Text = "Вопрос №1";
            // 
            // teQuestion
            // 
            this.teQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.teQuestion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teQuestion.Location = new System.Drawing.Point(25, 41);
            this.teQuestion.Multiline = true;
            this.teQuestion.Name = "teQuestion";
            this.teQuestion.ReadOnly = true;
            this.teQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.teQuestion.Size = new System.Drawing.Size(398, 83);
            this.teQuestion.TabIndex = 0;
            // 
            // rbAnswerFour
            // 
            this.rbAnswerFour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbAnswerFour.AutoSize = true;
            this.rbAnswerFour.Location = new System.Drawing.Point(25, 200);
            this.rbAnswerFour.Name = "rbAnswerFour";
            this.rbAnswerFour.Size = new System.Drawing.Size(64, 17);
            this.rbAnswerFour.TabIndex = 4;
            this.rbAnswerFour.Text = "Ответ 4";
            this.rbAnswerFour.UseVisualStyleBackColor = true;
            this.rbAnswerFour.Click += new System.EventHandler(this.rbAnswerFour_Click);
            // 
            // rbAnswerThree
            // 
            this.rbAnswerThree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbAnswerThree.AutoSize = true;
            this.rbAnswerThree.Location = new System.Drawing.Point(25, 177);
            this.rbAnswerThree.Name = "rbAnswerThree";
            this.rbAnswerThree.Size = new System.Drawing.Size(64, 17);
            this.rbAnswerThree.TabIndex = 3;
            this.rbAnswerThree.Text = "Ответ 3";
            this.rbAnswerThree.UseVisualStyleBackColor = true;
            this.rbAnswerThree.Click += new System.EventHandler(this.rbAnswerThree_Click);
            // 
            // rbAnswerTwo
            // 
            this.rbAnswerTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbAnswerTwo.AutoSize = true;
            this.rbAnswerTwo.Location = new System.Drawing.Point(25, 153);
            this.rbAnswerTwo.Name = "rbAnswerTwo";
            this.rbAnswerTwo.Size = new System.Drawing.Size(64, 17);
            this.rbAnswerTwo.TabIndex = 2;
            this.rbAnswerTwo.Text = "Ответ 2";
            this.rbAnswerTwo.UseVisualStyleBackColor = true;
            this.rbAnswerTwo.Click += new System.EventHandler(this.rbAnswerTwo_Click);
            // 
            // rbNoAnswer
            // 
            this.rbNoAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbNoAnswer.AutoSize = true;
            this.rbNoAnswer.Checked = true;
            this.rbNoAnswer.Enabled = false;
            this.rbNoAnswer.Location = new System.Drawing.Point(95, 130);
            this.rbNoAnswer.Name = "rbNoAnswer";
            this.rbNoAnswer.Size = new System.Drawing.Size(81, 17);
            this.rbNoAnswer.TabIndex = 1;
            this.rbNoAnswer.TabStop = true;
            this.rbNoAnswer.Text = "Нет ответа";
            this.rbNoAnswer.UseVisualStyleBackColor = true;
            this.rbNoAnswer.Visible = false;
            // 
            // rbAnswerOne
            // 
            this.rbAnswerOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbAnswerOne.AutoSize = true;
            this.rbAnswerOne.Location = new System.Drawing.Point(25, 130);
            this.rbAnswerOne.Name = "rbAnswerOne";
            this.rbAnswerOne.Size = new System.Drawing.Size(64, 17);
            this.rbAnswerOne.TabIndex = 1;
            this.rbAnswerOne.Text = "Ответ 1";
            this.rbAnswerOne.UseVisualStyleBackColor = true;
            this.rbAnswerOne.Click += new System.EventHandler(this.rbAnswerOne_Click);
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Location = new System.Drawing.Point(22, 24);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(88, 13);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.Text = "Формулировка:";
            // 
            // btPrevious
            // 
            this.btPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPrevious.Location = new System.Drawing.Point(11, 264);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(75, 23);
            this.btPrevious.TabIndex = 5;
            this.btPrevious.Text = "<<";
            this.btPrevious.UseVisualStyleBackColor = true;
            this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
            // 
            // btNext
            // 
            this.btNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btNext.Location = new System.Drawing.Point(92, 264);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 6;
            this.btNext.Text = ">>";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btFinish
            // 
            this.btFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFinish.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btFinish.Location = new System.Drawing.Point(353, 264);
            this.btFinish.Name = "btFinish";
            this.btFinish.Size = new System.Drawing.Size(104, 23);
            this.btFinish.TabIndex = 8;
            this.btFinish.Text = "Закончить тест...";
            this.btFinish.UseVisualStyleBackColor = true;
            this.btFinish.Click += new System.EventHandler(this.btFinish_Click);
            // 
            // FmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 299);
            this.Controls.Add(this.btFinish);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrevious);
            this.Controls.Add(this.gbQuestion);
            this.Controls.Add(this.lbQuestionCounter);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(485, 338);
            this.Name = "FmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест";
            this.gbQuestion.ResumeLayout(false);
            this.gbQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbQuestionCounter;
        private System.Windows.Forms.GroupBox gbQuestion;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.TextBox teQuestion;
        private System.Windows.Forms.RadioButton rbAnswerFour;
        private System.Windows.Forms.RadioButton rbAnswerThree;
        private System.Windows.Forms.RadioButton rbAnswerTwo;
        private System.Windows.Forms.RadioButton rbAnswerOne;
        private System.Windows.Forms.Button btPrevious;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btFinish;
        private System.Windows.Forms.RadioButton rbNoAnswer;
    }
}
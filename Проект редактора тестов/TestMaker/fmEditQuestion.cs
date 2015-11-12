using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TestMaker.DAL;
using TestTool.DAL;

namespace TestMaker
{
    public partial class fmEditQuestion : Form
    {
        public fmEditQuestion(Question item)
        {
            InitializeComponent();
            LoadForm(item);
        }

        private Question Item { get; set; }

        public static bool Execute(Question item)
        {
            using (var fm = new fmEditQuestion(item))
            {
                fm.ShowDialog();
                if (fm.DialogResult == DialogResult.OK)
                    return true;
                return false;
            }
        }

        private void Save()
        {
            Item.QuestionString = tbQuestion.Text.Trim();
            if (Item.Answers == null)
                Item.Answers = new List<string>();

            Item.Answers.Clear();
            Item.Answers.Add(tbAnswerOne.Text.Trim());
            Item.Answers.Add(tbAnswerTwo.Text.Trim());
            Item.Answers.Add(tbAnswerThree.Text.Trim());
            Item.Answers.Add(tbAnswerFour.Text.Trim());

            if (rbOne.Checked)
            {
                Item.TrueAnswer = tbAnswerOne.Text.Trim();
            }

            if (rbTwo.Checked)
            {
                Item.TrueAnswer = tbAnswerTwo.Text.Trim();
            }

            if (rbThree.Checked)
            {
                Item.TrueAnswer = tbAnswerThree.Text.Trim();
            }

            if (rbFour.Checked)
            {
                Item.TrueAnswer = tbAnswerFour.Text.Trim();
            }
        }

        private void LoadForm(Question item)
        {
            if (item.QuestionString == null)
            {
                this.Text = "Новый Вопрос";
                Item = item;
            }
            else
            {
                this.Text = "Редактирование вопроса";
                Item = item;
                tbQuestion.Text = Item.QuestionString;
                tbAnswerOne.Text = Item.Answers[0];
                tbAnswerTwo.Text = Item.Answers[1];
                tbAnswerThree.Text = Item.Answers[2];
                tbAnswerFour.Text = Item.Answers[3];
                int trueAnswer = -1;
                for (var i = 0; i <= 3; i++)
                {
                    if (Item.Answers[i] == Item.TrueAnswer)
                    {
                        trueAnswer = i;
                        break;
                    }
                }

                if (trueAnswer == -1)
                {
                    MessageBox.Show("Вопрос --" + item.QuestionString + " -- не имеет правильного варианта ответа.",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    switch (trueAnswer)
                    {
                        case 0:
                            rbOne.Checked = true;
                            break;
                        case 1:
                            rbTwo.Checked = true;
                            break;
                        case 2:
                            rbThree.Checked = true;
                            break;
                        case 3:
                            rbFour.Checked = true;
                            break;
                    }
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}

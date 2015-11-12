using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Windows.Forms;
using Test.DAL;
using TestMaker.DAL;

namespace Test
{
    public partial class FmTest : Form
    {
        public FmTest(List<Question> item)
        {
            InitializeComponent();
            LoadForm(item);
        }

        private List<TestItem> Item { get; set; }

        private int CurrentQuestion { get; set; }

        public static bool Execute(List<Question> item)
        {
            using (var fm = new FmTest(item))
            {
                fm.ShowDialog();
                if (fm.DialogResult == DialogResult.OK)
                    return true;
                return false;
            }
        }

        private void LoadForm(List<Question> item)
        {
            try
            {
                if (item.Count == 0)
                {
                    MessageBox.Show("В данном тесте нет ни одного вопроса",
                          "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                var testList = new List<TestItem>();
                foreach (var question in item)
                {
                    testList.Add(new TestItem { Number = testList.Count + 1, Question = question });
                }
                Item = testList;
                lbQuestionCounter.Text = Item.Count.ToString();
                PlaceQuestion(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                       "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlaceQuestion(int number)
        {
            try
            {
                var item = Item[number - 1];
                gbQuestion.Text = "Вопрос №" + number;
                teQuestion.Text = item.Question.QuestionString;
                rbAnswerOne.Text = item.Question.Answers[0];
                rbAnswerTwo.Text = item.Question.Answers[1];
                rbAnswerThree.Text = item.Question.Answers[2];
                rbAnswerFour.Text = item.Question.Answers[3];
                if (!item.IsAnswered)
                {
                    rbNoAnswer.Checked = true;
                }
                else
                {
                    int answer = -1;
                    for (var i = 0; i <= 3; i++)
                    {
                        if (Item[number - 1].Question.Answers[i] == Item[number - 1].Answer)
                        {
                            answer = i;
                            break;
                        }
                    }

                    switch (answer)
                    {
                        case 0:
                            rbAnswerOne.Checked = true;
                            break;
                        case 1:
                            rbAnswerTwo.Checked = true;
                            break;
                        case 2:
                            rbAnswerThree.Checked = true;
                            break;
                        case 3:
                            rbAnswerFour.Checked = true;
                            break;
                    }
                }

                CurrentQuestion = number;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                       "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentQuestion == 1)
            {
                PlaceQuestion(Item.Count);
                return;
            }

            PlaceQuestion(CurrentQuestion - 1);
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (Item.Count == CurrentQuestion)
                {
                    PlaceQuestion(1);
                    return;
                }

                PlaceQuestion(CurrentQuestion + 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                       "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbAnswerOne_Click(object sender, EventArgs e)
        {
            try
            {
                Item[CurrentQuestion - 1].IsAnswered = true;
                Item[CurrentQuestion - 1].Answer = Item[CurrentQuestion - 1].Question.Answers[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                       "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbAnswerTwo_Click(object sender, EventArgs e)
        {
            try
            {
                Item[CurrentQuestion - 1].IsAnswered = true;
                Item[CurrentQuestion - 1].Answer = Item[CurrentQuestion - 1].Question.Answers[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                       "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbAnswerThree_Click(object sender, EventArgs e)
        {
            try
            {
                Item[CurrentQuestion - 1].IsAnswered = true;
                Item[CurrentQuestion - 1].Answer = Item[CurrentQuestion - 1].Question.Answers[2];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                       "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbAnswerFour_Click(object sender, EventArgs e)
        {
            try
            {
                Item[CurrentQuestion - 1].IsAnswered = true;
                Item[CurrentQuestion - 1].Answer = Item[CurrentQuestion - 1].Question.Answers[3];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                       "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btFinish_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                FmFinish.Execute(Item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                       "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

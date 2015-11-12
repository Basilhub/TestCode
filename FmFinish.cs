using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Test.DAL;

namespace Test
{
    public partial class FmFinish : Form
    {
        public FmFinish(List<TestItem> item)
        {
            InitializeComponent();
            LoadForm(item);
        }

        private List<TestItem> Item { get; set; }

        public static bool Execute(List<TestItem> item)
        {
            using (var fm = new FmFinish(item))
            {
                fm.ShowDialog();
                if (fm.DialogResult == DialogResult.OK)
                    return true;
                return false;
            }
        }

        private void LoadForm(List<TestItem> item)
        {
            Item = item;
            lbQuestions.DataSource = item;
            lbQuestions.DisplayMember = "Result";
            var trueResults = item.Where(test => test.IsTrueAnswered);
            lbResults.Text = "Верный ответ дан на " + trueResults.Count() + " вопросов из " + Item.Count;
            lbPercent.Text = ((trueResults.Count() * 100) / item.Count).ToString() + "%";
        }

        private void lbQuestions_Click(object sender, EventArgs e)
        {
            if (lbQuestions.SelectedItem == null)
            {
                MessageBox.Show("Не выбран вопрос.",
                            "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var item = lbQuestions.SelectedItem as TestItem;
            if (item.IsAnswered)
            {
                teResults.Text = "Ваш ответ:" + Environment.NewLine + item.Answer + Environment.NewLine + Environment.NewLine +
                             "Правильный ответ:" + Environment.NewLine + item.Question.TrueAnswer;
            }
            else
            {
                teResults.Text = "Вы не дали ответа на этот вопрос." + Environment.NewLine + Environment.NewLine + "Правильный ответ:" + Environment.NewLine + item.Question.TrueAnswer;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

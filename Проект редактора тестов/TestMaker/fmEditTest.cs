using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using TestMaker.DAL;

namespace TestMaker
{
    public partial class fmEditTest : Form
    {
        public fmEditTest(List<Question> item)
        {
            InitializeComponent();
            LoadForm(item);
        }

        private List<Question> Item { get; set; }

        public static bool Execute(List<Question> item)
        {
            using (var fm = new fmEditTest(item))
            {
                fm.ShowDialog();
                if (fm.DialogResult == DialogResult.OK)
                    return true;
                return false;
            }
        }

        private void LoadForm(List<Question> item)
        {
            if (item.Count == 0)
            {
                this.Text = "Новый Тест";
                Item = item;
                lbTestQuestions.DataSource = Item.ToList();
                lbTestQuestions.DisplayMember = "QuestionString";
            }
            else
            {
                this.Text = "Редактирование Теста";
                Item = item;
                lbTestQuestions.DataSource = Item.ToList();
                lbTestQuestions.DisplayMember = "QuestionString";
                lbQuestionCount.Text = "Количество вопросов: " + Item.Count;
            }
        }


        private void btAddQuestion_Click(object sender, EventArgs e)
        {
            var item = new Question();
            if (fmEditQuestion.Execute(item))
                Item.Add(item);
            UpdateInterface();
        }

        private void btEditQuestion_Click(object sender, EventArgs e)
        {
            if (lbTestQuestions.SelectedItem == null)
            {
                MessageBox.Show("Не выбран вопрос.",
                            "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var item = lbTestQuestions.SelectedItem as Question;
            fmEditQuestion.Execute(item);
            UpdateInterface();
        }

        private void btDeleteTest_Click(object sender, EventArgs e)
        {
            if (lbTestQuestions.SelectedItem == null)
            {
                MessageBox.Show("Не выбран вопрос.",
                            "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Item.Remove(lbTestQuestions.SelectedItem as Question);
            UpdateInterface();
        }

        private void UpdateInterface()
        {
            lbTestQuestions.DataSource = Item.ToList();
            lbTestQuestions.DisplayMember = "QuestionString";
            lbQuestionCount.Text = "Количество вопросов: " + Item.Count;
        }
    }
}

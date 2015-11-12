using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestMaker.DAL;

namespace Test
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
        }

        private void btStartTest_Click(object sender, EventArgs e)
        {
            try
            {
                var testPath = new OpenFileDialog { Filter = "xml files (*.xml)|*.xml" };
                testPath.ShowDialog();
                var list = XmlWorker.ReadQuestions(testPath.FileName);

                //var test = new List<Question>();
                //test.Add(new Question { Answers = new List<string> { "1", "2", "3", "4" }, QuestionString = "Вопрос № 1", TrueAnswer = "1" });
                //test.Add(new Question { Answers = new List<string> { "5", "6", "7", "8" }, QuestionString = "Вопрос № 2", TrueAnswer = "8" });
                //test.Add(new Question { Answers = new List<string> { "9", "10", "11", "12" }, QuestionString = "Вопрос № 3", TrueAnswer = "10" });

                FmTest.Execute(list.Items);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                       "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btOpenTestMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("material.docx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                       "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

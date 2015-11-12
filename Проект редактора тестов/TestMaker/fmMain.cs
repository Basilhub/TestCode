using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TestMaker.DAL;
using TestTool.DAL;

namespace TestMaker
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void btAddTest_Click(object sender, EventArgs e)
        {
            var item = new List<Question>();
            if (fmEditTest.Execute(item))
            {
                var xmlList = new QuestionXmlList { Items = item };
                XmlWorker.WriteQuestions(xmlList, Directory.GetCurrentDirectory() + @"\quest.xml");
            }
        }

        private void btEditTest_Click(object sender, EventArgs e)
        {
            var path = new OpenFileDialog();
            path.ShowDialog();
            var xmlitems = XmlWorker.ReadQuestions(path.FileName);
            List<Question> item = xmlitems.Items;
            if (fmEditTest.Execute(item))
            {
                var xmlList = new QuestionXmlList { Items = item };
                XmlWorker.WriteQuestions(xmlList, path.FileName);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

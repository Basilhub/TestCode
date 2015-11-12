using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestMaker.DAL;

namespace Test.DAL
{
    public class TestItem
    {
        public int Number { get; set; }

        public Question Question { get; set; }

        public bool IsAnswered { get; set; }

        public bool IsTrueAnswered
        {
            get
            {
                return Answer == Question.TrueAnswer;
            }
        }

        public string Answer { get; set; }

        public string Result
        {
            get
            {
                if (!IsAnswered)
                {
                    return "--Нет ответа--   " + "№" + this.Number + ". " + Answer;
                }


                if (Question.TrueAnswer == Answer)
                {
                    return "--Правильно--   " + "№" + this.Number + ". " + Answer;
                }
                else
                {
                    return "--Неправильно--   " + "№" + this.Number + ". " + Answer;
                }
            }
        }
    }
}

using System.Collections.Generic;

namespace TestMaker.DAL
{
    /// <summary>
    /// Вопрос
    /// </summary>
    public class Question
    {
        /// <summary>
        /// Формулировка вопроса
        /// </summary>
        public string QuestionString { get; set; }
        
        /// <summary>
        /// Варианты ответа
        /// </summary>
        public List<string> Answers { get; set; }

        /// <summary>
        /// Правильный ответ
        /// </summary>
        public string TrueAnswer { get; set; }
    }
}

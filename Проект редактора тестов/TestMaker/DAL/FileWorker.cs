using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TestTool.DAL;

namespace TestMaker.DAL
{
    /// <summary>
    /// Класс - хост методов для работы с простыми файлами
    /// </summary>
    public class FileWorker
    {
        /// <summary>
        /// Читает вопросы из файла
        /// </summary>
        /// <returns> Расположение файла </returns>
        public static List<Question> ReadQuestions(string address)
        {
            try
            {
                // Список вопросов
                var list = new List<Question>();

                // Читаем весь файл
                var file = File.ReadAllText(address);

                // Бьем его на массив вопросов
                var questions = file.Split('@');

                // Перебираем каждый вопрос, кроме последнего
                for (var i = 0; i < questions.Length - 1; i++)
                {
                    var questionElements = questions[i].Split('|');
                    var question = new Question
                    {
                        QuestionString = questionElements[0],
                        TrueAnswer = questionElements[1],
                        Answers = questionElements[2].Split('$').ToList()
                    };
                    list.Add(question);
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка чтения вопросов из файла", ex);
            }
        }

        /// <summary>
        /// Пишет вопросы в файл 
        /// </summary>
        /// <param name="list"> Список вопросов </param>
        /// <param name="address"> Расположение файла </param>
        public static void WriteQuestions(List<Question> list, string address)
        {
            try
            {
                // Если файл существует, удаляем
                if (File.Exists(address))
                {
                    File.Delete(address);
                }

                // Пишем каждый вопрос в файл
                foreach (var question in list)
                {
                    // Cначала формулировку
                    File.AppendAllText(address, question.QuestionString + @"|");

                    // Правильный вариант ответа
                    File.AppendAllText(address, question.TrueAnswer + @"|");

                    // Варианты ответов, предварительно записав в строку. Подебажить если что удобно.
                    var answers = string.Empty;
                    for (int i = 0; i < question.Answers.Count; i++)
                    {
                        answers += question.Answers[i];
                        if (i != question.Answers.Count - 1)
                            answers += "$";
                    }
                    File.AppendAllText(address, answers);

                    // Знак конца вопроса
                    File.AppendAllText(address, @"@");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка записи вопросов в файл", ex);
            }
        }
    }
}

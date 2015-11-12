using System;
using System.IO;
using System.Xml.Serialization;
using TestTool.DAL;

namespace TestMaker.DAL
{
    /// <summary>
    /// Класс - хост методов для работы с файлами формата XML
    /// </summary>
    public class XmlWorker
    {
        /// <summary>
        /// Читает вопросы из файла
        /// </summary>
        /// <returns> Список вопросов </returns>
        public static QuestionXmlList ReadQuestions(string address)
        {
            try
            {
                // Список для сохранения результата
                QuestionXmlList list;

                // Передаем в конструктор форматтера тип класса
                var formatter = new XmlSerializer(typeof(QuestionXmlList));

                // Десериализуем объекты
                using (var fileStream = new FileStream(address, FileMode.OpenOrCreate))
                {
                    list = formatter.Deserialize(fileStream) as QuestionXmlList;
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
        public static void WriteQuestions(QuestionXmlList list, string address)
        {
            // Если файл существует, удаляем
            if (File.Exists(address))
            {
                File.Delete(address);
            }

            try
            {
                // Передаем в конструктор форматтера тип класса
                var formatter = new XmlSerializer(typeof(QuestionXmlList));

                // Получаем поток, куда будем записывать сериализованный объект
                using (var fileStream = new FileStream(address, FileMode.OpenOrCreate))
                {
                    // Записываем каждый объект в списке
                    formatter.Serialize(fileStream, list);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка записи вопросов в файл", ex);
            }
        }
    }
}


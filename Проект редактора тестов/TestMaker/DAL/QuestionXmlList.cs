using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using TestMaker.DAL;

namespace TestTool.DAL
{
    /// <summary>
    /// Обертка над списком вопросов для десериализации xml 
    /// </summary>
    [XmlRoot("QuestionXmlList")]
    public class QuestionXmlList
    {
        // Список вопросов
        [XmlElement("Items")]
        public List<Question> Items { get; set; }

        /// <summary>
        /// Конструктор. 
        /// </summary>
        public QuestionXmlList()
        {
            Items = new List<Question>();
        }

    }
}

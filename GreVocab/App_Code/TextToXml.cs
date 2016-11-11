using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace GreVocab
{
    public class TextToXml
    {
        private List<string> words = new List<string>();
        private List<string> definitions = new List<string>();
        private List<string> answers = new List<string>();
        private List<string> choiceA = new List<string>();
        private List<string> choiceB = new List<string>();
        private List<string> choiceC = new List<string>();
        private List<string> choiceD = new List<string>();
        private List<MultipleChoiceWords> MultipleChoiceWords;

        public TextToXml()
        {
            this.MultipleChoiceWords = new List<MultipleChoiceWords>()
            {
                new MultipleChoiceWords
                {
                    Word = "Abscond",
                    Definition = "To leave hurriedly and secretly, typically to avoid detection of or arrest for an unlawful action such as theft",
                    Answer = "a",
                    ChoiceA = "To leave hurriedly and secretly, typically to avoid detection of or arrest for an unlawful action such as theft",
                    ChoiceB = "departing from an accepted standard.",
                    ChoiceC = "departing from an accepted standard.",
                    ChoiceD = "departing from an accepted standard."
                },
                new MultipleChoiceWords
                {
                     Word = "Aberrant",
                    Definition = "departing from an accepted standard.",
                    Answer = "b",
                    ChoiceA = "departing from an accepted standard",
                    ChoiceB = "departing from an accepted standard.",
                    ChoiceC = "departing from an accepted standard",
                    ChoiceD = "departing from an accepted standard"
                },

                new MultipleChoiceWords
                {
                     Word = "Alacrity",
                    Definition = "brisk and cheerful readiness.",
                    Answer = "a",
                    ChoiceA = "brisk and cheerful readiness.",
                    ChoiceB = "departing from an accepted standard",
                    ChoiceC = "departing from an accepted standard",
                    ChoiceD = "departing from an accepted standard"
                }
            };
        }

        public void WriteToXml()
        {
            using (XmlWriter writer = XmlWriter.Create("WordList2.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("WordList");



                foreach (MultipleChoiceWords words in this.MultipleChoiceWords) 
                {
                    writer.WriteStartElement("WordItem");

                    writer.WriteElementString("Word", words.Word);
                    writer.WriteElementString("definition", words.Definition);
                    writer.WriteElementString("answer", words.Answer);
                    writer.WriteElementString("a", words.ChoiceA);
                    writer.WriteElementString("b", words.ChoiceB);
                    writer.WriteElementString("c", words.ChoiceC);
                    writer.WriteElementString("d", words.ChoiceD);

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();

                SaveFile(this.MultipleChoiceWords[0]);

            }
        }

        public void SaveFile(MultipleChoiceWords customWordList)
        {
            System.Xml.Serialization.XmlSerializer writer =  new System.Xml.Serialization.XmlSerializer(typeof(MultipleChoiceWords));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//wordList2.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, customWordList);
            file.Close();
        }
    }
}

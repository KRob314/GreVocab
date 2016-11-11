using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GreVocab.App_Code
{
    public class ReadXmlFile
    {
        public void ReadFromWordList(WordList wordList)
        {
            XmlDocument doc = new XmlDocument();
            StringBuilder sb = new StringBuilder();
            doc.Load(@"C:\Users\Kyle\Documents\Visual Studio 2015\Projects\GreVocab\GreVocab\Data\wordList.xml");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                // first node is the url ... have to go to nexted loc node 
                foreach (XmlNode locNode in node)
                {
                    switch (locNode.Name)
                    {
                        case "word":
                            wordList.words.Add(locNode.InnerText);
                            break;

                        case "definition":
                            wordList.definitions.Add(locNode.InnerText);
                            break;

                        case "answer":
                            wordList.answers.Add(locNode.InnerText);
                            break;

                        case "a":
                            wordList.choiceA.Add(locNode.InnerText);
                            break;

                        case "b":
                            wordList.choiceB.Add(locNode.InnerText);
                            break;

                        case "c":
                            wordList.choiceC.Add(locNode.InnerText);
                            break;

                        case "d":
                            wordList.choiceD.Add(locNode.InnerText);
                            break;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreVocab
{
    public class MultipleChoiceWords
    {
        public string Word { get; set; }
        public string Definition { get; set; } 
        public string Answer { get; set; }
        public string ChoiceA { get; set; }
        public string ChoiceB { get; set; }
        public string ChoiceC { get; set; }
        public string ChoiceD { get; set; }

    }

    public class WordList
    {
        public List<string> words = new List<string>();
        public List<string> definitions = new List<string>();
        public List<string> answers = new List<string>();
        public List<string> choiceA = new List<string>();
        public List<string> choiceB = new List<string>();
        public List<string> choiceC = new List<string>();
        public List<string> choiceD = new List<string>();
    }


}

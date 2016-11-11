using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace GreVocab
{
   public class ScoreTracker
    {
        public List<string> words = new List<string>();
        public List<string> definitions = new List<string>();
        public Dictionary<string, string> responses = new Dictionary<string, string>();
        public int LastIndex { get; set; }
        public ScoreTracker scoreTracker { get; set; } 
        public double answeredCorrect { get; set; }
        public double answeredIncorrect { get; set; }
        public double Score { get; set; } 

        public void BuildFile(ScoreTracker st, string pathToSave)
        {
            this.scoreTracker = st;
            string text = Score.ToString();
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}{1}", DateTime.Now, Environment.NewLine);
            sb.Append("Score: ");
            sb.AppendLine(string.Format("{0}/{1}", answeredCorrect, (answeredCorrect + answeredIncorrect)));
            sb.AppendLine(string.Format("AnsweredCorrect: {0}", answeredCorrect));
            sb.AppendLine(string.Format("AnsweredIncorrect: {0}", answeredIncorrect));
            sb.Append("Last index: ");
            sb.AppendLine(LastIndex.ToString());

            foreach (KeyValuePair<string, string> entry in responses)
            {
                sb.AppendFormat("{0} {1}", entry.Key, entry.Value);
                sb.AppendLine("");
            }

            GreFiles newFile = new GreFiles();
            newFile.SaveFile(sb.ToString(), pathToSave);

        }
    }
}

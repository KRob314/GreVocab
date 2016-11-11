using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreVocab.App_Code
{
   public class DefinitionsBank
    {
        public static List<string> GetDefinitions()
        {
            List<string> definitions = new List<string>();

            definitions.Add("fill or cover completely, usually with water");
            definitions.Add("stubborn refusal to compromise or change");
            definitions.Add("difficult to manage or mold");
            definitions.Add("lacking flavor.: 'mugs of insipid coffee'.");
            definitions.Add("ust begun and so not fully formed or developed; rudimentary.: 'a still inchoate democracy'.");
            definitions.Add("worshiping idols");
            definitions.Add("the pursuit of pleasure; sensual self-indulgence..");

            return definitions;
        }
    }
}

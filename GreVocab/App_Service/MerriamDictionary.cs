using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GreVocab.App_Service
{
    public class MerriamDictionary
    {
        private readonly string key_dictionary = "your_key";
        private readonly string key_thesaurus = "your_key";
        private string baseDictionaryURL = "http://www.dictionaryapi.com/api/v1/references/collegiate/xml/"; 


        public string getWord(string word)
        {
            string url = baseDictionaryURL + word + "?key=" + key_dictionary;
            WebRequest request = WebRequest.Create(url);
            ((HttpWebRequest)request).UserAgent = ".NET Framework Example Client";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            //StreamReader reader = new StreamReader(dataStream);
            //string responseFromServer = reader.ReadToEnd();
            XmlDocument xml = makeXML(dataStream);

           string def =  getDefinition(xml);

            response.Close();

            return def;
        }

        private XmlDocument makeXML(Stream dataStream)
        {
            XmlDocument xmlSoapRequest = new XmlDocument();
            using (StreamReader readStream = new StreamReader(dataStream, Encoding.UTF8))
            {
                xmlSoapRequest.Load(readStream);             
            }
            return xmlSoapRequest;
        }

        public string getDefinition(XmlDocument xml)
        {
            string def = "";
            string childNode = "";

            XmlNodeList nodes = xml.DocumentElement.SelectNodes("/entry_list/entry/def");

            foreach (XmlNode node in nodes)
            {
                def += node.SelectSingleNode("dt").InnerText + Environment.NewLine;
            }

            //foreach (XmlNode node in xml.DocumentElement.ChildNodes)
            //{
            //    // first node is the url ... have to go to nexted loc node 
            //    foreach (XmlNode locNode in node)
            //    {
            //        childNode += locNode.Name + Environment.NewLine;
            //        // thereare a couple child nodes here so only take data from node named loc 
            //        if (locNode.Name == "def")
            //        {

            //            if (locNode.ChildNodes[2] != null)
            //            {
            //                def = locNode.ChildNodes[2].InnerText;
            //            }
            //        }
            //    }
            //}

            def = def.Replace(":", "\n");
            return def;
        }

    }
}

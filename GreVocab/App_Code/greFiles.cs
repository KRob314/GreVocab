using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace GreVocab
{
    public class GreFiles
    {
        private string fileName = DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + ".txt";
        private string savePath = @"ToDo";

        public string ScoreStr { get; set; }
        public ScoreTracker scoreTracker { get; set; }

        private string GetLastSavedQuizPath()
        {
            string highestMonthFilePath = "";

            if (Directory.Exists(savePath))
            {
                string[] filesInDir = Directory.GetFiles(savePath);
                int month = 0;
                int highestMonth = 0;

                foreach (var f in filesInDir)
                {
                    string tempFileName = f.Replace("C:\\Users\\Kyle\\Documents\\Visual Studio 2015\\Projects\\GreVocab\\GreVocab\\Scores\\", "");
                    tempFileName = tempFileName.Substring(0, 1);
                    month = Convert.ToInt32(tempFileName);

                    if (month >= highestMonth)
                    {
                        highestMonth = month;
                        highestMonthFilePath = f;
                    }
                }
            }
            return highestMonthFilePath;
        }

        private int RemainingCharCount(string str, int startingIndex)
        {
            int indexToEnd = 0;
            int charCount = str.Length;

            indexToEnd = charCount - startingIndex;

            return indexToEnd;
        }

        public void SaveFile(string textToSave, string pathToSave = "")
        {
            if (pathToSave != "")
                savePath = pathToSave;

            if (Directory.Exists(savePath) == false)
            {
                Directory.CreateDirectory(savePath);
            }

            if (File.Exists(savePath))
            {
                using (StreamWriter sw = File.AppendText(savePath + fileName))
                {
                    sw.WriteLineAsync(textToSave);
                }
            }
            else
            {
                File.WriteAllText(savePath + "\\" + fileName, textToSave);
            }
        }

        public void ResumeLastQuiz()
        {
            int counter = 0;
            string line;
            scoreTracker = new ScoreTracker();

            StreamReader sr = new System.IO.StreamReader(GetLastSavedQuizPath());

            while ((line = sr.ReadLine()) != null)
            {
                try
                {
                    if (line.Contains("Last index:"))
                    {
                        scoreTracker.LastIndex = Convert.ToInt32(line.Substring(12, RemainingCharCount(line, 12)));
                    }
                    if (line.Contains("Score:"))
                    {
                        this.ScoreStr = line.Substring(7, RemainingCharCount(line, 7));
                        int correct = Convert.ToInt32(ScoreStr.Split('/')[0]);
                        int total = Convert.ToInt32(ScoreStr.Split('/')[1]);
                        scoreTracker.Score = (double)(correct / total);
                        scoreTracker.answeredCorrect = correct;
                    }

                    if (line.Contains("AnsweredCorrect: "))
                    {
                        string correct = line.Substring(17, RemainingCharCount(line, 7));
                        scoreTracker.answeredCorrect = Convert.ToInt32(correct);
                    }

                    if (line.Contains("AnsweredIncorrect: "))
                    {
                        string incorrect = line.Substring(19, RemainingCharCount(line, 19));
                        scoreTracker.answeredIncorrect = Convert.ToInt32(incorrect);
                    }


                }
                catch (Exception ex)
                {

                }

                Console.WriteLine(line);
                counter++;
            }


            sr.Close();
        }

        public HashSet<ResponseResult> GetResultsOfQuizes()
        {
            //Hashtable quizResults = new Hashtable();
            HashSet<ResponseResult> quizResults = new HashSet<ResponseResult>();

            if (Directory.Exists(savePath))
            {
                string[] filesInDir = Directory.GetFiles(savePath);
               

                foreach (var f in filesInDir)
                {
                    int counter = 0;
                    string line;

                    StreamReader sr = new System.IO.StreamReader(f);

                    while ((line = sr.ReadLine()) != null)
                    {
                        try
                        {
                            if (line.Contains("Last index:") == false && line.Contains("Score:") == false && line.Contains("AnsweredCorrect: ") == false
                                && line.Contains("AnsweredIncorrect: ") == false && counter > 4 && line.Trim() != "")
                            {
                                //check if actual text 


                                int semiColonIndex = line.IndexOf(":");
                                int charsRemaining = RemainingCharCount(line, semiColonIndex + 1);
                                string word = line.Substring(0, semiColonIndex - 1).Trim();
                                string response = line.Substring(semiColonIndex + 1, charsRemaining);

                                if (string.IsNullOrEmpty(word) == false)
                                {
                                    var q = new ResponseResult()
                                    {
                                        word = word,
                                        answeredCorrect = ToBool(response)
                                    };

                                    quizResults.Add(q);
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            System.Console.Write(ex.Message);
                        }

                        Console.WriteLine(line);
                        counter++;
                    }
                }
            }


            return quizResults;

        }

        private bool ToBool(string str)
        {
            bool result = false;

            if(str.ToLower().Trim() == "correct")
            {
                result = true;
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;
using System.Xml;
using GreVocab.App_Service;
using GreVocab.App_Code;
using System.Collections;

namespace GreVocab
{
    public partial class MainForm : Form
    {
        public SpeechSynthesizer synth = new SpeechSynthesizer();
        private WordList wordList = new WordList();
        private int listIndex = 0;      
        private double answeredCorrect = 0;
        private double answeredIncorrect = 0;
        private double score = 0;
        private bool currentAnswerIncorrect = true;
        ScoreTracker scoreTracker;

        public MainForm()
        {
            InitializeComponent();
            GetList();
            synth.SetOutputToDefaultAudioDevice();

            questionNum.Maximum = wordList.words.Count;

            ReadXML();
            SetMultiChoice();

            questionNum.Maximum = wordList.words.Count;
            lblWord.Text = wordList.words[listIndex];
            lblResult.Text = "";
            lblDefinition.Text = "";
            lblScore.Text = "";
            lblWordLookup.Text = "";

           

            scoreTracker = new ScoreTracker()
            {
                definitions = this.wordList.definitions,
                words = this.wordList.words
            };

            AutoCompleteStringCollection dataSource = new AutoCompleteStringCollection();
            
            foreach (var w in wordList.words)
            {
                dataSource.Add(w);
            }

            toolStripTextBox1.AutoCompleteCustomSource = dataSource;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cbRandom.Checked)
            {
                Random r = new Random();
                listIndex = r.Next(0, Decimal.ToInt32(questionNum.Maximum));
            }
            else
            {
                if (cblMultiChoice.Visible == true)
                {
                    listIndex += 1;
                    SetMultiChoice();
                }
            }


            lblResult.Text = "";
            lblDefinition.Text = "";
            lblWord.Text = wordList.words[listIndex];
            questionNum.Value = listIndex;
            synth.SpeakAsync(lblWord.Text);

            scoreTracker.answeredCorrect = this.answeredCorrect;
            scoreTracker.answeredIncorrect = this.answeredIncorrect;
            scoreTracker.LastIndex = this.listIndex;
            scoreTracker.Score = this.score;

        }

        private void btnShowDefinition_Click(object sender, EventArgs e)
        {
            lblDefinition.Text = wordList.definitions[this.listIndex];

            this.listIndex += 1;
            synth.SpeakAsync(lblDefinition.Text);
        }

        private void cblMultiChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cblMultiChoice.SelectedIndex != -1)
            {
                Boolean isCorrect = IsCorrectAnswer();

                if (isCorrect == true)
                {
                    lblResult.Text = "Correct";
                    lblResult.ForeColor = Color.Green;
                    answeredCorrect += 1;
                    currentAnswerIncorrect = false;
                }
                else
                {
                    lblResult.Text = "Incorrect";
                    lblResult.ForeColor = Color.Red;
                    answeredIncorrect += 1;
                }

                score = ((answeredCorrect) / (answeredIncorrect + answeredCorrect));
                lblScore.Text = string.Format("{0}/{1} = {2}", answeredCorrect, (answeredCorrect + answeredIncorrect), score.ToString("P"));
                currentAnswerIncorrect = true;
            }
        }


        private void btnRepeatWord_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync(wordList.words[listIndex]);
            synth.SpeakAsync(wordList.definitions[listIndex]);
        }

        private void saveQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            folderBrowserDialog1.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;
            folderBrowserDialog1.ShowDialog();
            scoreTracker.BuildFile(this.scoreTracker, folderBrowserDialog1.SelectedPath);
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text != "")
            {
                MerriamDictionary dict = new MerriamDictionary();
               lblWordLookup.Text = dict.getWord(toolStripTextBox1.Text);
            }
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GreFiles savedQuiz = new GreFiles();
            savedQuiz.ResumeLastQuiz();
            listIndex = savedQuiz.scoreTracker.LastIndex;
            //score = savedQuiz.Score;
            lblScore.Text = savedQuiz.ScoreStr;
            scoreTracker.Score = savedQuiz.scoreTracker.Score;
            questionNum.Value = listIndex;
            this.answeredCorrect = savedQuiz.scoreTracker.answeredCorrect;
            this.answeredIncorrect = savedQuiz.scoreTracker.answeredIncorrect;
            this.scoreTracker = savedQuiz.scoreTracker;
            this.score = savedQuiz.scoreTracker.Score;
            SetMultiChoice();
            synth.SpeakAsync(lblWord.Text);
        }

        private void GetList()
        {
            int lineIndex = 1;

            using (StreamReader sr = new StreamReader(@"C:\Users\Kyle\Desktop\GRE Vocab.txt"))
            {
                do
                {
                    string line = sr.ReadLine();

                    if (line.Trim() != "")
                    {
                        if (IsOdd(lineIndex) == true)
                        {
                            wordList.words.Add(line);
                            lineIndex += 1;
                        }
                        else
                        {
                            wordList.definitions.Add(line);
                            lineIndex += 1;
                        }
                    }


                }
                while (!sr.EndOfStream);
            }
        }

        private void ReadXML()
        {
            ReadXmlFile xmlFile = new ReadXmlFile();
            xmlFile.ReadFromWordList(this.wordList);
        }

        private bool IsCorrectAnswer()
        {
            string selectedChoice = "";

            switch (cblMultiChoice.SelectedIndex)
            {
                case 0:
                    selectedChoice = "a";
                    break;

                case 1:
                    selectedChoice = "b";
                    break;

                case 2:
                    selectedChoice = "c";
                    break;

                case 3:
                    selectedChoice = "d";
                    break;
            }

            if (selectedChoice == wordList.answers[listIndex])
            {
                synth.SpeakAsync(wordList.definitions[listIndex]);
                if(scoreTracker.responses.Keys.Contains(wordList.words[listIndex]) == false)
                    scoreTracker.responses.Add(wordList.words[listIndex], ": Correct");
                return true;
            }
            else
            {
                synth.SpeakAsync("Incorrect");
                if(scoreTracker.responses.Keys.Contains(wordList.words[listIndex]) == false)
                    scoreTracker.responses.Add(wordList.words[listIndex], ": Wrong");

                return false;
            }
        }

        private void SetMultiChoice()
        {
            cblMultiChoice.Items.Clear();
            cblMultiChoice.Items.Add(wordList.choiceA[listIndex]);
            cblMultiChoice.Items.Add(wordList.choiceB[listIndex]);
            cblMultiChoice.Items.Add(wordList.choiceC[listIndex]);
            cblMultiChoice.Items.Add(wordList.choiceD[listIndex]);
            lblWord.Text = wordList.words[listIndex];

        }

        private static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }


        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm of = new OptionsForm(this);
            //this.IsMdiContainer = true;
            //of.MdiParent = this;
            of.Show();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuizHistoryForm quizResultsForm = new QuizHistoryForm();
            quizResultsForm.Show();
        }

    }
}

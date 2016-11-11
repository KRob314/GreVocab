using GreVocab.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GreVocab
{
    public partial class QuizHistoryForm : Form
    {
        private HashSet<ResponseResult> correctResponses = new HashSet<ResponseResult>();
        private HashSet<ResponseResult> incorrectResponses = new HashSet<ResponseResult>();
        ChartSeries series_correct = new ChartSeries();
        ChartSeries series_incorrect = new ChartSeries();

        public QuizHistoryForm()
        {
            InitializeComponent();         
            bindUi();
        }

        private void bindUi()
        {
            GreFiles greFiles = new GreFiles();
            HashSet<ResponseResult> quizHistory = greFiles.GetResultsOfQuizes();      
            List<string> wordsSearched = new List<string>();

            foreach (var quiz in quizHistory)
            {
                if (wordsSearched.IndexOf(quiz.word) == -1)
                {
                    int count = quizHistory.Where(q => q.word == quiz.word).Count() + 1;

                    if (quiz.answeredCorrect == true)
                    {
                        this.correctResponses.Add(quiz);
                        series_correct.seriesArray.Add(quiz.word);
                        series_correct.pointsArray.Add(count);
                    }
                    else
                    {
                        this.incorrectResponses.Add(quiz);
                        series_incorrect.seriesArray.Add(quiz.word);
                        series_incorrect.pointsArray.Add(count);
                    }

                    wordsSearched.Add(quiz.word);                  
                }
            }

            lblTotalResponses.Text = "Total Responses: " +  (series_correct.seriesArray.Count + series_incorrect.seriesArray.Count).ToString();
            lblCorrectResponses.Text = "Correct Responses: " + series_correct.seriesArray.Count.ToString();
            lblIncorrectResponses.Text = "Incorrect Responses: " + series_incorrect.seriesArray.Count.ToString();

            bindSeries();
            setChartStyle();  
        }

        private void bindSeries()
        {
            if(series_correct.seriesArray.Count > 0)
            {
                for (int i = 0; i < series_correct.seriesArray.Count; i++)
                {
                    Series series = this.quizHistoryChart_correct.Series.Add(series_correct.seriesArray[i]);
                    series.Points.Add(series_correct.pointsArray[i]);
                }
            }

            if(series_incorrect.seriesArray.Count > 0)
            {
                for (int i = 0; i < series_incorrect.seriesArray.Count; i++)
                {
                    Series series = this.quizHistoryChart_incorrect.Series.Add(series_incorrect.seriesArray[i]);
                    series.Points.Add(series_incorrect.pointsArray[i]);
                }
            }
        }

        private void setChartStyle()
        {
            quizHistoryChart_incorrect.Palette = ChartColorPalette.Pastel;
            quizHistoryChart_correct.Palette = ChartColorPalette.Pastel;

            quizHistoryChart_correct.Titles.Add("Words Answered Correctly");
            quizHistoryChart_incorrect.Titles.Add("Words Answered Incorrectly");
        
        }
    }
}

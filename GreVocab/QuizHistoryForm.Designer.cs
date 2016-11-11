namespace GreVocab
{
    partial class QuizHistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.quizHistoryChart_incorrect = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.quizHistoryChart_correct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTotalResponses = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCorrectResponses = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblIncorrectResponses = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMostIncorrect = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.quizHistoryChart_incorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizHistoryChart_correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quizHistoryChart_incorrect
            // 
            chartArea1.Name = "ChartArea1";
            this.quizHistoryChart_incorrect.ChartAreas.Add(chartArea1);
            this.quizHistoryChart_incorrect.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.quizHistoryChart_incorrect.Legends.Add(legend1);
            this.quizHistoryChart_incorrect.Location = new System.Drawing.Point(0, 0);
            this.quizHistoryChart_incorrect.Name = "quizHistoryChart_incorrect";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.quizHistoryChart_incorrect.Series.Add(series1);
            this.quizHistoryChart_incorrect.Size = new System.Drawing.Size(419, 414);
            this.quizHistoryChart_incorrect.TabIndex = 0;
            this.quizHistoryChart_incorrect.Text = "Quiz History";
            // 
            // quizHistoryChart_correct
            // 
            this.quizHistoryChart_correct.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.quizHistoryChart_correct.ChartAreas.Add(chartArea2);
            this.quizHistoryChart_correct.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.quizHistoryChart_correct.Legends.Add(legend2);
            this.quizHistoryChart_correct.Location = new System.Drawing.Point(0, 0);
            this.quizHistoryChart_correct.Name = "quizHistoryChart_correct";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.quizHistoryChart_correct.Series.Add(series2);
            this.quizHistoryChart_correct.Size = new System.Drawing.Size(464, 414);
            this.quizHistoryChart_correct.TabIndex = 1;
            this.quizHistoryChart_correct.Text = "Quiz History";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.quizHistoryChart_incorrect);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.quizHistoryChart_correct);
            this.splitContainer1.Size = new System.Drawing.Size(887, 414);
            this.splitContainer1.SplitterDistance = 419;
            this.splitContainer1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotalResponses,
            this.lblCorrectResponses,
            this.lblIncorrectResponses,
            this.lblMostIncorrect});
            this.statusStrip1.Location = new System.Drawing.Point(0, 392);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(887, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTotalResponses
            // 
            this.lblTotalResponses.Name = "lblTotalResponses";
            this.lblTotalResponses.Size = new System.Drawing.Size(101, 17);
            this.lblTotalResponses.Text = "lblTotalResponses";
            // 
            // lblCorrectResponses
            // 
            this.lblCorrectResponses.Name = "lblCorrectResponses";
            this.lblCorrectResponses.Size = new System.Drawing.Size(114, 17);
            this.lblCorrectResponses.Text = "lblCorrectResponses";
            // 
            // lblIncorrectResponses
            // 
            this.lblIncorrectResponses.Name = "lblIncorrectResponses";
            this.lblIncorrectResponses.Size = new System.Drawing.Size(122, 17);
            this.lblIncorrectResponses.Text = "lblIncorrectResponses";
            // 
            // lblMostIncorrect
            // 
            this.lblMostIncorrect.Name = "lblMostIncorrect";
            this.lblMostIncorrect.Size = new System.Drawing.Size(94, 17);
            this.lblMostIncorrect.Text = "lblMostIncorrect";
            // 
            // QuizResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 414);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "QuizResultsForm";
            this.Text = "QuizResultsForm";
            ((System.ComponentModel.ISupportInitialize)(this.quizHistoryChart_incorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizHistoryChart_correct)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart quizHistoryChart_incorrect;
        private System.Windows.Forms.DataVisualization.Charting.Chart quizHistoryChart_correct;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalResponses;
        private System.Windows.Forms.ToolStripStatusLabel lblCorrectResponses;
        private System.Windows.Forms.ToolStripStatusLabel lblIncorrectResponses;
        private System.Windows.Forms.ToolStripStatusLabel lblMostIncorrect;
    }
}
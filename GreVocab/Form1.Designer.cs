namespace GreVocab
{
    partial class MainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWordLookup = new System.Windows.Forms.Label();
            this.cblMultiChoice = new System.Windows.Forms.CheckedListBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.btnRepeatWord = new System.Windows.Forms.Button();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.btnShowDefinition = new System.Windows.Forms.Button();
            this.questionNum = new System.Windows.Forms.NumericUpDown();
            this.btnNext = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionNum)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblWordLookup);
            this.panel2.Controls.Add(this.cblMultiChoice);
            this.panel2.Controls.Add(this.btnLookup);
            this.panel2.Controls.Add(this.btnRepeatWord);
            this.panel2.Controls.Add(this.cbRandom);
            this.panel2.Controls.Add(this.btnShowDefinition);
            this.panel2.Controls.Add(this.questionNum);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 341);
            this.panel2.TabIndex = 9;
            // 
            // lblWordLookup
            // 
            this.lblWordLookup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordLookup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWordLookup.Location = new System.Drawing.Point(25, 147);
            this.lblWordLookup.Name = "lblWordLookup";
            this.lblWordLookup.Size = new System.Drawing.Size(407, 157);
            this.lblWordLookup.TabIndex = 15;
            this.lblWordLookup.Text = "label1";
            // 
            // cblMultiChoice
            // 
            this.cblMultiChoice.CheckOnClick = true;
            this.cblMultiChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cblMultiChoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.cblMultiChoice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblMultiChoice.FormattingEnabled = true;
            this.cblMultiChoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cblMultiChoice.IntegralHeight = false;
            this.cblMultiChoice.Location = new System.Drawing.Point(0, 27);
            this.cblMultiChoice.Name = "cblMultiChoice";
            this.cblMultiChoice.Size = new System.Drawing.Size(661, 117);
            this.cblMultiChoice.TabIndex = 3;
            this.cblMultiChoice.ThreeDCheckBoxes = true;
            this.cblMultiChoice.SelectedIndexChanged += new System.EventHandler(this.cblMultiChoice_SelectedIndexChanged);
            // 
            // btnLookup
            // 
            this.btnLookup.Location = new System.Drawing.Point(210, 3);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(105, 23);
            this.btnLookup.TabIndex = 14;
            this.btnLookup.Text = "Lookup Word";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // btnRepeatWord
            // 
            this.btnRepeatWord.Location = new System.Drawing.Point(338, 307);
            this.btnRepeatWord.Name = "btnRepeatWord";
            this.btnRepeatWord.Size = new System.Drawing.Size(111, 23);
            this.btnRepeatWord.TabIndex = 12;
            this.btnRepeatWord.Text = "Repeat Word";
            this.btnRepeatWord.UseVisualStyleBackColor = true;
            this.btnRepeatWord.Click += new System.EventHandler(this.btnRepeatWord_Click);
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Location = new System.Drawing.Point(125, 310);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(66, 17);
            this.cbRandom.TabIndex = 11;
            this.cbRandom.Text = "Random";
            this.cbRandom.UseVisualStyleBackColor = true;
            // 
            // btnShowDefinition
            // 
            this.btnShowDefinition.Location = new System.Drawing.Point(198, 307);
            this.btnShowDefinition.Name = "btnShowDefinition";
            this.btnShowDefinition.Size = new System.Drawing.Size(134, 23);
            this.btnShowDefinition.TabIndex = 9;
            this.btnShowDefinition.Text = "Show Definition";
            this.btnShowDefinition.UseVisualStyleBackColor = true;
            this.btnShowDefinition.Click += new System.EventHandler(this.btnShowDefinition_Click);
            // 
            // questionNum
            // 
            this.questionNum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.questionNum.Location = new System.Drawing.Point(86, 308);
            this.questionNum.Name = "questionNum";
            this.questionNum.Size = new System.Drawing.Size(32, 20);
            this.questionNum.TabIndex = 10;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(5, 307);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 27);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveQuizToolStripMenuItem,
            this.resumeToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 23);
            this.toolStripMenuItem1.Text = "File";
            // 
            // saveQuizToolStripMenuItem
            // 
            this.saveQuizToolStripMenuItem.Name = "saveQuizToolStripMenuItem";
            this.saveQuizToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveQuizToolStripMenuItem.Text = "Save Quiz";
            this.saveQuizToolStripMenuItem.Click += new System.EventHandler(this.saveQuizToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.resumeToolStripMenuItem.Text = "Open Quiz";
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.toolStripTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 23);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDefinition);
            this.panel1.Controls.Add(this.lblWord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 341);
            this.panel1.TabIndex = 8;
            // 
            // lblDefinition
            // 
            this.lblDefinition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDefinition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefinition.Location = new System.Drawing.Point(3, 45);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(206, 296);
            this.lblDefinition.TabIndex = 7;
            this.lblDefinition.Text = " lblDef";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(0, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(60, 24);
            this.lblWord.TabIndex = 6;
            this.lblWord.Text = "label1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblScore,
            this.lblResult});
            this.statusStrip1.Location = new System.Drawing.Point(0, 341);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblScore
            // 
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(49, 17);
            this.lblScore.Text = "lblScore";
            // 
            // lblResult
            // 
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 17);
            this.lblResult.Text = "lblResult";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(918, 341);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 363);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(840, 402);
            this.Name = "MainForm";
            this.Text = "GRE Vocab";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionNum)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbRandom;
        private System.Windows.Forms.Button btnShowDefinition;
        private System.Windows.Forms.NumericUpDown questionNum;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckedListBox cblMultiChoice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblScore;
        private System.Windows.Forms.Button btnRepeatWord;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblWordLookup;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripStatusLabel lblResult;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
    }
}


namespace GreVocab
{
    partial class OptionsForm
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
            this.synthVolume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.synthRate = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.synthVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.synthRate)).BeginInit();
            this.SuspendLayout();
            // 
            // synthVolume
            // 
            this.synthVolume.Location = new System.Drawing.Point(12, 12);
            this.synthVolume.Name = "synthVolume";
            this.synthVolume.Size = new System.Drawing.Size(205, 45);
            this.synthVolume.TabIndex = 17;
            this.synthVolume.Value = 5;
            this.synthVolume.Scroll += new System.EventHandler(this.synthVolume_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Speech synthesizer volume";
            // 
            // synthRate
            // 
            this.synthRate.Location = new System.Drawing.Point(266, 12);
            this.synthRate.Name = "synthRate";
            this.synthRate.Size = new System.Drawing.Size(205, 45);
            this.synthRate.TabIndex = 19;
            this.synthRate.Value = 5;
            this.synthRate.Scroll += new System.EventHandler(this.synthRate_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Speech synthesizer rate";
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(12, 103);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(459, 20);
            this.txtSavePath.TabIndex = 21;
            this.txtSavePath.Click += new System.EventHandler(this.txtSavePath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Folder to save to";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 162);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.synthRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.synthVolume);
            this.Name = "OptionsForm";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.synthVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.synthRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar synthVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar synthRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
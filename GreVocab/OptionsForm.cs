using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreVocab
{
    public partial class OptionsForm : Form
    {
        private MainForm mainForm { get; set; }

        public OptionsForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            txtSavePath.Text = System.Environment.SpecialFolder.MyDocuments.ToString();
            synthVolume.Value = mainForm.synth.Volume / 10;
            synthRate.Value = mainForm.synth.Rate;
        }

        private void synthVolume_Scroll(object sender, EventArgs e)
        {
            mainForm.synth.Volume = synthVolume.Value * 10;
        }

        private void synthRate_Scroll(object sender, EventArgs e)
        {
            mainForm.synth.Rate = synthRate.Value;
        }

        private void txtSavePath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyDocuments;
            folderBrowserDialog1.ShowDialog();
            txtSavePath.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}

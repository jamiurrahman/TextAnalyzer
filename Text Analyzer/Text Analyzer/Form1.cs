using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Analyzer
{
    public partial class Form1 : Form
    {
        Analyzer analyzer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBoxInput.AllowDrop = true;
            richTextBoxInput.DragDrop += RichTextBoxInput_DragDrop;
        }

        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            btnAnalyze.Text = "Analyzing...";
            btnAnalyze.Enabled = false;

            string str = Utils.CleanCharacters(richTextBoxInput.Text.Trim().ToLower());

            if (radioButtonCSharp.Checked)
            {
                analyzer = new SimpleCsharpAnalyzer();
            }
            else
            {
                analyzer = new SimpleCppAnalyzer();
            }

            string result = await Task.Run(() => analyzer.Analyze(str));
            labelResult.Text = "Result: " + result;

            btnAnalyze.Text = "Analyze";
            btnAnalyze.Enabled = true;
        }

        private void RichTextBoxInput_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    
                    richTextBoxInput.LoadFile(fileNames[0], RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void RichTextBoxInput_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStripCopyCutPaste.Show(Cursor.Position);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxInput.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxInput.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxInput.Paste();
        }
    }
}

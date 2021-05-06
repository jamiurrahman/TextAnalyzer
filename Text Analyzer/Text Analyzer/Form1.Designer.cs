
namespace Text_Analyzer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCpp = new System.Windows.Forms.RadioButton();
            this.radioButtonCSharp = new System.Windows.Forms.RadioButton();
            this.contextMenuStripCopyCutPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStripCopyCutPaste.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert your text below:";
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInput.Location = new System.Drawing.Point(12, 36);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(776, 257);
            this.richTextBoxInput.TabIndex = 1;
            this.richTextBoxInput.Text = "";
            this.richTextBoxInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RichTextBoxInput_MouseDown);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnalyze.Location = new System.Drawing.Point(348, 377);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 2;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // labelResult
            // 
            this.labelResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(9, 414);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(40, 13);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Result:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButtonCpp);
            this.groupBox1.Controls.Add(this.radioButtonCSharp);
            this.groupBox1.Location = new System.Drawing.Point(12, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithms";
            // 
            // radioButtonCpp
            // 
            this.radioButtonCpp.AutoSize = true;
            this.radioButtonCpp.Location = new System.Drawing.Point(7, 41);
            this.radioButtonCpp.Name = "radioButtonCpp";
            this.radioButtonCpp.Size = new System.Drawing.Size(44, 17);
            this.radioButtonCpp.TabIndex = 1;
            this.radioButtonCpp.Text = "C++";
            this.radioButtonCpp.UseVisualStyleBackColor = true;
            // 
            // radioButtonCSharp
            // 
            this.radioButtonCSharp.AutoSize = true;
            this.radioButtonCSharp.Checked = true;
            this.radioButtonCSharp.Location = new System.Drawing.Point(7, 20);
            this.radioButtonCSharp.Name = "radioButtonCSharp";
            this.radioButtonCSharp.Size = new System.Drawing.Size(39, 17);
            this.radioButtonCSharp.TabIndex = 0;
            this.radioButtonCSharp.TabStop = true;
            this.radioButtonCSharp.Text = "C#";
            this.radioButtonCSharp.UseVisualStyleBackColor = true;
            // 
            // contextMenuStripCopyCutPaste
            // 
            this.contextMenuStripCopyCutPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStripCopyCutPaste.Name = "contextMenuStripCopyCutPaste";
            this.contextMenuStripCopyCutPaste.Size = new System.Drawing.Size(145, 70);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Text Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStripCopyCutPaste.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCpp;
        private System.Windows.Forms.RadioButton radioButtonCSharp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCopyCutPaste;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    }
}


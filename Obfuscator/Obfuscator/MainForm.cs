using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Obfuscator.SourceData;

namespace Obfuscator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        OpenFile opFile;

        private void OpenFile(object sender, EventArgs e)
        {
            opFile = new OpenFile();
            richTextBox1.Text = opFile.Text;           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scanner scanner = new Scanner(opFile.Text);
            scanner.StartScan();
            CObfuscator obf = new CObfuscator(scanner.GetTokens);
            if (SingleLineComment.Checked)
            {
                obf.removeSingleLineComment();
            }
            if (MultiLineComment.Checked)            
            {
                obf.removeMultiLineComment();
            }

            richTextBox2.Clear();
            //вывод обфусцированного кода
            richTextBox2.Text += scanner.Print();

        }


        /// <summary>
        /// Событие, разрешающее настраивать удаление комментариев
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accessDeleteComment_EnabledChanged(object sender, EventArgs e)
        {
            if (accessDeleteComment.Checked)            
                paramObf.Enabled = true;            
            else
                paramObf.Enabled = false;
        }
        
    }
}

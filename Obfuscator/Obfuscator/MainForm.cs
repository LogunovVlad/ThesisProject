using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Obfuscator.SourceData;
using Obfuscator.SourceData.Table.TableMapping;

namespace Obfuscator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        OpenFile opFile;
        Printer printer;
        TableMapping table;

        private void OpenFile(object sender, EventArgs e)
        {
            opFile = new OpenFile();
            richTextBox1.Text = opFile.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table = new TableMapping();
            Scanner scanner = new Scanner(opFile.Text);
            scanner.StartScan();
            CObfuscator obf = new CObfuscator(scanner.GetTokens, table);
            if (SingleLineComment.Checked)
            {
                obf.removeSingleLineComment();
            }
            if (MultiLineComment.Checked)
            {
                obf.removeMultiLineComment();
            }
            if (replaceSingle.Checked)
            {
                //замена не нечитаемые однострочных комментариев
                obf.replacementForUnreadableSingle();
            }
            if (replaceMulti.Checked)
            {
                //замена не нечитаемые многострочных комментариев
                obf.replacementForUnreadableMulti();
            }
            //если выбрано удаление пустых строк
            if (checkEmptyLine.Checked)
            {
                obf.removeEmptyLine();
            }
            //если выбрана замена константных переменных
            if (checkReplace.Checked)
            {
                obf.replaceConstVariable();
            }
            //если выбрано переименование переменных
            if (checkRenameVariable.Checked)
            {
                obf.renameVariable(Convert.ToInt32(numericLengthVar.Value));
            }

            richTextBox2.Clear();
            //вывод обфусцированного кода           
            printer = new Printer(scanner.GetTokens);
            richTextBox2.Text += printer.StartPrint();
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

        private void buttonPrintMappin_Click(object sender, EventArgs e)
        {
            GridVariable.RowCount = table.GetTableNaming.Count;
            for (int i = 0; i < table.GetTableNaming.Count; i++)
            {                
                GridVariable.Rows[i].Cells[0].Value = table.GetTableNaming.ElementAt(i).Key;                
                GridVariable.Rows[i].Cells[1].Value = table.GetTableNaming.ElementAt(i).Value;
            }
        }

    }
}

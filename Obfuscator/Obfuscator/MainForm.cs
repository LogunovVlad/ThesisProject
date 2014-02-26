using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Obfuscator.SourceData;
using Obfuscator.SourceData.Table.TableMapping;
using System.Globalization;

namespace Obfuscator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Statistics form;
        CObfuscator obf;
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
            obf = new CObfuscator(scanner.GetTokens, table);
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
            //если выбрано расширение циклов
            if (checkCycles.Checked)
            {
                if (obf.extendChanceConditions())
                {
                    obf.extendConditions();
                }
                else
                    MessageBox.Show("Нет возможности расширения условий циклов!");
            }
            //если выбрано переименование переменных
            if (checkRenameVariable.Checked)
            {
                obf.renameVariable(Convert.ToInt32(numericLengthVar.Value));
            }
            //если выбрано переименование методов
            if (checkRenameMethod.Checked)
            {
                obf.renameMethod(Convert.ToInt32(numericLengthVar.Value));
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

        /// <summary>
        /// Сохранить обфусцированный код
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Cpp source file|*.cpp";
            saveFileDialog1.Title = "Save an I file";
            saveFileDialog1.ShowDialog();
            if (richTextBox2.Text.Length > 1)
            {
                // If the file name is not an empty string open it for saving.
                if (saveFileDialog1.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.
                    System.IO.FileStream fs =
                       (System.IO.FileStream)saveFileDialog1.OpenFile();
                    // Saves the Image in the appropriate ImageFormat based upon the
                    // File type selected in the dialog box.
                    // NOTE that the FilterIndex property is one-based.    

                    fs.Write(Encoding.Default.GetBytes(richTextBox2.Text), 0, Encoding.Default.GetBytes(richTextBox2.Text).Length);

                    fs.Close();
                }
            }
            else
                MessageBox.Show("Сохранение невозможно! Обфускация не производилась!", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Переделать!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        /// <summary>
        /// Сохранить таблицу соответствий
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder resSave = new StringBuilder();
            if (GridVariable.RowCount > 1)
            {
                for (int i = 0; i < GridVariable.RowCount; i++)
                {
                    resSave.Append(GridVariable.Rows[i].Cells[0].Value);
                    resSave.Append("-");
                    resSave.Append(GridVariable.Rows[i].Cells[1].Value);
                    resSave.Append(";\n");
                }
                string stringSave = resSave.ToString();
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Text file|*.txt";
                saveFileDialog1.Title = "Save an I file";
                saveFileDialog1.ShowDialog();
                // If the file name is not an empty string open it for saving.
                if (saveFileDialog1.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.
                    System.IO.FileStream fs =
                       (System.IO.FileStream)saveFileDialog1.OpenFile();
                    // Saves the Image in the appropriate ImageFormat based upon the
                    // File type selected in the dialog box.
                    // NOTE that the FilterIndex property is one-based.    

                    fs.Write(Encoding.Default.GetBytes(stringSave), 0, Encoding.Default.GetBytes(stringSave).Length);

                    fs.Close();
                }

            }
            else
                MessageBox.Show("Отсутствуют записи в таблице!", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void checkTrueRename_Click(object sender, EventArgs e)
        {
            if (checkTrueRename.Checked)
                groupBox1.Enabled = true;
            else
                groupBox1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*form = new Statistics();
            form.Show();   */
            MessageBox.Show("Курсовой проект на тему:\n\n \"Автоматизированные системы защиты\n" +
            "исходного кода на основе обфускации.\"\n\nВыполнил:\nстудент группы ИТ-51\nЛогунов Владислав", "О программе",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

    }
}

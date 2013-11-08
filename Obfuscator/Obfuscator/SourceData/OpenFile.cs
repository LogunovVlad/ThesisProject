using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Obfuscator.SourceData
{
    class OpenFile
    {
        private OpenFileDialog openFile;       
        private Stream myStream = null;
        private String text;
       
        /// <summary>
        /// Конструктор класса. Задает фильтр индекс, открывает файл и читает
        /// </summary>
        public OpenFile()
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "Cpp files (*.cpp)|*.cpp|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFile.OpenFile()) != null)
                    {  
                        text = System.IO.File.ReadAllText(openFile.FileName);                      
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);                  
                }
            }
        }

        /// <summary>
        /// Свойство для доступа к считанному тексту 
        /// </summary>
        public String Text
        {           
            get { return text; }
            set { text = value; }        
        }

    }
}

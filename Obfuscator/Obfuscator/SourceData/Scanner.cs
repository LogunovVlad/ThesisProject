using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Obfuscator.SourceData
{
    /// <summary>
    /// Класс лексического анализатора. Осуществляет лексический разбор исходного
    /// кода и хранит представление кода в виде последовательности токенов различного типа.
    /// </summary>
    class Scanner
    {
        private String sourceText;
        private List<Token> tokens;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sourceText">Исходный текст программы</param>        
        public Scanner(String sourceText)
        {
            this.sourceText = sourceText;            
        }

        public void StartScan()
        {
            String SourceText = this.sourceText;
            string pattern = @"(//)";
            foreach (string result in Regex.Split(SourceText, pattern))
            {
                string w=result;
            }
        }
    }
}

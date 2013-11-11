using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obfuscator.SourceData
{
    /// <summary>
    /// Класс обфускатора. Реализует выбранные методы обфускации и возвращает код
    /// преобразованной программы в текстовом представлении.
    /// </summary>
    class CObfuscator
    {
        private List<Token> tokens=new List<Token>();

        public CObfuscator(List<Token> tokens)
        {
            this.tokens = tokens;
        }

        /// <summary>
        /// Удаление однострочных комментариев
        /// </summary>
        /// <returns></returns>
        public List<Token> removeSingleLineComment()
        {
            this.tokens.RemoveAll(x => x.GetType == "SingleLineComment");
            return tokens;
        }

        public List<Token> removeMultiLineComment()
        {
            this.tokens.RemoveAll(x => x.GetType == "MultiLineComment");
            return tokens;
        }
        
    }
}

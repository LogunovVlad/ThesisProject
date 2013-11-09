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
    class Obfuscator
    {
        private List<Token> tokens=new List<Token>();

        public Obfuscator(List<Token> tokens)
        {
            this.tokens = tokens;
        }

        private List<Token> removeSingleLineComment(List<Token> tokens)
        {
            
            return tokens;
        }

        private static bool chekSingleComment(List<Token> tokens)
        {
            if(tokens.)
        }
    }
}

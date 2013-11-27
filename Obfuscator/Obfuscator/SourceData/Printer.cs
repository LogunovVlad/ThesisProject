using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Obfuscator.SourceData.Table.TableMapping;
using System.Windows.Forms;

namespace Obfuscator.SourceData
{
    class Printer
    {
        private List<Token> tokens;        

        public Printer(List<Token> tokens)
        {
            this.tokens = tokens;           
        }

        /// <summary>
        /// Выводит обфусцированный текст в richtextbox
        /// </summary>
        /// <returns></returns>
        public string StartPrint()
        {
            string res = null;
            for (int i = 0; i < tokens.Count; i++)
            {
                res += tokens.ElementAt(i).GetValue;
            }
            return res;
        }       

    }
}

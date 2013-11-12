using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Obfuscator.SourceData.TypeToken
{
    class DoubleQuotedLiteral
    {
        public DoubleQuotedLiteral()
        { }

        /// <summary>
        /// Метод проверяющий строку на литерал в двойных кавычках
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public static bool checkDoubleQuotedLiteral(string inputText)
        {
            bool flagCheck = false;
            string pattern = ("(\"(.*)\")");
            Regex regLit=new Regex(pattern);
            MatchCollection matchLit = regLit.Matches(inputText);
            if (matchLit.Count > 0)
            {
                flagCheck = true;
            }
            return flagCheck;
        }
       
    }
}

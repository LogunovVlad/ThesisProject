using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Obfuscator.SourceData.TypeToken.Number
{
    /// <summary>
    /// Класс определяющий, является ли входящий текст функцией
    /// </summary>
    class FunctionChecker
    {
        public FunctionChecker()
        { }

        /// <summary>
        /// Метод, проверяющий является ли входной текст функцией
        /// </summary>
        /// <param name="inputText"></param>
        public static bool checkFunction(string inputText)
        {
            bool flagCheck = false;
            string _leftBrackets = Regex.Escape("(");
            string _rightBrackets = Regex.Escape(")");        //  \\s*\\w*\\s*\\,*\\s*\\w*\\s*
            string patternFunction = "\\b(void|int|float|double|string)\\s\\w*\\s*" + Regex.Escape("(") + "(.*)" + Regex.Escape(")");
            Regex regFunction = new Regex(patternFunction);
            MatchCollection matchFunction = regFunction.Matches(inputText);
            if (matchFunction.Count > 0)
            {
                flagCheck = true;
            }
            return flagCheck;
        }
    }
}

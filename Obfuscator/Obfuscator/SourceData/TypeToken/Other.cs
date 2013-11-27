using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Obfuscator.SourceData.TypeToken
{
    /// <summary>
    /// Класс для токенов не вошедших в существующие классы 
    /// </summary>
    class Other
    {
        public Other()
        { }

        /// <summary>
        /// Проверяет на наличие в строке табуляции
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public static bool checkTabul(string inputText)
        {            
            bool flagCheck = false;
            string pattern = "\t";
            Regex regTab = new Regex(pattern);
            MatchCollection matchTab = regTab.Matches(inputText);
            if (matchTab.Count > 0)
            {
                flagCheck = true;
            }   
            return flagCheck;
        }

        /// <summary>
        /// Проверяет на наличие пустой строки
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public static bool emptyLine(string inputText)
        {
            bool flagCheck = false;
            string pattern = "^\r$";
            Regex regTab = new Regex(pattern);
            MatchCollection matchTab = regTab.Matches(inputText);
            if (matchTab.Count > 0)
            {
                flagCheck = true;
            }
            return flagCheck;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Obfuscator.SourceData.TypeToken
{
    /// <summary>
    /// Класс токена "Библиотека"
    /// </summary>
    class Library
    {
        public Library()
        { }

        /// <summary>
        /// Метод проверяющий входящую строку на соответствие библиотеке
        /// </summary>
        /// <param name="textBlock">Входящая строка, в которой производится проверка</param>
        /// <returns>true-если библиотека</returns>
        public static bool checkLibrary(String textBlock)
        {
            bool flagCheck = false;
            //паттерн для выделения библиотек
            string pattern = @"#include \w?";
            RegexOptions option = RegexOptions.IgnoreCase;
            Regex libRegex = new Regex(pattern, option);
            MatchCollection libMatch = libRegex.Matches(textBlock);
            //если есть вхождение паттерна - значит это библиотека
            if (libMatch.Count > 0)
                flagCheck = true;
            return flagCheck;
        }

    }
}

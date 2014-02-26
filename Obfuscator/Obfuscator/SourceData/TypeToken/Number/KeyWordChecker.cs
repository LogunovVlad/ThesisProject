using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Obfuscator.SourceData.TypeToken.Number
{
    /// <summary>
    /// Класс, отвечающий за поиск ключевых слов
    /// </summary>
    class KeyWordChecker
    {        
        public KeyWordChecker()
        { }
        
        /// <summary>
        /// Определяет, является ли лексема константой
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public static bool checkConstant(string inputText)
        {
            bool checkFlag=false;
            string pattern = @"const";
            MatchCollection matchConst = NewRegex(inputText, pattern);
            if (matchConst.Count > 0)
            {
                checkFlag = true;
            }
            return checkFlag;
        }

        /// <summary>
        /// Проверка main
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public static bool checkMain(string inputText)
        {
            bool checkFlag = false;
            string patternMain = @"main" + Regex.Escape("(") + Regex.Escape(")");
            MatchCollection matchMain = NewRegex(inputText, patternMain);
            if (matchMain.Count > 0)
            {
                checkFlag = true;
            }
            return checkFlag;
        }

        public static bool checkFor(string inputText)
        {
            bool checkFlag = false;
            string patternFor = @"for\s*" + Regex.Escape("(")+"(.*)" + Regex.Escape(")");
            MatchCollection matchFor = NewRegex(inputText, patternFor);
            if (matchFor.Count > 0)
            {
                checkFlag = true;
            }
            return checkFlag;
        }

        public static bool checkWhile(string inputText)
        {
            bool checkFlag = false;
            string patternFor = @"while\s*" + Regex.Escape("(") + "(.*)" + Regex.Escape(")");
            MatchCollection matchFor = NewRegex(inputText, patternFor);
            if (matchFor.Count > 0)
            {
                checkFlag = true;
            }
            return checkFlag;
        }

        /// <summary>
        /// Метод определяющий тип данных
        /// </summary>
        /// <param name="inputText">Входящий текст</param>
        /// <param name="dataType">Массив возможных символов</param>
        /// <returns>Возвращаемое значение: тип данных</returns>
        public static string checkDataType(string inputText, string[] dataType)
        {
            string result = null;
            for (int i = 0; i < dataType.Length; i++)
            {
                //соответствие должно начинаться с начала строки
                string pattern = @"\b" + dataType[i] + @"\b";
                //если найдено соответствие типу                
                if (NewRegex(inputText, pattern).Count > 0)
                {
                    result = dataType[i];
                }
            }
            return result;
        }       

        /// <summary>
        /// Создание регулярного выражения и коллекции соответствий для проверки на тип данных
        /// </summary>
        /// <param name="inputText"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        private static MatchCollection NewRegex(string inputText, string pattern)
        {
            Regex regConst = new Regex(pattern);
            MatchCollection matchConst = regConst.Matches(inputText);
            return matchConst;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Obfuscator.SourceData.TypeToken
{
    /// <summary>
    /// Класс для определения однострочного комментария
    /// </summary>
    class SingleLineComment
    {
        public SingleLineComment()
        { }

        /// <summary>
        /// Метод проверяет соответствует ли входящая строка токену "Однострочный комментарий"
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool? checkSingleLineComment(string text)
        {
            bool? flagCheck=false;
            //поиск будет производится с начала строки и искать строго одно вхождение "//".
            //После "//" ожидается 0 и более символов
            string pattern = @"(//){1}\w*";
            Regex regComment = new Regex(pattern);
            MatchCollection commentMatch = regComment.Matches(text);
            if (commentMatch.Count > 0)
            {
                flagCheck = true;
                //Если комментарий стоит после строки кода
                string delimPattern = @"\w* (//){1}\w*";
                Regex regDelim = new Regex(delimPattern);
                MatchCollection delimMatch = regDelim.Matches(text);                
                if (delimMatch.Count > 0)
                    flagCheck = null;             
                //если (//) находится в двойных кавычках (строковый литерал)
                delimPattern = ("(\"(.*)(//)(.*)\")");
                regDelim = new Regex(delimPattern);
                delimMatch = regDelim.Matches(text);
                //тогда это не комментарий
                if (delimMatch.Count > 0)
                    flagCheck = false;             
            }
            return flagCheck;
        }
    }
}

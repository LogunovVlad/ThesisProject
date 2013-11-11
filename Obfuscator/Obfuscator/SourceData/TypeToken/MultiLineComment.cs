using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Obfuscator.SourceData.TypeToken
{
    class MultiLineComment
    {
        public MultiLineComment()
        { }

        /// <summary>
        /// Метод проверяюищй входящую строку на соответстие многострочному комментарию
        /// </summary>
        /// <param name="text">Входящая строка</param>
        /// <returns>true - соответствует</returns>
        public static bool checkMultiLineComment(string text)
        {
            bool flagCheck = false;
            //звездочка после косой черты экранируется
            string pattern = @"(/\*){1}\w*";            
            RegexOptions option = RegexOptions.IgnoreCase;
            Regex regMulti = new Regex(pattern,option);
            MatchCollection matchMultiComment = regMulti.Matches(text);
            if (matchMultiComment.Count > 0)
            {
                flagCheck = true;
            }
            return flagCheck;
        }
    }
}

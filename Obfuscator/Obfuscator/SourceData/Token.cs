using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obfuscator.SourceData
{
    /// <summary>
    /// Класс, служащий для хранения базовой информации о токене.
    /// Инкапсулирует тип токена и его значение
    /// </summary>
    class Token
    {
        private String Value;
        private String Type;
        enum TokenTypes
        {
            Library, Identifier, Keyword, SingleQuotedLiteral, DoubleQuotedLiteral, NumericValue,
            SingleLineComment, MultiLineComment, Delimiter, NotCode, Other
        };
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value">Значение токена</param>
        /// <param name="tTypes">Тип токена</param>
        public Token(String Value, String tTypes)
        {
            this.Value = Value;
            this.Type = tTypes;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Obfuscator.SourceData.TypeToken;

namespace Obfuscator.SourceData
{
    /// <summary>
    /// Класс лексического анализатора. Осуществляет лексический разбор исходного
    /// кода и хранит представление кода в виде последовательности токенов различного типа.
    /// </summary>
    class Scanner
    {
        private String sourceText;
        private List<Token> tokens;
        enum TokenTypes
        {
            Library, Identifier, Keyword, SingleQuotedLiteral, DoubleQuotedLiteral, NumericValue,
            SingleLineComment, MultiLineComment, Delimiter, NotCode, Other
        };

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sourceText">Исходный текст программы</param>        
        public Scanner(String sourceText)
        {
            this.sourceText = sourceText;  
            tokens=new List<Token>();
        }

        /// <summary>
        /// Метод сканирующий входной исходный текст, и определяющий к какому токену
        /// относится лексема. (Разбивает исходный текст на подстроки и перебирает их ища 
        /// совпадения)
        /// </summary>
        public void StartScan()
        {
            String SourceText = this.sourceText;
            string pattern = "\n";
            string[] result = Regex.Split(SourceText, pattern);
            for(int i=0; i<result.Length; i++)
            {               
                if (Library.checkLibrary(result[i]))
                {
                    TokenTypes lib = TokenTypes.Library;
                    AddTokens(result, i, lib);              
                    continue;
                }
                
                if (SingleLineComment.checkSingleLineComment(result[i])==true)
                {
                    TokenTypes singleComment = TokenTypes.SingleLineComment;
                    AddTokens(result, i, singleComment);
                    continue;
                }

                //если комментарий стоит после строки с кодом(не на новой строке)
                if (SingleLineComment.checkSingleLineComment(result[i]) ==null)
                {
                    TokenTypes typeComment = TokenTypes.SingleLineComment;
                    TokenTypes typeOther = TokenTypes.Other;
                    string patternSplit = @"(//)";
                    Regex regSplit = new Regex(patternSplit);
                    //разбивает строку только на 2 подстроки(после символа "//")
                    string[] massSplit = regSplit.Split(result[i],2);
                    //добавляем комментарий, как токен "Однострочный комментарий"
                    tokens.Add(new Token(massSplit[1] + massSplit[2], Enum.Format(typeof(TokenTypes), typeComment, "G")));
                    //добавляем текст, который стоит перед комментарием, как токен "Other"
                    AddTokens(massSplit,0,typeOther);                    
                    continue;
                }

                //токены не вошедшие в какие-либо классы
                #region
                TokenTypes other = TokenTypes.Other;
                tokens.Add(new Token(result[i], Enum.Format(typeof(TokenTypes), other, "G")));
                #endregion
            }
                        
        }

        /// <summary>
        /// Метод добавляющий найденный токен в коллекцию
        /// </summary>
        /// <param name="result">Массив входящий строк(Исходный текст разбитый на подстроки)</param>
        /// <param name="i">Номер подстроки, включаемой в токен</param>
        /// <param name="lib">Тип токена</param>
        private void AddTokens(string[] result, int i, TokenTypes lib)
        {            
            tokens.Add(new Token(result[i], Enum.Format(typeof(TokenTypes), lib, "G")));
        }
    }
}

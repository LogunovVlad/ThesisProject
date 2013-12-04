using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Obfuscator.SourceData.TypeToken;
using Obfuscator.SourceData.TypeToken.Number;
using Obfuscator.SourceData.Table.TableMapping;

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

        internal List<Token> GetTokens
        {
            get { return tokens; }            
        }
        enum TokenTypes
        {
            Library, Identifier, Keyword, SingleQuotedLiteral, DoubleQuotedLiteral, NumericValue,
            SingleLineComment, MultiLineComment, Delimiter, NotCode, Const, Other, EmptyLine, Function, Main, For
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
                if(Other.checkTabul(result[i]))                
                {
                    //string patternSplit = "\t";
                    //Regex regSplit = new Regex(patternSplit);
                    //разбивает строку только на 2 подстроки(после символа "\t")
                    string massSplit = result[i].Replace("\t", "");// regSplit.Replace(result[i], "\\t"); //Split(result[i],2);
                    result[i] = massSplit;
                }

                //если комментарий
                if (SingleLineComment.checkSingleLineComment(result[i]) == true)
                {
                    TokenTypes singleComment = TokenTypes.SingleLineComment;
                    AddTokens(result, i, singleComment);
                    continue;
                }

                //если комментарий стоит после строки с кодом(не на новой строке)
                if (SingleLineComment.checkSingleLineComment(result[i]) == null)
                {
                    TokenTypes typeComment = TokenTypes.SingleLineComment;
                    TokenTypes typeOther = TokenTypes.Other;
                    string patternSplit = @"(//)";
                    Regex regSplit = new Regex(patternSplit);
                    //разбивает строку только на 2 подстроки(после символа "//")
                    string[] massSplit = regSplit.Split(result[i], 2);
                    //добавляем комментарий, как токен "Однострочный комментарий"
                    tokens.Add(new Token(massSplit[1] + massSplit[2], Enum.Format(typeof(TokenTypes), typeComment, "G")));
                    //добавляем текст, который стоит перед комментарием, как токен "Other"
                    AddTokens(massSplit[0] + "\r", typeOther);
                    continue;
                }

                //многострочный комментарий
                if (MultiLineComment.checkMultiLineComment(result[i]))
                {
                    TokenTypes typeMultiComment = TokenTypes.MultiLineComment;
                    //паттерн для проверки окончания комментария
                    string patternMulti = @"\w*(\*)/";
                    Regex regMulti = new Regex(patternMulti);
                    string MultiLine = null;
                    for (int index = i; index < result.Length; index++)
                    {
                        MultiLine += result[index];
                        MatchCollection matchMilti = regMulti.Matches(result[index]);
                        if (matchMilti.Count > 0)
                        {
                            //проверить
                            i += index - i;
                            AddTokens(MultiLine, typeMultiComment);
                            break;
                        }
                    }
                    continue;
                }

                if (Library.checkLibrary(result[i]))
                {
                    TokenTypes lib = TokenTypes.Library;
                    AddTokens(result, i, lib);              
                    continue;
                }

                if (KeyWordChecker.checkMain(result[i]))
                {
                    TokenTypes main = TokenTypes.Main;
                    AddTokens(result[i], main);
                    continue;
                }

                //проверка на функцию
                if (FunctionChecker.checkFunction(result[i]))
                {
                    TokenTypes func = TokenTypes.Function;
                    AddTokens(result[i], func);
                    continue;
                }                                

                //проверка на константу
                if (KeyWordChecker.checkConstant(result[i]))
                {
                    TokenTypes constI = TokenTypes.Const;
                    AddTokens(result[i], constI);
                    continue;
                }

                //проверка на for
                if (KeyWordChecker.checkFor(result[i]))
                {
                    TokenTypes For = TokenTypes.For;
                    AddTokens(result[i], For);
                    continue;
                }

                //проверка на тип данных
                string resType = KeyWordChecker.checkDataType(result[i], Token.dataType);
                if (resType != null)
                {
                    //вызов метода!!!!!!!!!!!!!!!!!!!!!!!!
                    string patternComma = Regex.Escape(",");
                    Regex regComma = new Regex(patternComma);
                    MatchCollection matchComma = regComma.Matches(result[i]);
                    if (matchComma.Count > 0)
                    {
                        string[] Variable = regComma.Split(result[i]);
                        for (int index = 0; index < Variable.Length; index++)
                        {
                            AddTokens(Variable[index], resType);
                            //для последнего символа не добавлять запятую
                            if (index != Variable.Length - 1)
                            {
                                AddTokens(",", " Other");
                            }
                        }
                        continue;
                    }
                    else
                    {
                        AddTokens(result[i], resType);
                        continue;
                    }
                }

                //если литерал в двойных кавычках
                if (DoubleQuotedLiteral.checkDoubleQuotedLiteral(result[i]))
                {
                    TokenTypes QLiteral = TokenTypes.DoubleQuotedLiteral;
                    AddTokens(result[i], QLiteral);
                    continue;
                }              
              
                //если на входе пустая строка
                if (Other.emptyLine(result[i]))
                {
                    AddTokens(result[i], TokenTypes.EmptyLine);
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
        
        private void AddTokens(string result, TokenTypes lib)
        {
            tokens.Add(new Token(result, Enum.Format(typeof(TokenTypes), lib, "G")));
        }

        private void AddTokens(string result, string type)
        {
            tokens.Add(new Token(result, type));
        }       
        
    }
}

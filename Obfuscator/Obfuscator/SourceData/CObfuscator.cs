using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Obfuscator.SourceData.Table.TableMapping;

namespace Obfuscator.SourceData
{
    /// <summary>
    /// Класс обфускатора. Реализует выбранные методы обфускации и возвращает код
    /// преобразованной программы в текстовом представлении.
    /// </summary>
    class CObfuscator
    {
        private List<Token> tokens = new List<Token>();
        private TableMapping table;

        public CObfuscator(List<Token> tokens, TableMapping table)
        {
            this.tokens = tokens;
            this.table = table;
        }

        /// <summary>
        /// Удаление однострочных комментариев
        /// </summary>
        /// <returns>Возвращает массив токенов</returns>
        public List<Token> removeSingleLineComment()
        {
            this.tokens.RemoveAll(x => x.GetType == "SingleLineComment");
            return tokens;
        }

        /// <summary>
        /// Удаление многострочных комментариев
        /// </summary>
        /// <returns></returns>
        public List<Token> removeMultiLineComment()
        {
            this.tokens.RemoveAll(x => x.GetType == "MultiLineComment");
            return tokens;
        }

        /// <summary>
        /// Замена однострочных комментариев на нечитаемые
        /// </summary>
        /// <returns></returns>
        public List<Token> replacementForUnreadableSingle()
        {
            for (int i = 0; i < tokens.Count; i++)
            {
                if (tokens.ElementAt(i).GetType == "SingleLineComment")
                {
                    string str = encodeXOR(tokens.ElementAt(i).GetValue);
                    tokens.ElementAt(i).SetValue = str;
                }
            }
            return tokens;
        }

        /// <summary>
        /// Замена многострочных комментариев на нечитаемы
        /// </summary>
        /// <returns></returns>
        public List<Token> replacementForUnreadableMulti()
        {
            for (int i = 0; i < tokens.Count; i++)
            {
                if (tokens.ElementAt(i).GetType == "MultiLineComment")
                {
                    string str = encodeXORMulti(tokens.ElementAt(i).GetValue);
                    tokens.ElementAt(i).SetValue = str;
                }
            }
            return tokens;
        }

        /// <summary>
        /// Метод для удаления лишних пробелов
        /// </summary>
        /// <returns></returns>
        public List<Token> removeEmptyLine()
        {
            this.tokens.RemoveAll(x => x.GetType == "EmptyLine");
            return tokens;
        }

        /// <summary>
        /// Метод, для замены константных имен констант фактическими данными
        /// </summary>
        /// <returns></returns>       
        public List<Token> replaceConstVariable()
        {
            RenameVariable constObj = new RenameVariable(tokens, table);
            constObj.ScannerConst();
            return tokens;
        }

        /// <summary>
        /// Метод замены переменных
        /// </summary>
        /// <param name="countLitVariable">Количество букв в новой переменной</param>
        /// <returns></returns>
        public List<Token> renameVariable(int countLitVariable)
        {
            RenameVariable renameObj = new RenameVariable(tokens, this.table);            
            renameObj.ScannerVariable(Token.dataType, countLitVariable);
            return tokens;
        }

        //XOR для комментариев
        #region 
        /// <summary>
        /// Метод шифрования XOR
        /// </summary>
        /// <param name="pText">Входящая строка которая подлежит шифрованию</param>
        /// <returns></returns>
        private string encodeXOR(string pText)
        {
            string result = "";
            string[] massSplit = null;
            string temp = null;
            massSplit = splitSingle(pText);
            temp = massSplit[massSplit.Length - 1];


            for (int i = 0; i < temp.Length; i++)
            {
                Char ch = (Char)(temp[i] ^ 1255);
                result += ch;
            }
            massSplit[massSplit.Length - 1] = result;
            result = null;
            for (int i = 0; i < massSplit.Length; i++)
            {
                result += massSplit[i];
            }
            return result + "\r";
        }

        /// <summary>
        /// Метод отделяющий текст от кавычек в однострочном комментарии
        /// </summary>
        /// <param name="text">Входящая строка(полный комментарий: //пример)</param>
        /// <returns></returns>
        private string[] splitSingle(string text)
        {
            string pattern = @"(//)";
            Regex reg = new Regex(pattern);
            string[] massSplit = reg.Split(text, 2);
            return massSplit;
        }

        /// <summary>
        /// Метод шифрования мнгострочных комментариев
        /// </summary>
        /// <param name="pText"></param>
        /// <returns></returns>
        private string encodeXORMulti(string pText)
        {
            string result = "";                                  
            for (int i = 0; i < pText.Length; i++)
            {
                Char ch = (Char)(pText[i] ^ 1255);
                result += ch;
            }    
            string temp=null;
            temp += "/*";
            temp += result + "*/\r";

            return temp;
        }
        #endregion
    }
}

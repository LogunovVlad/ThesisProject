using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Obfuscator.SourceData.Table.TableMapping
{
    class RenameVariable
    {
        List<Token> token = new List<Token>();
        private TableMapping table;       
        
        private string sourceLit;
        private string sourceValue;
        private string patternEquals;
        private string patternSpace;
        private string patternDot;
        private string patternMassive;
        private string patternStar;
        Random rand = new Random();
        /// <summary>
        /// Класс для замены константных переменных значениями
        /// </summary>        
        public RenameVariable(List<Token> token, TableMapping table)
        {
            this.token = token;
            this.table = table;
        }

        /// <summary>
        /// Метод, заменяющий константы
        /// </summary>
        /// <param name="inputText"></param>
        private void ReplaceConst(string inputText)
        {                                
            patternEquals = "=";
            patternSpace = " ";
            patternDot = ";";
            sourceLit = null;
            sourceValue = null;
            Regex regSplit = new Regex(patternEquals);
            Regex regSpace = new Regex(patternSpace);
            Regex regDot = new Regex(patternDot);
            string[] matchSplit = regSplit.Split(inputText);
            string[] leftString = regSpace.Split(matchSplit[0].Trim());
            if (matchSplit.Length > 1)
            {
                string[] rightString = regDot.Split(matchSplit[1]);
                //значение
                sourceValue = rightString[0];
            }
            else
                sourceValue = null;
            //литера
            sourceLit = leftString[leftString.Length - 1];
            //добавление  в таблицу соответствий
            table.addTableMapping(sourceLit, sourceValue);

            string patternSearch = @"[^\w+]" + sourceLit + @"[^\w+]";
            string replace = sourceValue.Trim();
            //начинаем переименовывание
            Regex regSearch = new Regex(patternSearch);
            //поиск и замена
            for (int i = 0; i < token.Count; i++)
            {
                string matchSearch = token.ElementAt(i).GetValue;
                MatchCollection matchS = regSearch.Matches(matchSearch);
                if (matchS.Count > 0)
                {
                    //заменяем
                    string s = Regex.Replace(matchSearch, sourceLit, replace);
                    token.ElementAt(i).SetValue = s;
                }
            }            
        }

        private void ReplaceVariable(string inputText, int countLiter)
        {
            patternEquals = "=";
            patternSpace = " ";
            patternDot = ";";
            patternMassive = Regex.Escape("[");
            patternStar = Regex.Escape("*");
            Regex regSplit = new Regex(patternEquals);
            Regex regSpace = new Regex(patternSpace);
            Regex regDot = new Regex(patternDot);
            Regex regMassive = new Regex(patternMassive);
            Regex regStar = new Regex(patternStar);
            string[] matchSplit = regSplit.Split(inputText);
            string[] leftString = regSpace.Split(matchSplit[0].Trim());
            if (matchSplit.Length > 1)
            {
                string[] rightString = regDot.Split(matchSplit[1]);
                //значение
                sourceValue = rightString[0];
                sourceLit = leftString[leftString.Length - 1];
                //если переменная объявлена как массив
                #region
                MatchCollection matchMassive = regMassive.Matches(sourceLit);
                if (matchMassive.Count > 0)
                {
                    string[] massiveLit = regMassive.Split(sourceLit);
                    sourceLit = massiveLit[0];
                }
                #endregion
                //если переменная указатель
                #region
                MatchCollection matchStar = regStar.Matches(sourceLit);
                if (matchStar.Count > 0)
                {
                    string[] massiveLitStar = regStar.Split(sourceLit);
                    sourceLit = massiveLitStar[1];
                }
                #endregion
            }
            //если переменная не проинициализрована
            else
            {
                string[] rString = regDot.Split(leftString[leftString.Length - 1]);
                sourceLit = rString[0];
                sourceValue = "No init!";
                //если переменная объявлена как массив
                #region
                MatchCollection matchMassive = regMassive.Matches(sourceLit);
                if (matchMassive.Count > 0)
                {
                    string[] massiveLit = regMassive.Split(sourceLit);
                    sourceLit = massiveLit[0];
                }
                #endregion
                //если переменная указатель
                MatchCollection matchStar = regStar.Matches(sourceLit);
                if (matchStar.Count > 0)
                {
                    string[] massiveLitStar = regStar.Split(sourceLit);
                    sourceLit = massiveLitStar[1];
                }
            }                      
            
            string patternSearch = "(\\b|\\s?\\W+\\s?)" + sourceLit + "(\\b|\\W+)";
            string randReplace = NewNameVariable(countLiter);
            string replace = "$1"+randReplace;
            table.addTableMapping(sourceLit, randReplace);
            //начинаем переименовывание
            Regex regSearch = new Regex(patternSearch);
            //поиск и замена
            for (int i = 0; i < token.Count; i++)
            {
                string matchSearch = token.ElementAt(i).GetValue;
                MatchCollection matchS = regSearch.Matches(matchSearch);
                if (matchS.Count > 0)
                {
                    //заменяем
                    string s = Regex.Replace(matchSearch, patternSearch, replace);
                    token.ElementAt(i).SetValue = s;
                }
            }         
        }

        /// <summary>
        /// Генерация новых имен переменных случайным образом
        /// </summary>
        /// <param name="countLiter">Желаемое количество букв в новой переменной</param>
        /// <returns></returns>
        private string NewNameVariable(int countLiter)
        {
            string resutl = null;
            string[] massivLit = { "l", "i", "I" };
            for (int i = 0; i < countLiter; i++)
            {
                int indexVar = rand.Next(0, 3);
                resutl += massivLit[indexVar];
            }
            return resutl;
        }

        /// <summary>
        /// Метод извлекающий из коллекции token элементы типа Const
        /// </summary>
        /// <returns>Возвращает коллекцию token-ов</returns>
        public List<Token> ScannerConst()
        {
            for (int i = 0; i < token.Count; i++)
            {
                if (token.ElementAt(i).GetType == "Const")
                {
                    ReplaceConst(token.ElementAt(i).GetValue);
                    //удаляем значение const
                }
            }
            token.RemoveAll(x => x.GetType == "Const");
            return token;
        }

        /// <summary>
        /// Метод, извлекающий из коллекции token, элементы различных типов
        /// </summary>
        /// <param name="dataType">Типы данных</param>
        /// <param name="countLiter">Количество букв в новой переменной</param>
        /// <returns>Возвращает коллекцию token-ов</returns>
        public List<Token> ScannerVariable(string[] dataType, int countLiter)
        {
            for (int j = 0; j < dataType.Length; j++)
            {
                for (int i = 0; i < token.Count; i++)
                {
                    if (token.ElementAt(i).GetType == dataType[j])
                    {
                        ReplaceVariable(token.ElementAt(i).GetValue,countLiter);
                    }
                }
            }
            return token;
        }
    }
}

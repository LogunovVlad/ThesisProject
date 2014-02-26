using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Obfuscator.SourceData.Table.TableMapping
{
    class ExpansionCyclesConditions
    {
        List<Token> token = new List<Token>();
        List<Token> tokenAdd = new List<Token>();
        List<Token> tokenDefinition = new List<Token>();
        Random rand = new Random();

        public ExpansionCyclesConditions(List<Token> token)
        {
            this.token = token;
        }

        public List<Token> GenerateNewFunction(string number, int num)
        {
            string _resultFunction = null;           
            AddTokens("\nint name" + number + num+ "()\n", "Function");
            AddTokens("{\n", "Other");
            AddTokens("int z=0;\n", "int");
            AddTokens("int x=" + number + ";\n", "int");
            AddTokens("int y=6;\n", "int");
            AddTokens("z=65536*y+x;\n", "Other");
            AddTokens("return z;\n", "Other");
            AddTokens("}", "Other");
            return tokenAdd;
        }

        /// <summary>
        /// Проверка условия возможности расширения
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public bool CheckChanceCondition()
        {
            bool checkFlag = false;
            for (int i = 0; i < token.Count; i++)
            {
                if (token.ElementAt(i).GetType == "For" || token.ElementAt(i).GetType == "while")
                {
                    checkFlag = true;
                }
            }
            return checkFlag;
        }

        private void ExtensionConditionWhile(string sourceText, int index)
        {
            string replace = null;            
            string patternM = "(<|>|==)";
            string patternSk = "\\(";
            string patternSkz = "\\)";  
            Regex regM = new Regex(patternM);
            Regex regSk = new Regex(patternSk);
            Regex regSkz = new Regex(patternSkz);            
            
            MatchCollection match = regSk.Matches(sourceText);
         
            if (match.Count > 0)
            {             
                string[] massCond = regSkz.Split(sourceText);
                string[] source = regSk.Split(massCond[0]);
                string[] lit = regM.Split(source[1]);
                string sourceLit = lit[2].Trim();
                //проверка на число
                int value;
                try
                {
                    Regex patternNumb = new Regex(@"\d+");
                    MatchCollection matchNumb = patternNumb.Matches(sourceLit);
                    if (matchNumb.Count > 0)
                    {
                        int num = rand.Next(0, 1000);
                        GenerateNewFunction(sourceLit, num);
                        replace = source[0] + "(" + lit[0] + lit[1] + "name" + sourceLit + num + "()-65536*6)";
                        //плюс одна строчка т.к. добавляем определение функции
                        token.ElementAt(index).SetValue = replace;
                        GenerateDefinition("\nint name" + sourceLit + num + "();\n");
                    }
                }
                catch (Exception e)
                {
                    
                }
            }
        }

        /// <summary>
        /// Метод для замены условий цикл
        /// </summary>
        /// <param name="sourceText"></param>
        private void ExtensionCondition(string sourceText, int index)
        {
            string replace = null;
            string pattern = ";";
            string patternM = "(<|>|==)";
            string patternB = ">";
            Regex regDot = new Regex(pattern);
            Regex regM = new Regex(patternM);
            Regex regB = new Regex(patternB);
            MatchCollection match = regDot.Matches(sourceText);           

            if (match.Count > 1)
            {              
                string[] massBody = regDot.Split(sourceText);
                string[] massCond = regM.Split(massBody[1]);
                string sourceLit = massCond[2].Trim();
                //проверка на число
                int value;
                try
                {
                    Regex patternNumb =new Regex(@"\d+");
                    MatchCollection matchNumb = patternNumb.Matches(sourceLit);
                    if (matchNumb.Count > 0)
                    {
                        int num = rand.Next(0,1000);
                        GenerateNewFunction(sourceLit,num);                                               
                        replace = massBody[0]+";"+ massCond[0]+ massCond[1] +"name" + sourceLit+num+"()-65536*6;"+massBody[2];
                        //плюс одна строчка т.к. добавляем определение функции
                        token.ElementAt(index).SetValue = replace;
                        GenerateDefinition("\nint name" + sourceLit + num + "();\n");
                    }
                }
                catch (Exception e)
                {
                    /*Обработка*/                   
                }                                
            }              
        }

        /// <summary>
        /// Метод добавляющий определение функции
        /// </summary>
        /// <param name="definition">Строка определения функции</param>
        private void DefinitionFunction()
        {
            int lastIndex = token.FindLastIndex(x => x.GetType.Equals("Library"));
            for (int i = 0; i < tokenDefinition.Count; i++)
            {
                token.Insert(lastIndex + 1, new Token(tokenDefinition.ElementAt(i).GetValue, "Function"));
            }
        }

        private void GenerateDefinition(string sourceDefinition)
        {
            AddTokensDefinition(sourceDefinition, "Function");
        }

        /// <summary>
        /// Изменить условия цикла
        /// </summary>
        public void StartInsertConditions()
        {
            for (int i = 0; i < token.Count; i++)
            {
                if (token.ElementAt(i).GetType == "For")
                {
                    ExtensionCondition(token.ElementAt(i).GetValue, i);
                    continue;
                }
                if (token.ElementAt(i).GetType == "While")
                {
                    ExtensionConditionWhile(token.ElementAt(i).GetValue, i);
                    continue;
                }
            }
            DefinitionFunction();
            //добавляем новые определения и описания функций
            token.AddRange(tokenAdd);
        }

        private void AddTokens(string result, string type)
        {
            tokenAdd.Add(new Token(result, type));
        }

        private void AddTokensDefinition(string result, string type)
        {
            tokenDefinition.Add(new Token(result, type));
        }
    }
}

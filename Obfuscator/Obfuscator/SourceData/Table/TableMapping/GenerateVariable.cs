using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obfuscator.SourceData.Table.TableMapping
{
    class GenerateVariable
    {           
        public GenerateVariable(TableMapping table)
        { }
        
        private int Factorial(int countLiter)
        {
            int result = 1;
            for (int i = countLiter; i > 1; i--)
            {
                result = result * i;
            }
            return result;
        }

        /// <summary>
        /// Генерация новых имен переменных случайным образом
        /// </summary>
        /// <param name="countLiter">Желаемое количество букв в новой переменной</param>
        /// <returns></returns>
        public static string NewNameVariable(int countLiter, Random rand)
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
    }
}

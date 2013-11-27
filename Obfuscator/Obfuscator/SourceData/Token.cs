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
        private String tStruct;
        public static string[] dataType = { "int", "double", "float", "char", "long", "bool", "string" };
        public static string[] typeStruct = { "struct", "function" };
                                                                      
        public String GetValue
        {
            get { return Value; }
        }

        public String SetValue
        {
            set { Value = value; }
        }
    
        public String GetType
        {
            get { return Type; }            
        }       
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value">Значение токена</param>
        /// <param name="tTypes">Тип токена (char, int, double и т.д.)</param>
        /// <param name="tStruct">Тип токена (массив, структура, переменная, метод и т.д.)</param>
        public Token(String Value, String tTypes, String tStruct=null)
        {
            this.Value = Value;
            this.Type = tTypes;
            this.tStruct = tStruct;
        }
        
    }
}
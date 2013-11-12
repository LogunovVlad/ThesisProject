﻿using System;
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
        /// <param name="tTypes">Тип токена</param>
        public Token(String Value, String tTypes)
        {
            this.Value = Value;
            this.Type = tTypes;
        }
        
    }
}
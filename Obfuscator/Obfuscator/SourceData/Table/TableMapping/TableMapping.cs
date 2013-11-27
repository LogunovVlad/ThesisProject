using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obfuscator.SourceData.Table.TableMapping
{
    /// <summary>
    /// Класс, отвечающий за соответствие переменных
    /// </summary>
    class TableMapping
    {
        private Dictionary<string, string> tableNaming;

        public Dictionary<string, string> GetTableNaming
        {
            get { return tableNaming; }           
        }       

        public TableMapping()
        {
            tableNaming = new Dictionary<string, string>();
        }

        /// <summary>
        /// Метод, добавляющий в таблицу соответствий переименованную единицу
        /// </summary>
        /// <param name="source"></param>
        /// <param name="rename"></param>
        public void addTableMapping(string source, string rename)
        {
            this.tableNaming.Add(source, rename);
        }
    }
}

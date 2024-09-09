using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс генерации уникальных идентификаторов.
    /// </summary>
    public class IdGenerator
    {
        
        private int _currentId = 0;
        /// <summary>
        /// Метод, задающий уникальный идентификатор.
        /// </summary>
        public int GetNextId()
        {
            int NextId = ++_currentId;
            return NextId;
        }
    }
}

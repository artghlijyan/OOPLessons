using System;
using System.Collections.Generic;

namespace OOPLessons.DataBases
{
    class DataBase
    {
        private List<object> _dBase;

        public DataBase()
        {
            _dBase = new List<object>();
        }

        public object this[int index]
        {
            get
            {
                if (index > -1 && index < _dBase.Count)
                {
                    return _dBase[index];
                }

                throw new IndexOutOfRangeException("Wrong Index");
            }
            set
            {
                if (index > -1 && index < _dBase.Count)
                {
                    _dBase[index] = value;
                }

                throw new IndexOutOfRangeException("Wrong Index");
            }
        }

        public void AddToDb(object obj)
        {
            if (_dBase != null)
            {
                _dBase.Add(obj);
            }
        }

        public void ReadDb()
        {
            int i = -1;
            foreach (var item in _dBase)
            {
                i++;
                Console.WriteLine($"Index {i} data: {item}");
            }
        }
    }
}

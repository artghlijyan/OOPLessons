using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOPLessons.IEnumerableIMPLS
{
    class ImplExample1 : IEnumerable
    {
        int[] _items;

        public ImplExample1()
        {
            _items = new int[10];
        }

        public ImplExample1(int[] items)
        {
            _items = items;
        }

        public IEnumerator GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }

    class ImplExample2 : IEnumerable
    {
        int[] _items;

        public ImplExample2()
        {
            _items = new int[10];
        }

        public ImplExample2(int[] items)
        {
            _items = items;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                yield return _items[i];
            }
        }
    }

    class ImplExample3 : IEnumerable
    {
        int[] _items;
        Enumerator enumerator = new Enumerator();

        public ImplExample3()
        {
            _items = new int[4];
        }

        public ImplExample3(int[] items)
        {
            this._items = items;
        }

        public IEnumerator GetEnumerator()
        {
            enumerator.InitializeEnumerator(this._items);
            return enumerator;
        }

        struct Enumerator : IEnumerator
        {
            int currentIndex;
            int[] _items;

            public void InitializeEnumerator(int[] items)
            {
                _items = items;
            }

            object IEnumerator.Current => _items[currentIndex++];

            bool IEnumerator.MoveNext()
            {
                (this as IEnumerator).Reset(); // Why not reseted

                if (currentIndex < _items.Length)
                {
                    return true;
                }

                return false;
            }

            void IEnumerator.Reset()
            {
                currentIndex = 0;
            }
        }
    }

    class ImplExample4 : IEnumerable, IEnumerator
    {
        int[] _items;
        int currentIndex = 0;

        public ImplExample4()
        {
            _items = new int[10];
        }

        public ImplExample4(int[] items)
        { 
            _items = items;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        object IEnumerator.Current => _items[currentIndex++];

        bool IEnumerator.MoveNext()
        {
            if (currentIndex < _items.Length)
            {
                return true;
            }

            (this as IEnumerator).Reset();
            return false;
        }

        void IEnumerator.Reset()
        {
            currentIndex = 0;
        }
    }
}

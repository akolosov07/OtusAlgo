using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusAlgoStruct
{
    public class ArrayListWrapper<T> : IArray<T>
    {
        private ArrayList _innerArray;

        public ArrayListWrapper()
        {
            _innerArray = new ArrayList();
        }

        public int Size()
        {
            return _innerArray.Count;
        }

        public void Add(T item)
        {
            _innerArray.Add(item);
        }

        public T Get(int index)
        {
            return (T)_innerArray[index];
        }

        public void Add(T item, int index)
        {
            _innerArray.Insert(index, item);
        }

        public T Remove(int index)
        {
            var item = _innerArray[index];
            _innerArray.RemoveAt(index);
            return (T)item;
        }
    }
}

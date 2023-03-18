using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusAlgoStruct
{
    public interface IArray<T>
    {
        int Size();
        void Add(T item);
        T Get(int index);

        void Add(T item, int index);
        T Remove(int index);
    }
}

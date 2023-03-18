using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusAlgoStruct
{
    public class MatrixArray<T> : IArray<T>
    {
        private int size;
        private int vector;
        private SingleArray<VectorArray<T>> array;

        public MatrixArray(int vector)
        {
            this.vector = vector;
            array = new SingleArray<VectorArray<T>>();
            size = 0;
        }

        public MatrixArray() : this(10) { }

        public int Size()
        {
            return size;
        }

        public void Add(T item)
        {
            if (size == array.Size() * vector)
            {
                array.Add(new VectorArray<T>(vector));
            }
            array.Get(size / vector).Add(item);
            size++;
        }

        public T Get(int index)
        {
            return array.Get(index / vector).Get(index % vector);
        }

        public void Add(T item, int index)
        {
            if (size == 0 && index == 0)
            {
                Add(item);
            }
            else if (index <= size)
            {
                SingleArray<VectorArray<T>> newArray = AddItemToArray(item, index);
                array = newArray;
            }
            else if (index < 0)
                throw new ArgumentOutOfRangeException($"index = {index}");
        }

        public T Remove(int index)
        {
            if (index > size || index < 0)
                throw new ArgumentOutOfRangeException($"index = {index}");
            T item = Get(index);

            bool isSecondSide = false;
            int newSize = 0;
            SingleArray<VectorArray<T>> newArray = new SingleArray<VectorArray<T>>();
            for (int i = 0; i < (size - 1); i++)
            {
                if (i == (size - 1) && isSecondSide == false)
                {
                    break;
                }
                else if (i == index && isSecondSide == false)
                {
                    isSecondSide = true;
                }
                else
                {
                    if (i == newArray.Size() * vector)
                    {
                        newArray.Add(new VectorArray<T>(vector));
                    }
                    var itemToInsert = Get(i);
                    newArray.Get(newSize / vector).Add(itemToInsert);
                    newSize++;
                }
            }
            size = newSize;
            array = newArray;
            return (T)item;
        }

        private SingleArray<VectorArray<T>> AddItemToArray(T item, int index)
        {
            bool isSecondSide = false;
            int newSize = 0;
            SingleArray<VectorArray<T>> newArray = new SingleArray<VectorArray<T>>();

            for (int i = 0; i < size; i++)
            {
                if (i == index && isSecondSide == false)
                {
                    if (index == newArray.Size() * vector)
                    {
                        newArray.Add(new VectorArray<T>(vector));
                    }
                    newArray.Get(newSize / vector).Add(item);
                    newSize++;
                }
                else if (isSecondSide == true)
                {
                    if (i == newArray.Size() * vector)
                    {
                        newArray.Add(new VectorArray<T>(vector));
                    }
                    var itemToInsert = Get(i - 1);
                    newArray.Get(newSize / vector).Add(itemToInsert);
                    newSize++;
                }
                else if (isSecondSide == false)
                {
                    if (i == newArray.Size() * vector)
                    {
                        newArray.Add(new VectorArray<T>(vector));
                    }
                    var itemToInsert = Get(i);
                    newArray.Get(newSize / vector).Add(itemToInsert);
                    newSize++;
                }
            }
            size = newSize;
            return newArray;
        }

        
    }
}

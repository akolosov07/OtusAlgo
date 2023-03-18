using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusAlgoStruct
{
    public class VectorArray<T> : IArray<T>
    {
        private object[] array;
        private int vector;
        private int size;

        public VectorArray(int vector)
        {
            this.vector = vector;
            array = new object[0];
            size = 0;
        }

        public VectorArray() : this(10)
        { }

        public int Size()
        {
            return size;
        }

        public void Add(T item)
        {
            if (Size() == array.Length || Size() == 0)
                Resize();
            array[size] = item;
            size++;
        }

        public T Get(int index)
        {
            return (T)array[index];
        }

        public void Add(T item, int index)
        {
            if (array.Length == 0)
            {
                Add(item);
            }
            else if (index == size && array.Length > size)
            {
                array[index] = item;
                size++;
            }
            else if (index == (array.Length - 1))
            {
                Add(item);
            }
            else if (index >= 0 && index < (array.Length - 1))
            {
                AddItemToArray(item, index);
            }
            else if (index < 0)
                throw new ArgumentOutOfRangeException($"index = {index}");
        }

        public T Remove(int index)
        {
            object item = new object();
            if (index > (size - 1) || index < 0)
                throw new ArgumentOutOfRangeException($"index = {index}");

            bool isSecondSide = false;
            object[] newArray = new object[size - 1];
            for (int i = 0; i < size; i++)
            {
                if (i == (size - 1) && isSecondSide == false)
                {
                    item = (T)array[i];
                    break;
                }
                else if (i == index && isSecondSide == false)
                {
                    item = (T)array[i];
                    isSecondSide = true;
                }
                else if (isSecondSide == true)
                {
                    newArray[i - 1] = (T)array[i];
                }
                else if (isSecondSide == false)
                {
                    newArray[i] = (T)array[i];
                }
            }
            array = newArray;
            size--;
            return (T)item;
        }

        private void AddItemToArray(T item, int index)
        {
            if (array[index] == null)
            {
                array[index] = item;
            }
            else
            {
                bool isSecondSide = false;
                object[] newArray = new object[Size() + vector];
                for (int i = 0; i < array.Length; i++)
                {
                    if (i < index && isSecondSide != true)
                    {
                        newArray[i] = array[i];
                    }
                    else if (i == index && isSecondSide != true)
                    {
                        newArray[i] = item;
                        newArray[i + 1] = array[i];
                        isSecondSide = true;
                    }
                    else if (isSecondSide == true)
                    {
                        newArray[i + 1] = array[i];
                    }
                }
                array = newArray;
                size++;
            }
        }

        private void Resize()
        {
            object[] newArray = new object[Size() + vector];
            Array.Copy(array, 0, newArray, 0, Size());
            array = newArray;
        }
    }
}

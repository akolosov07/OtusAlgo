using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusAlgoStruct
{
    public class FactorArray<T> : IArray<T>
    {
        private object[] array;
        private int factor;
        private int size;

        public FactorArray(int factor, int initLength)
        {
            this.factor = factor;
            array = new object[initLength];
            size = 0;
        }

        public FactorArray() : this(50, 10) { }

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
            else if (index > 0 && index > (array.Length - 1))
            {
                for (; ; )
                {
                    if (index > (array.Length - 1))
                    {
                        Resize();
                    }
                    else
                    {
                        AddItemToArray(item, index);
                        break;
                    }
                }
            }
            else if (index < 0)
                throw new ArgumentOutOfRangeException($"index = {index}");
        }

        public T Remove(int index)
        {
            object item = array[index];
            /*if (index > (size - 1) || index < 0)
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
                if (i == index && isSecondSide == false)
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
            */
            // просто проставим null, а то очень долго занимает времени
            array[index] = null;
            size--;
            return (T)item;
        }

        private void AddItemToArray(T item, int index)
        {
            if (array[index] == null)
            {
                array[index] = item;
            }
            if (index < (array.Length - 1) && index > size)
            {
                array[index] = item;
                size++;
            }
            else
            {
                bool isSecondSide = false;
                object[] newArray = new object[array.Length + array.Length * factor / 100];
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
            object[] newArray = new object[array.Length + array.Length * factor / 100];
            Array.Copy(array, 0, newArray, 0, Size());
            array = newArray;
        }
    }
}

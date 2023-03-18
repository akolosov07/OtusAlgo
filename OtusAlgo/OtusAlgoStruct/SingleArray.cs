using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusAlgoStruct
{
    public class SingleArray<T> : IArray<T>
    {
        private object[] array;

        public SingleArray()
        {
            array = new object[0];
        }

        public int Size()
        {
            return array.Length;
        }

        public void Add(T item)
        {
            Resize();
            array[Size() - 1] = item;
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
            if (index > (array.Length - 1) || index < 0)
                throw new ArgumentOutOfRangeException($"index = {index}");
            if (index == (array.Length - 1))
            {
                Add(item);
            }
            if (index >= 0 && index < (array.Length - 1))
            {
                AddItemToArray(item, index);
            }
        }

        public T Remove(int index)
        {
            object item = new object();
            if (index > (array.Length - 1) || index < 0)
                throw new ArgumentOutOfRangeException($"index = {index}");

            bool isSecondSide = false;
            object[] newArray = new object[Size() - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i == (array.Length - 1) && isSecondSide == false)
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
                object[] newArray = new object[Size() + 1];
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
            }
        }

        private void Resize()
        {
            object[] newArray = new object[Size() + 1];
            Array.Copy(array, 0, newArray, 0, Size());
            array = newArray;
        }
        
    }
}

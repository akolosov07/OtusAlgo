using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusAlgoTree
{
    public class Tester
    {
        public void TestRandomSearch()
        {
            // Создадим массив из 100_000 элементов в случайном порядке
            var array = CreateUniqElArray(100_000, 0, 1_000_000);
            var binaryTree = new BinaryTree<int>(array[0], null);

            var timer = new Stopwatch();
            timer.Start();
            for (int i = 1; i < array.Length; i++)
            {
                binaryTree.Insert(array[i]);
            }
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            Console.WriteLine($"100_000 элементов fill time = {timeTaken.ToString(@"m\:ss\.fff")}");

            
        
            int[] arrayToSearch = new int[array.Length / 10];
            int arrayToSearchCounter = 0;
            Random r = new Random();
            while (arrayToSearchCounter < array.Length / 10)
            {
                var index = r.Next(0, array.Length);
                var item = array[index];
                if (!arrayToSearch.Contains(item))
                {
                    arrayToSearch[arrayToSearchCounter++] = item;
                }
            }


            timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                var itemToSearch = arrayToSearch[i];
                var findItem = binaryTree.Search(itemToSearch);
            }
            timer.Stop();
            timeTaken = timer.Elapsed;
            Console.WriteLine($"10_000 поиск time = {timeTaken.ToString(@"m\:ss\.fff")}");



            int[] arrayToDelete = new int[array.Length / 10];
            int arrayToDeleteCounter = 0;
            while (arrayToDeleteCounter < array.Length / 10)
            {
                var index = r.Next(0, array.Length);
                var item = array[index];
                if (!arrayToDelete.Contains(item))
                {
                    arrayToDelete[arrayToDeleteCounter++] = item;
                }
            }


            timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < arrayToDelete.Length; i++)
            {
                var itemToDelete = arrayToDelete[i];
                binaryTree.Remove(itemToDelete);
            }
            timer.Stop();
            timeTaken = timer.Elapsed;
            Console.WriteLine($"10_000 удаление time = {timeTaken.ToString(@"m\:ss\.fff")}");

        }
        
        public void TestAscSortSearch()
        {
            var array = CreateUniqElArray(10_000, 0, 1_000_000);
            array = array.OrderBy(x => x).ToArray();

            var binaryTree = new BinaryTree<int>(array[0], null);

            var timer = new Stopwatch();
            timer.Start();
            for (int i = 1; i < array.Length; i++)
            {
                binaryTree.Insert(array[i]);
            }
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            Console.WriteLine($"100_000 элементов fill time = {timeTaken.ToString(@"m\:ss\.fff")}");

            int[] arrayToSearch = new int[array.Length / 10];
            int arrayToSearchCounter = 0;
            Random r = new Random();
            while (arrayToSearchCounter < array.Length / 10)
            {
                var index = r.Next(0, array.Length);
                var item = array[index];
                if (!arrayToSearch.Contains(item))
                {
                    arrayToSearch[arrayToSearchCounter++] = item;
                }
            }

            timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                var itemToSearch = arrayToSearch[i];
                var findItem = binaryTree.Search(itemToSearch);
            }
            timer.Stop();
            timeTaken = timer.Elapsed;
            Console.WriteLine($"10_000 поиск time = {timeTaken.ToString(@"m\:ss\.fff")}");

            int[] arrayToDelete = new int[array.Length / 10];
            int arrayToDeleteCounter = 0;
            while (arrayToDeleteCounter < array.Length / 10)
            {
                var index = r.Next(0, array.Length);
                var item = array[index];
                if (!arrayToDelete.Contains(item))
                {
                    arrayToDelete[arrayToDeleteCounter++] = item;
                }
            }

            timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < arrayToDelete.Length; i++)
            {
                var itemToDelete = arrayToDelete[i];
                binaryTree.Remove(itemToDelete);
            }
            timer.Stop();
            timeTaken = timer.Elapsed;
            Console.WriteLine($"10_000 удаление time = {timeTaken.ToString(@"m\:ss\.fff")}");
        }

        /// <summary>
        /// Создание массива.
        /// </summary>
        /// <param name="N">Количество элемнентов</param>
        /// <param name="minValue">Минимальное значение элемента.</param>
        /// <param name="maxValue">Максимальное значение элемента.</param>
        /// <returns>Массив.</returns>
        private int[] CreateUniqElArray(int N, int minValue, int maxValue)
        {
            int[] array = new int[N];
            int counter = 0;
            while (counter < N)
            {
                Random r = new Random();
                var item = r.Next(minValue, maxValue);
                if (!array.Contains(item))
                {
                    array[counter++] = item;
                }
            }
            return array;
        }
        
    }
}

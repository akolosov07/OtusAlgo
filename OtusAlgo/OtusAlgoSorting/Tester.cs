using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusAlgoSorting
{
    public class Tester
    {
        public void TestItem(string sortingName, int elementsCount)
        {
            var timer = new Stopwatch();
            Sorting sort = new Sorting();

            sort.SetRandom(elementsCount);

            timer.Start();
            RunSort(sortingName, sort);
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            Console.WriteLine($"{sortingName} {elementsCount} time = {timeTaken.ToString(@"m\:ss\.fff")}");
        }

        public void RunSort(string sortingName, Sorting sort)
        {
            switch (sortingName)
            {
                case "Bubble":
                    sort.Bubble();
                    break;
                case "Insertion":
                    sort.Insertion();
                    break;
                case "Shell":
                    sort.Shell();
                    break;
                case "MergeSort":
                    sort.MergeSort();
                    break;
                case "QuickSort":
                    sort.QuickSort();
                    break;
                case "CountingSort":
                    sort.CountingSort();
                    break;
                case "RadixSort":
                    sort.RadixSort();
                    break;
                case "BucketSort":
                    sort.BucketSort();
                    break;
            }
        }
    }
}

using OtusAlgoSorting;

/*var countArray = new List<int>();
countArray.Add(100);
countArray.Add(1000);
countArray.Add(10_000);

var sortingAlgo = new List<string>();
sortingAlgo.Add("Bubble");
sortingAlgo.Add("Insertion");
sortingAlgo.Add("Shell");

foreach (var algo in sortingAlgo)
{
    foreach (var count in countArray)
    {
        Tester tester = new Tester();
        tester.TestItem(algo, count);
    }
}*/

Sorting sorting = new Sorting();
sorting.SetRandom(20);
sorting.SelectionSort();
Console.WriteLine("");

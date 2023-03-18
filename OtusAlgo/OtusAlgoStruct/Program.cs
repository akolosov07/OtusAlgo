
using OtusAlgoStruct;
using System.Diagnostics;

//Run_Add_Get_50_000_Elements();




Console.ReadKey();





static void Run_Add_Get_50_000_Elements()
{
    var timer = new Stopwatch();

    
    // SingleArray Add 100_000
    SingleArray<int> singleArray = new SingleArray<int>();

    timer = new Stopwatch();
    timer.Start();

    for (int i = 0; i < 100_000; i++)
    {
        singleArray.Add(i);
    }

    timer.Stop();
    TimeSpan timeSingleTaken = timer.Elapsed;

    Console.WriteLine($"SingleArray добавление = {timeSingleTaken.ToString(@"m\:ss\.fff")}");

    // SingleArray Add(i, i)
   
    SingleArray<int> singleArray2 = new SingleArray<int>();
    timer = new Stopwatch();
    timer.Start();

    for (int i = 0; i < 100_000; i++)
    {
        singleArray2.Add(i, i);
    }

    timer.Stop();
    TimeSpan timeSingleAdd2Taken = timer.Elapsed;

    Console.WriteLine($"SingleArray добавление 2 = {timeSingleAdd2Taken.ToString(@"m\:ss\.fff")}");

    // SingleArray Get

    timer = new Stopwatch();
    timer.Start();

    for (int i = 0; i < 100_000; i++)
    {
        singleArray.Get(i);
    }

    timer.Stop();
    TimeSpan timeSingleGetTaken = timer.Elapsed;

    Console.WriteLine($"SingleArray получение = {timeSingleGetTaken.ToString(@"m\:ss\.fff")}");

    // SingleArray Remove

    timer = new Stopwatch();
    timer.Start();
    
    for (int i = 99_999; i >= 0; i--)
    {
        singleArray.Remove(i);
    }

    timer.Stop();
    TimeSpan timeSingleRemoveTaken = timer.Elapsed;

    Console.WriteLine($"SingleArray удаление = {timeSingleRemoveTaken.ToString(@"m\:ss\.fff")}");
    







    
    // VectorArray Add 100_000
    VectorArray<int> vectorArray = new VectorArray<int>(10_000);
    timer = new Stopwatch();
    timer.Start();

    for (int i = 0; i < 100_000; i++)
    {
        vectorArray.Add(i);
    }

    timer.Stop();
    TimeSpan timeVectorTaken = timer.Elapsed;

    Console.WriteLine($"VectorArray добавление = {timeVectorTaken.ToString(@"m\:ss\.fff")}");

    // VectorArray Add(i, i)
    VectorArray<int> vectorArray2 = new VectorArray<int>(10_000);
    timer = new Stopwatch();
    timer.Start();

    for (int i = 0; i < 100_000; i++)
    {
        vectorArray2.Add(i, i);
    }

    timer.Stop();
    TimeSpan timeVectorAdd2Taken = timer.Elapsed;

    Console.WriteLine($"VectorArray добавление 2 = {timeVectorAdd2Taken.ToString(@"m\:ss\.fff")}");

    // VectorArray Get

    timer = new Stopwatch();
    timer.Start();

    for (int i = 0; i < 100_000; i++)
    {
        vectorArray.Get(i);
    }

    timer.Stop();
    TimeSpan timeVectorGetTaken = timer.Elapsed;

    Console.WriteLine($"VectorArray получение = {timeVectorGetTaken.ToString(@"m\:ss\.fff")}");


    // VectorArray Remove
    timer = new Stopwatch();
    timer.Start();

    for (int i = 99_999; i >= 0; i--)
    {
        vectorArray.Remove(i);
    }

    timer.Stop();
    TimeSpan timeVectorRemoveTaken = timer.Elapsed;

    Console.WriteLine($"VectorArray удаление = {timeVectorRemoveTaken.ToString(@"m\:ss\.fff")}");
    



    

    // FactorArray Add
    FactorArray<int> factorArray = new FactorArray<int>();
    timer = new Stopwatch();
    timer.Start();

    for (int i = 0; i < 100_000; i++)
    {
        factorArray.Add(i);
    }

    timer.Stop();
    TimeSpan timeFactorTaken = timer.Elapsed;

    Console.WriteLine($"FactorArray добавление = {timeFactorTaken.ToString(@"m\:ss\.fff")}");

    // FactorArray Add(i, i)
    FactorArray<int> factorArray2 = new FactorArray<int>();
    timer = new Stopwatch();
    timer.Start();

    for (int i = 0; i < 100_000; i++)
    {
        factorArray2.Add(i, i);
    }

    timer.Stop();
    TimeSpan timeFactorAddTaken = timer.Elapsed;

    Console.WriteLine($"FactorArray добавление 2 = {timeFactorAddTaken.ToString(@"m\:ss\.fff")}");

    // FactorArray Get
    timer = new Stopwatch();
    timer.Start();

    for (int i = 0; i < 100_000; i++)
    {
        factorArray.Get(i);
    }

    timer.Stop();
    TimeSpan timeFactorGetTaken = timer.Elapsed;

    Console.WriteLine($"FactorArray получение = {timeFactorGetTaken.ToString(@"m\:ss\.fff")}");

    // FactorArray Remove
    timer = new Stopwatch();
    timer.Start();

    for (int i = 99_999; i >= 0; i--)
    {
        factorArray.Remove(i);
    }

    timer.Stop();
    TimeSpan timeFactorRemoveTaken = timer.Elapsed;

    Console.WriteLine($"FactorArray удаление (только null проставляется, чтобы быстрее) = {timeFactorRemoveTaken.ToString(@"m\:ss\.fff")}");
    


    
    // MatrixArray Add
    MatrixArray<int> matrixArray = new MatrixArray<int>(10);
    timer = new Stopwatch();
    timer.Start();

    for (int i = 0; i < 100_000; i++)
    {
        matrixArray.Add(i);
    }

    timer.Stop();
    TimeSpan timeMatrixTaken = timer.Elapsed;

    Console.WriteLine($"MatrixArray добавление = {timeMatrixTaken.ToString(@"m\:ss\.fff")}");

    // MatrixArray Add(i, i)
    MatrixArray<int> matrixArray2 = new MatrixArray<int>(10);
    timer = new Stopwatch();
    timer.Start();

    for (int i = 0; i < 100_000; i++)
    {
        matrixArray2.Add(i, i);
    }

    timer.Stop();
    TimeSpan timeMatrixAddTaken = timer.Elapsed;

    Console.WriteLine($"MatrixArray добавление 2 = {timeMatrixAddTaken.ToString(@"m\:ss\.fff")}");

    // MatrixArray Get
    timer = new Stopwatch();
    timer.Start();

    for (int i = 0; i < 100_000; i++)
    {
        matrixArray.Get(i);
    }

    timer.Stop();
    TimeSpan timeMatrixGetTaken = timer.Elapsed;

    Console.WriteLine($"MatrixArray получение = {timeMatrixGetTaken.ToString(@"m\:ss\.fff")}");

    // MatrixArray Remove
    timer = new Stopwatch();
    timer.Start();

    for (int i = 99_999; i >= 0; i--)
    {
        // matrixArray.Remove(i);
    }

    timer.Stop();
    TimeSpan timeMatrixRemoveTaken = timer.Elapsed;

    Console.WriteLine($"MatrixArray Remove - долго - надоело ждать");
    





    // ArrayListWrapper Add
    ArrayListWrapper<int> arrayListWrapper = new ArrayListWrapper<int>();
    timer = new Stopwatch();
    timer.Start();

    for (int i = 0; i < 100_000; i++)
    {
        arrayListWrapper.Add(i);
    }

    timer.Stop();
    TimeSpan timeArrayWrapperTaken = timer.Elapsed;

    Console.WriteLine($"ArrayListWrapper добавление = {timeArrayWrapperTaken.ToString(@"m\:ss\.fff")}");

    // ArrayListWrapper Add(i, i)
    ArrayListWrapper<int> arrayListWrapper2 = new ArrayListWrapper<int>();
    timer = new Stopwatch();
    timer.Start();

    for (int i = 0; i < 100_000; i++)
    {
        arrayListWrapper2.Add(i, i);
    }

    timer.Stop();
    TimeSpan timeArrayListWrapper2AddTaken = timer.Elapsed;

    Console.WriteLine($"ArrayListWrapper добавление 2 = {timeArrayListWrapper2AddTaken.ToString(@"m\:ss\.fff")}");

    // ArrayListWrapper Get
    timer = new Stopwatch();
    timer.Start();

    for (int i = 0; i < 100_000; i++)
    {
        arrayListWrapper.Get(i);
    }

    timer.Stop();
    TimeSpan timeArrayListWrapperGetTaken = timer.Elapsed;

    Console.WriteLine($"ArrayListWrapper получение = {timeArrayListWrapperGetTaken.ToString(@"m\:ss\.fff")}");

    // ArrayListWrapper Remove
    timer = new Stopwatch();
    timer.Start();

    for (int i = 99_999; i >= 0; i--)
    {
        arrayListWrapper.Remove(i);
    }

    timer.Stop();
    TimeSpan timeArrayListWrapperRemoveTaken = timer.Elapsed;

    Console.WriteLine($"ArrayListWrapper удаление = {timeArrayListWrapperRemoveTaken.ToString(@"m\:ss\.fff")}");
}

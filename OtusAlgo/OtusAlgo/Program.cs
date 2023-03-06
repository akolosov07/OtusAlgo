// Количество счастливых билетиков
using OtusAlgo;

/*
LuckyTicket luckyTicket = new LuckyTicket();
var count = luckyTicket.GetCountLuckyTicket();
Console.WriteLine($"Количество счастливых билетиков = {count}");

// Количество счастливых билетиков через рекурсию
LuckyTicket luckyTicket2 = new LuckyTicket();
luckyTicket2.GetCountRecursive(3, 0, 0);
Console.WriteLine($"Количество счастливых билетиков через рекурсию = {luckyTicket2.RecursiveCount}");
*/

// Реализовать итеративный O(N) алгоритм возведения числа в степень.

AlgoComplexity algoComplexity = new AlgoComplexity();
var expResult = algoComplexity.Exponention(2, 8);
Console.WriteLine(expResult);

var fibr = algoComplexity.FibonacciRecursive(10);
Console.WriteLine(fibr);

var fibl = algoComplexity.FibonacciIterative(10);
Console.WriteLine(fibl);


// Количество счастливых билетиков
using OtusAlgo;

LuckyTicket luckyTicket = new LuckyTicket();
var count = luckyTicket.GetCountLuckyTicket();
Console.WriteLine($"Количество счастливых билетиков = {count}");

// Количество счастливых билетиков через рекурсию
LuckyTicket luckyTicket2 = new LuckyTicket();
luckyTicket2.GetCountRecursive(3, 0, 0);
Console.WriteLine($"Количество счастливых билетиков через рекурсию = {luckyTicket2.RecursiveCount}");
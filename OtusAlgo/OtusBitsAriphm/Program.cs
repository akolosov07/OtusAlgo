using OtusBitsAriphm;

//King king = new King();
//var kingMask = king.GetKingMoves(7);
//Console.WriteLine(kingMask);

//Knight knight = new Knight();
//var knightMask = knight.GetKnightMoves(7);
//Console.WriteLine(knightMask);

BitsCounter bitsCounter = new BitsCounter();
Console.WriteLine($"Bits1 = {bitsCounter.CounBits1(4202496)}");

Console.WriteLine($"Bits1 = {bitsCounter.CountBits2(4202496)}");
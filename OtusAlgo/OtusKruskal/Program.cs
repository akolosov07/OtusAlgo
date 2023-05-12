using OtusKruskal;

Kruskal k = new Kruskal(@"4
6
1 2 1
2 3 3
3 4 2
4 1 5
1 3 4
2 4 6");

k.BuildSpanningTree();
Console.WriteLine("Cost: " + k.Cost);
k.DisplayInfo();
Console.WriteLine("Press any key...");
Console.ReadKey();
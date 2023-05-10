using OtusKosarajus;

Graph g = new Graph(5);
g.addEdge(1, 0);
g.addEdge(0, 2);
g.addEdge(2, 1);
g.addEdge(0, 3);
g.addEdge(3, 4);

Console.WriteLine(
    "Связанные компоненты  "
    + "в графе " +
    "\r\n 1 -> 0 -> 3 -> 4" +
    "\n\r   \\ | " +
    "\n\r     2 " +
    "");
g.printSCCs();
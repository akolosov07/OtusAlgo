﻿using OtusDijkstra;

var g = new Graph();

//добавление вершин
g.AddVertex("A");
g.AddVertex("B");
g.AddVertex("C");
g.AddVertex("D");
g.AddVertex("E");
g.AddVertex("F");
g.AddVertex("G");

//добавление ребер
g.AddEdge("A", "B", 22);
g.AddEdge("A", "C", 33);
g.AddEdge("A", "D", 61);
g.AddEdge("B", "C", 47);
g.AddEdge("B", "E", 93);
g.AddEdge("C", "D", 11);
g.AddEdge("C", "E", 79);
g.AddEdge("C", "F", 63);
g.AddEdge("D", "F", 41);
g.AddEdge("E", "F", 17);
g.AddEdge("E", "G", 58);
g.AddEdge("F", "G", 84);

var dijkstra = new Dijkstra(g);
List<Edge> edges = dijkstra.FindShortestPath("A", "G");

foreach (Edge edge in edges)
{
    Console.WriteLine($"{edge.Src} --> {edge.Dest}");
}

Console.ReadLine();
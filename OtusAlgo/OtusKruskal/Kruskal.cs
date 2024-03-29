﻿

namespace OtusKruskal
{
    public class Edge
    {
        public int U;
        public int V;
        public double Weight;
    }

    internal class Kruskal
    {
        private const int MAX = 100;
        private int _edgesCount;
        private int _verticlesCount;
        private List<Edge> _edges;
        private int[,] tree;
        private int[] sets;

        public List<Edge> Edges { get { return _edges; } }
        public int VerticlesCount { get { return _verticlesCount; } }
        public double Cost { get; private set; }

        public Kruskal(string input)
        {
            tree = new int[MAX, 3];
            sets = new int[MAX];

            string[] lines = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            _verticlesCount = int.Parse(lines[0]);
            _edgesCount = int.Parse(lines[1]);
            _edges = new List<Edge>();

            _edges.Add(null);

            for (int i = 2; i < lines.Count(); i++)
            {
                string[] line = lines[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                _edges.Add(new Edge
                {
                    U = int.Parse(line[0]),
                    V = int.Parse(line[1]),
                    Weight = double.Parse(line[2])
                });
            }

            for (int i = 1; i <= _verticlesCount; i++) sets[i] = i;
        }

        private void ArrangeEdges(int k)
        {
            Edge temp;
            for (int i = 1; i < k; i++)
            {
                for (int j = 1; j <= k - i; j++)
                {
                    if (_edges[j].Weight > _edges[j + 1].Weight)
                    {
                        temp = _edges[j];
                        _edges[j] = _edges[j + 1];
                        _edges[j + 1] = temp;
                    }
                }
            }
        }

        private int Find(int vertex)
        {
            return (sets[vertex]);
        }

        private void Union(int v1, int v2)
        {
            if (v1 < v2)
                sets[v2] = v1;
            else
                sets[v1] = v2;
        }

        public void BuildSpanningTree()
        {
            int k = _verticlesCount;
            int i, t = 1;
            ArrangeEdges(k);
            Cost = 0;
            for (i = 1; i <= k; i++)
            {
                for (i = 1; i < k; i++)
                    if (Find(_edges[i].U) != Find(_edges[i].V))
                    {
                        tree[t, 1] = _edges[i].U;
                        tree[t, 2] = _edges[i].V;
                        Cost += _edges[i].Weight;
                        Union(_edges[t].U, _edges[t].V);
                        t++;
                    }
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("The Edges of the Minimum Spanning Tree are:");
            for (int i = 1; i < _verticlesCount; i++)
                Console.WriteLine(tree[i, 1] + " - " + tree[i, 2]);
        }
    }

}

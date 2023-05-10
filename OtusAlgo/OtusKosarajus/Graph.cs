using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusKosarajus
{
    /// <summary>
    /// https://www.geeksforgeeks.org/strongly-connected-components/
    /// </summary>
    public class Graph
    {
        private int V; // No. вершины
        private List<int>[] adj; // Список смежных вершин

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="v">вершина</param>
        public Graph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        // Функция добавления ребра в граф
        public void addEdge(int v, int w) { adj[v].Add(w); }

        // Рекурсивная функция для вывода DFS, начиная с v
        void DFSUtil(int v, bool[] visited)
        {
            // Пометка текущего узла как посещенного
            visited[v] = true;
            Console.Write(v + " ");

            List<int> i = adj[v];
            foreach (var n in i)
            {
                if (!visited[n])
                    DFSUtil(n, visited);
            }
        }

        Graph getTranspose()
        {
            Graph g = new Graph(V);
            for (int v = 0; v < V; v++)
            {
                foreach (int i in adj[v]) g.addEdge(i, v);
            }
            return g;
        }

        void fillOrder(int v, bool[] visited, Stack<int> stack)
        {
            // Помечаем текущий узел как посещенный
            visited[v] = true;

            foreach (var n in adj[v])
            {
                if (!visited[n])
                    fillOrder(n, visited, stack);
            }

            stack.Push(v);
        }

        /// <summary>
        /// Поиск и вывод на печать всех
        /// </summary>
        public void printSCCs()
        {
            Stack<int> stack = new Stack<int>();

            // Пометка всех вершин как не посещенных (для первого DFS)
            var visited = new bool[V];

            for (int i = 0; i < V; i++)
                if (visited[i] == false)
                    fillOrder(i, visited, stack);

            Graph gr = getTranspose();

            // Пометка всех вершин как не посещенных (для второго DFS)
            for (int i = 0; i < V; i++)
                visited[i] = false;

            // Обработка всех вершин
            while (stack.Count != 0)
            {
                int v = stack.Pop();

                // Вывод связанных вершин
                if (visited[v] == false)
                {
                    gr.DFSUtil(v, visited);
                    Console.WriteLine();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusDemoucron
{
    public class DemoucronAlgorithm
    {
        public List<List<int>> GetLevels(int[][] graph)
        {
            int[] sumArray = GetSumArray(graph);

            List<List<int>> levelList = new List<List<int>>();


            while(sumArray.Where(i => i > 0).ToList().Count > 0)
            {
                List<int> level = new List<int>();
                for (int i = 0; i < sumArray.Length; i++)
                {
                    if (sumArray[i] == 0)
                    {
                        level.Add(i);
                        sumArray[i] = -1;
                    }
                }

                if (level.Count > 0)
                {
                    for (int i = 0; i < level.Count; i++)
                    {
                        int[] line = graph[level[i]];

                        for (int j = 0; j < line.Length; j++)
                        {
                            if (sumArray[j] > 0)
                                sumArray[j] = sumArray[j] - line[j];
                        }
                    }
                }


                if (level.Count > 0) levelList.Add(level);
            }

            
            return levelList;
        }

        private int[] GetSumArray(int[][] graph)
        {
            int[] sumArray = new int[graph.Length];

            for (int i = 0; i < sumArray.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < graph.Length; j++)
                {
                    sum += graph[j][i];
                }
                sumArray[i] = sum;
            }

            return sumArray;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusAlgoTree
{
    /// <summary>
    /// Класс для создания произвольного массива.
    /// </summary>
    public class RandomArray
    {
        int[] A; // массив.
        int N; // длина массива.

        private void Init(int N)
        {
            this.N = N;
            A = new int[N];
        }

        public int[] SetRandom(int N)
        {
            Init(N);
            Random random = new Random();
            for (int j = 0; j < N; j++)
            {
                A[j] = random.Next(N);
            }
            return A;
        }
    }
}

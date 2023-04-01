using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusAlgoSorting
{
    public class Sorting
    {
        int[] A; // массив.
        int N; // длина массива.
        long cmp; // операция сравнения.
        long asg; // операция присваивания.

        private void Init(int N)
        {
            this.N = N;
            A = new int[N];
            cmp = 0;
            asg = 0;
        }

        private void Swap(int x, int y)
        {
            asg += 3;
            int t = A[x];
            A[x] = A[y];
            A[y] = t;
        }

        public void SetRandom(int N)
        {
            Init(N);
            Random random = new Random(12345);
            for (int j = 0; j < N; j++)
            {
                A[j] = random.Next(N);
            }
        }

        public void MergeSort()
        {
            Msort(0, N - 1);
        }

        private void Msort(int L, int R)
        {
            if (L >= R) return;
            int M = (L + R) / 2;
            Msort(L, M);
            Msort(M + 1, R);
            Merge(L, M, R);
        }

        private void Merge(int L, int M, int R)
        {
            int[] T = new int[R - L + 1];
            int a = L;
            int b = M + 1;
            int t = 0;
            while (a <= M && b <= R)
            {
                if (A[a] < A[b])
                {
                    T[t++] = A[a++];
                }
                else
                {
                    T[t++] = A[b++];
                }
            }
            while (a <= M)
                T[t++] = A[a++];
            while (b <= R)
                T[t++] = A[b++];

            for (int i = L; i <= R; i++)
                A[i] = T[i - L];
        }

        public void QuickSort()
        {
            Qsort(0, N - 1);
        }

        private void Qsort(int L, int R)
        {
            if (L >= R) return;
            int M = Split(L, R);
            Qsort(L, M - 1);
            Qsort(M + 1, R);
        }

        private int Split(int L, int R)
        {
            int P = A[R];
            int m = L - 1;
            for (int j = L; j <= R; j++)
            {
                if (A[j] <= P)
                {
                    Swap(++m, j);
                }
            }
            return m;
        }

        public void Bubble()
        {
            for (int j = N - 1; j >= 0; j--)
            {
                for (int i = 0; i < j ; i++)
                {
                    if ((++cmp > 0) && A[i] > A[i + 1])
                        Swap(i, i + 1);
                }
            }
        }

        public void Insertion()
        {
            for (int j = 0; j < N; j++)
            {
                for (int i = j - 1; i >= 0 && (++cmp > 0) && A[i] > A [i + 1]; i--)
                {
                    Swap(i, i + 1);
                }
            }
        }

        public void Shell()
        {
            for (int gap = N/2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < N; i++)
                {
                    for (int j = i; j > gap && (++cmp > 0) && A[j - gap] > A[j]; j -= gap)
                    {
                        Swap(j - gap, j);
                    }
                }
            }
        }

        public void SelectionSort()
        {
            for (int j = A.Length - 1; j > 0; j--)
                Swap(FindMax(j), j);
        }

        private int FindMax(int j)
        {
            int max = 0;
            for (int i = 1; i <= j; i++)
            {
                if (++cmp > 0 && A[i] > A[max])
                    max = i;
            }
            return max;
        }

        public void HeapSort()
        {
            for (int h = N /2 - 1; h >= 0; h--)
            {
                Heapify(h, N);
            }
            for (int j = N - 1; j > 0; j--)
            {
                Swap(0, j);
                Heapify(0, j);
            }
        }

        private void Heapify(int root, int size)
        {
            int X = root;
            int L = 2 * X + 1;
            int R = 2 * X + 2;
            if (L < size && A[L] > A[X]) X = L;
            if (R < size && A[R] > A[X]) X = R;
            if (X == root) return;
            Swap(root, X);
            Heapify(X, size);
        }

    }
}

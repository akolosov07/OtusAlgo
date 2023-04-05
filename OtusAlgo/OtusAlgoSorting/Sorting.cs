using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusAlgoSorting
{
    public class List
    {
        public int Value;
        public List Next;

        public List(int value) : this(value, null)
        {
        }

        public List(int value, List next)
        {
            Value = value;
            Next = next;
        }
    }

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

        public void BucketSort()
        {
            int minValue = A[0];
            int maxValue = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > maxValue)
                    maxValue = A[i];
                if (A[i] < minValue)
                    minValue = A[i];
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < A.Length; i++)
            {
                bucket[A[i] - minValue].Add(A[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        A[k] = bucket[i][j];
                        k++;
                    }
                }
            }
        }

        /// <summary>
        /// алгоритм поразрядкнй сортировки RadixSort
        /// </summary>
        public void RadixSort()
        {
            int n = A.Length;
            int max = A[0];

            //find largest element in the Array
            for (int i = 1; i < n; i++)
            {
                if (max < A[i])
                    max = A[i];
            }

            for (int place = 1; max / place > 0; place *= 10)
                RadixSort(place);
        }

        private void RadixSort(int place)
        {
            int n = A.Length;
            int[] output = new int[n];

            //range of the number is 0-9 for each place considered.
            int[] freq = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            //count number of occurrences in freq array
            for (int i = 0; i < n; i++)
                freq[A[i] / place % 10]++;

            //Change count[i] so that count[i] now contains actual
            //position of this digit in output[]
            for (int i = 1; i < 10; i++)
                freq[i] += freq[i - 1];

            //Build the output array
            for (int i = n - 1; i >= 0; i--)
            {
                output[freq[(A[i] / place) % 10] - 1] = A[i];
                freq[(A[i] / place) % 10]--;
            }

            for (int i = 0; i < n; i++)
                A[i] = output[i];
        }

        /// <summary>
        /// алгоритм сортировки подсчётом CountingSort
        /// </summary>
        public void CountingSort()
        {
            //поиск минимального и максимального значений
            var min = A[0];
            var max = A[0];
            foreach (int element in A)
            {
                if (element > max)
                {
                    max = element;
                }
                else if (element < min)
                {
                    min = element;
                }
            }

            //поправка
            var correctionFactor = min != 0 ? -min : 0;
            max += correctionFactor;

            var count = new int[max + 1];
            for (var i = 0; i < A.Length; i++)
            {
                count[A[i] + correctionFactor]++;
            }

            var index = 0;
            for (var i = 0; i < count.Length; i++)
            {
                for (var j = 0; j < count[i]; j++)
                {
                    A[index] = i - correctionFactor;
                    index++;
                }
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

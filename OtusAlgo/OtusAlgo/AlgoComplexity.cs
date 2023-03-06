using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusAlgo
{
    /// <summary> 
    /// Выполнить все пункты БЕЗ системы тестирования, проверить алгоритмы вручную.
    /// 01. +1 байт.Реализовать итеративный O(N) алгоритм возведения числа в степень.
    /// 02. +1 байт.Реализовать рекурсивный O(2^N) и итеративный O(N) алгоритмы поиска чисел Фибоначчи.
    /// 03. +1 байт.Реализовать алгоритм поиска количества простых чисел через перебор делителей, O(N^2).
    /// </summary>
    public class AlgoComplexity
    {
        /// <summary>
        /// Реализовать итеративный O(N) алгоритм возведения числа в степень.
        /// </summary>
        public int Exponention(int number, int n)
        {
            int d = number;
            int p = 1;

            while (n >= 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                    d = d * d;
                }                
                
                if (n % 2 == 1)
                {
                    n--;
                    p = p * d;
                }
            }

            return p;
        }

        /// <summary>
        /// Реализовать рекурсивный O(2^N) алгоритм поиска чисел Фибоначчи.
        /// </summary>
        public long FibonacciRecursive(long n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return (FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2));
            }
        }

        /// <summary>
        /// Реализовать итеративный O(N) алгоритм поиска чисел Фибоначчи.
        /// </summary>
        public long FibonacciIterative(long n)
        {
            long a = 1;
            long b = 1;

            for (int i = 3; i <= n; i++)
            {
                long f = a + b;

                a = b;
                b = f;
            }

            return b;
        }

        /// <summary>
        /// Реализовать алгоритм поиска количества простых чисел через перебор делителей, O(N^2).
        /// </summary>
        public long SimpleNumbers(long N)
        {
            return CalculatePrimesCount(N);
        }

        private long CalculatePrimesCount(long N)
        {
            var count = 0;
            var primes = new long[N / 2];

            primes[count++] = 2;

            for (var number = 3; number <= N; number++)
            {
                
                if(IsPrimeBaseOnPrimes(primes, number))
                {
                    primes[count++] = number;
                }
            }

            return count;
        }

        private bool IsPrimeBaseOnPrimes(long[] primes, long number)
        {
            var sqrt = Math.Sqrt(number);

            for (var i = 1; primes[i] < sqrt; i++)
            {
                if (number % primes[i] == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}

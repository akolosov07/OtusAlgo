using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusAlgo
{
    public class LuckyTicket
    {
        public int GetCountLuckyTicket()
        {
            var count = 0;

            for (var a1 = 0; a1 <= 9 ; a1++)
            {
                for (var a2 = 0; a2 <= 9 ; a2++)
                {
                    for (var a3 = 0; a3 <= 9 ; a3++)
                    {
                        var sumA = a1 + a2 + a3;

                        for (var b1 = 0; b1 <= 9; b1++)
                        {
                            for (var b2 = 0; b2 <= 9 ; b2++)
                            {

                                var requiredB3 = sumA - b2 - b1;

                                if (requiredB3 >= 0 && requiredB3 <= 9)
                                {
                                    count++;
                                }

                                /*for (var b3 = 0; b3 <= 9 ; b3++)
                                {
                                    if (sumA == b1 + b2 + b3)
                                    {
                                        count++;
                                    }
                                    
                                }*/
                            }
                        }
                    }
                }
            }

            return count;
        }

        public int RecursiveCount { get; set; } = 0;

        public void GetCountRecursive(int remainDigits, int sumA, int sumB)
        {
            if (remainDigits == 0)
            {
                if (sumA == sumB)
                {
                    RecursiveCount++;
                }

                return;
            }

            for (var a = 0; a <= 9; a++)
            {
                for (var b = 0; b <= 9 ; b++)
                {
                    GetCountRecursive(remainDigits - 1, sumA + a, sumB + b);
                }
            }

        }
    }
}

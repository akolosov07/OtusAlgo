using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusSubstringSearch
{
    public class SearchString
    {
        public int SearchFullScan(string text, string mask)
        {
            int t = 0;
            while (t <= text.Length - mask.Length)
            {
                int m = 0;
                while (m < mask.Length && text[t + m] == mask[m])
                    m++;
                if (m == mask.Length)
                    return t;
                t++;
            }
            return -1;
        }

        public int SearchBMH(string text, string mask)
        {
            int[] shift = CreateShift(mask);
            int t = 0;
            while (t <= text.Length - mask.Length)
            {
                int m = mask.Length - 1;
                while (m >= 0 && text[t + m] == mask[m])
                    m--;
                if (m < 0)
                    return t;
                t += shift[text[t + mask.Length - 1]];
            }
            return -1;
        }

        private int[] CreateShift(string mask)
        {
            int[] shift = new int[128];
            for (int i = 0; i < shift.Length; i++)
                shift[i] = mask.Length;
            for (int m = 0; m < mask.Length - 1; m++)
                shift[mask[m]] = mask.Length - m - 1;
            return shift;
        }
    }
}

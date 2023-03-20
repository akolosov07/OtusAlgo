using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusBitsAriphm
{
    public class BitsCounter
    {
        public int CounBits1(ulong mask)
        {
            int cnt = 0;
            while (mask > 0)
            {
                cnt += (int)(mask & 1);
                mask >>= 1;
            }
            return cnt;
        }

        public int CountBits2(ulong mask)
        {
            int cnt = 0;
            while (mask > 0)
            {
                cnt++;
                mask &= mask - 1;
            }
            return cnt;
        }
    }
}

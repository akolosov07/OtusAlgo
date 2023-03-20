using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusBitsAriphm
{
    public class Knight
    {
        public ulong GetKnightMoves(int pos)
        {
            ulong kingPosition = 1UL << pos;

            ulong mask =
                (kingPosition << 6)
                | (kingPosition << 15)
                ;
            return mask;
        }
    }
}

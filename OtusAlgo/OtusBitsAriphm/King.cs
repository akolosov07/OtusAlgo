using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusBitsAriphm
{
    /// <summary>
    /// Решить задачу про короля
    /// https://gekomad.github.io/Cinnamon/BitboardCalculator/
    /// </summary>
    public class King
    {
        public ulong GetKingMoves(int pos)
        {
            ulong kingPosition = 1UL << pos;

            ulong mask =
                (kingPosition >> 1)
                | (kingPosition << 7)
                | (kingPosition << 8)
                ;

            return mask;
        }
    }
}

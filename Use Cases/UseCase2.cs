using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder.Use_Cases
{
    class UseCase2
    {
        public int RollDice()
        {
            return new Random().Next(1, 7);
        }
    }
}

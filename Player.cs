using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class Player
    {
        private int position;

        public void setPosition(int position)
        {
            this.position = position;
        }

        public int getPosition()
        {
            return position;
        }
    }
}

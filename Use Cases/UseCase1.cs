﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder.Use_Cases
{
    class UseCase1
    {
        public Player InitialisePlayer()
        {
            Player player = new Player();
            player.setPosition(0);
            Console.Write("Player has been initialied");
            return player;
        }
    }
}
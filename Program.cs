﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeLadder.Use_Cases;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Problem");

            int roll;
            MovementLogic ml = new MovementLogic();
            //Use Case 1
            Player player = ml.InitialisePlayer();

            //Use Case 2
            roll = new MovementLogic().RollDice();
            Console.WriteLine("Player " + player.getName() + " has rolled a " + roll);

            //Use Case 3
            Console.WriteLine("Player " + player.getName() +" gets "+ ml.MovePlayer(player,roll) + " gets to " + player.getPosition());


            //Use Case 4,5,6
            ml.PlayGame(player);


            Player player2 = ml.InitialisePlayer();
            //Use Case 7
            ml.Play2PlayerGame(player, player2);

            //Temp Read Line
            Console.ReadLine();
        }
    }
}

using System;
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

            //Use Case 1
            Player player = new UseCase1().InitialisePlayer();

            //Use Case 2
            roll = new UseCase2().RollDice();
            Console.WriteLine("Player " + player.getName() + " has rolled a " + roll);


            //Temp Read Line
            Console.ReadLine();
        }
    }
}

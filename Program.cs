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

            //Use Case 1
            Player player = new UseCase1().InitialisePlayer();

            //Temp Read Line
            Console.ReadLine();
        }
    }
}

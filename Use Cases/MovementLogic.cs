using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder.Use_Cases
{
    class MovementLogic
    {
        public Player InitialisePlayer()
        {
            Player player = new Player();
            player.setPosition(0);

            Console.Write("Enter players Name :");
            player.setName(Console.ReadLine());
            Console.WriteLine("Player " + player.getName() + " has been initialied");

            return player;
        }

        public int RollDice()
        {
            return new Random().Next(1, 7);
        }

        public string MovePlayer(Player player, int roll)
        {
            int NO_PLAY = 0;
            int LADDER = 1;
            int SNAKE = 2;

            int choice = new Random().Next(0,3);

            if(choice==NO_PLAY)
            {
                return "NO PLAY";
            }
            else if(choice==LADDER)
            {
                player.setPosition(player.getPosition() + roll);
                return "LADDER";
            }
            else if(choice==SNAKE)
            {
                int newPos = player.getPosition() - roll > 0 ? player.getPosition() - roll : 0;
                player.setPosition(newPos);
                return "SNAKE";
            }
            else
            {
                return "Error";
            }

        }
    }
}

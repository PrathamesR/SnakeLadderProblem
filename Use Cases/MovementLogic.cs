using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder.Use_Cases
{
    class MovementLogic
    {
        static int newRoll=0;
        static int choice = 0;
        static int throwNumber = 0;

        Random rn = new Random();

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
            newRoll = rn.Next(1, 7);
            return newRoll;
        }

        public string MovePlayer(Player player, int roll)
        {
            int NO_PLAY = 0;
            int LADDER = 1;
            int SNAKE = 2;

            choice = rn.Next(0, 3);

            if (choice==NO_PLAY)
            {
                return "NO PLAY";
            }
            else if(choice==LADDER)
            {
                int newPos = player.getPosition() + roll <= 100 ? player.getPosition() + roll : player.getPosition();
                player.setPosition(newPos);
                return "LADDER";
            }
            else if(choice==SNAKE)
            {
                int newPos = player.getPosition() - roll > 0 ? player.getPosition() - roll :0;
                player.setPosition(newPos);
                return "SNAKE";
            }
            else
            {
                return "Error";
            }

        }

        public void PlayGame(Player player)
        { 
            int roll;
            player.setPosition(0);
            Console.WriteLine("\nIntitiated player to 0");
            while(player.getPosition()!=100)
            {
                roll = RollDice();
                throwNumber++;
                Console.WriteLine("Player:" + player.getName()+"\tThrow Number:" + throwNumber + "\tRoll:" + roll + "  Gets:" + MovePlayer(player, roll) + "\tFinal Position:" + player.getPosition());
            }

            Console.Write(player.getName()+" has finished the game.");
        }
    }
}

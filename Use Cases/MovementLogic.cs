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

            Console.WriteLine(player.getName()+" has finished the game.");
        }

        public void Play2PlayerGame(Player p1, Player p2)
        {
            p1.setPosition(0);
            p2.setPosition(0);
            throwNumber = 0;
            Console.WriteLine("Initated both players location to 0");
            int roll;
            string winner = null;
            while(winner==null)
            {
                throwNumber++;
                roll = RollDice();
                Console.Write("\nThrow Number:" + throwNumber);
                Console.Write(" Player:" + p1.getName() +"\tRoll:"+roll + "  Gets:" + MovePlayer(p1,roll)+"\tFinal Position:"+p1.getPosition());
                if (p1.getPosition() == 100)
                {
                    winner = p1.getName();
                    break;
                }
                roll = RollDice();
                Console.Write("\nThrow Number:" + throwNumber);
                Console.Write(" Player:" + p2.getName() + "\tRoll:" + roll + "  Gets:" + MovePlayer(p2, roll) + "\tFinal Position:" + p2.getPosition());
                if(p2.getPosition() == 100)
                {
                    winner = p2.getName();
                }
            }

            Console.WriteLine("\nThe winner is " + winner);
        }
    }
}

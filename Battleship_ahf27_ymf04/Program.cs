using Battleship_ahf27_ymf04.Objects;
using Battleship_ahf27_ymf04.Objects.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_ahf27_ymf04
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1Wins = 0, player2Wins = 0;
            Console.WriteLine("Welcome to Ali Fayad's - ahf27 and Yehya Farhat's battleships part 1");
            Console.WriteLine("Firing position: the positions are indicated on the board:\nexample: 25 gives 2,5     ;    2 or 02 gives 0,2\nu can only enter one argument between 0 and 99");
            Console.WriteLine("How many games do you want to play?");
            var numGames = int.Parse(Console.ReadLine());
            for (int i = 0; i < numGames; i++)
            {
                Game game1 = new Game();
                game1.PlayToEnd();
                if(game1.Player1.HasLost)
                {
                    player2Wins++;
                }
                else
                {
                    player1Wins++;
                }
            }

            Console.WriteLine("Player 1 Wins: " + player1Wins.ToString());
            Console.WriteLine("Player 2 Wins: " + player2Wins.ToString());
            Console.ReadLine();
           
        }
    }
}

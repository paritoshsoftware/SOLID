
using Models;
using System.Collections.Generic;

namespace Game
{
    public class GameController
    {

        public Queue<Player> Players { get; set; }

        public Board Board { get; set; }



        public void InitiliazeGame()
        {
            Players = new Queue<Player>();
            Player player1;
            Player player2;
            Console.WriteLine("Please Enter Player 1 Your Name");
            while(true)
            {
                string X = Console.ReadLine();
                if (string.IsNullOrEmpty(X))
                {
                    continue;
                }
                else
                {
                    player1 = new Player(X, new PlayerPeiceO());
                }
                break;
            }

            Console.WriteLine("Please Enter Player 2 Your Name");
            while (true)
            {
                string X = Console.ReadLine();
                if (string.IsNullOrEmpty(X))
                {
                    continue;
                }
                else
                {
                    player2 = new Player(X, new PlayerPeiceX());
                }
                break;
            }



            Console.WriteLine("Player 1 " + player1.Name + "Symbol "+ player1.PlayerPeice.ToString());
            Console.WriteLine("Player 2 " + player2.Name + "Symbol " + player2.PlayerPeice.ToString());

            Players.Enqueue(player1);
            Players.Enqueue(player2);

           

            

            Board = new Board(5);

            Board.PrintBoard();



        }

    }
}

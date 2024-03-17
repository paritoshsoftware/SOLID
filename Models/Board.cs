using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Board
    {

        public int size { get; set; }

        public PlayerPeice[,] board {  get; set; }

        public Board(int size)
        {
            this.size = size;
            this.board = new PlayerPeice[size,size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = null;
                }

                
            }
        }

        public void PrintBoard()
        {
            for(int i = 0; i < size; i++)
            {
                for(int j=0; j < size; j++)
                {
                    if (this.board[i,j] == null)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(this.board[i,j].peieceType.ToString() + " ");
                    }
                    Console.Write(" | ");
                }
                Console.WriteLine();

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Game
    {
        private char[,] board = 
        {
            { '0', '1', '2' },
            { '3', '4', '5' },
            { '6', '7', '8' }
        };

        private int player = 1;

        public Game() { }

        public void Start()
        {
                DrawBoard();

                var cell = Console.ReadKey();
                Console.WriteLine(cell);
            /*
            do
            {

                
            } while (true); */
        }

        public void ChangeCellValue(int x, int y, char value)
        {
            board[x, y] = value;
        } 

        public void DrawBoard()
        {
            char a, b, c;
            
            var whiteLine = "|  {0}  |  {1}  |  {2}  |";
            var line = "|-----|-----|-----|";

            for (int i = 0; i < this.board.GetLength(0); i++)
            {
                a = this.board[i, 0];
                b = this.board[i, 1];
                c = this.board[i, 2];
                Console.WriteLine(line);
                Console.WriteLine(whiteLine, a, b, c);
            }

            Console.WriteLine(line);
        }
    }
}

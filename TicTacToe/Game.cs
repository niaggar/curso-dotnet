using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Game
    {

        private int player = 1;
        private char playerIcon = 'X';
        private char[,] board = 
        {
            { '0', '1', '2' },
            { '3', '4', '5' },
            { '6', '7', '8' }
        };


        public void Start()
        {
            var test = '1'.Equals($"{1}");
            Console.WriteLine(test);

            do
            {
                bool inputCorrect;
                int input;
                
                DrawBoard();

                do
                {
                    Console.WriteLine("Wich position do you want Player {0}?", this.player);
                    string inputText = Console.ReadLine();
                    inputCorrect = int.TryParse(inputText, out input);

                    if (!(input >= 0 && input <= 8) || !inputCorrect)
                    {
                        Console.WriteLine("Enter a valid value");
                        inputCorrect = false;
                    }

                    if (inputCorrect)
                    {
                        bool isSelected = CheckIfIsSelected(input);
                        inputCorrect = !isSelected;

                        if (isSelected)
                            Console.WriteLine("The position is already selected, please select another one");
                    }

                } while (!inputCorrect);

                SelectField(input, playerIcon);
                ChangePlayer();

            } while (true);
        }

        private bool CheckIfIsSelected(int input)
        { 
            foreach (char character in this.board)
            {
                if (character.Equals(char.Parse($"{input}")))
                    return false;
            }

            return true;
        }

        private void SelectField(int position, char c)
        {
            switch (position)
            {
                case 0: ChangeCellValue(0, 0, c); 
                    break;
                case 1: ChangeCellValue(0, 1, c); 
                    break;
                case 3: ChangeCellValue(1, 0, c); 
                    break;
                case 4: ChangeCellValue(1, 1, c); 
                    break;
                case 5: ChangeCellValue(1, 2, c); 
                    break;
                case 6: ChangeCellValue(2, 0, c); 
                    break;
                case 2: ChangeCellValue(0, 2, c); 
                    break;
                case 7: ChangeCellValue(2, 1, c); 
                    break;
                case 8: ChangeCellValue(2, 2, c); 
                    break;
                default: Console.WriteLine("Error"); 
                    break;
            }
        }

        private void ChangeCellValue(int x, int y, char value)
        {
            board[x, y] = value;
        }

        private void ChangePlayer()
        {
            if (this.player == 1)
            {
                this.player = 2;
                this.playerIcon = 'O';
            }
            else
            {
                this.player = 1;
                this.playerIcon = 'X';
            }
        }

        public void DrawBoard()
        {
            char a, b, c;
            
            var whiteLine = "|  {0}  |  {1}  |  {2}  |";
            var line = "|-----|-----|-----|";

            Console.Clear();
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

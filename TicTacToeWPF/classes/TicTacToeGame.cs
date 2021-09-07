using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TicTacToeWPF.utils;

namespace TicTacToeWPF.classes
{
    public class TicTacToeGame : IGame, INotifyPropertyChanged
    {
        // Forma de indicar a la interfaz que una propiedad fue modificada y permitir
        // que el valor sea reflejado en la interfaz
        public event PropertyChangedEventHandler PropertyChanged;
        // Al usar "CallerMemberName" no es necesario especificar el nombre de la propiedad
        // modificada a menos de que se llame al metodo fuera de el "set" de la propiedad
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Tablero principal que almacena los estados actuales de la partida
        private char[,] Board { get; set; } = 
        {
            { '0', '0', '0' },
            { '0', '0', '0' },
            { '0', '0', '0' }
        };

        // Propiedad auxiliar que permite representar mediante binding el estado actual 
        // del tablero en los botones
        public char[] BoardShow => ConvertBoartToShow();
        private char[] ConvertBoartToShow()
        {
            List<char> res = new List<char>();

            for (int x = 0; x < Board.GetLength(0); x++)
            {
                for (int y = 0; y < Board.GetLength(1); y++)
                {
                    char c = Board[x, y] == '0' ? '?' : Board[x, y];
                    res.Add(c);
                }
            }

            return res.ToArray();
        }

        // Almacen de los datos referentes a los jugadores, tanto como el jugador actual como
        // el simbolo que representa a cada jugador
        private string _player = "1";
        public string Player
        {
            get => _player;
            set
            {
                _player = value;
                NotifyPropertyChanged();
            }
        }
        private Dictionary<string, char> Players = new Dictionary<string, char>()
        {
            { "1", 'X' },
            { "2", 'O' }
        };

        public void ChangePlayer()
        {
            Player = Player == "1" ? "2" : "1";
        }

        public void Finish()
        {
            throw new NotImplementedException();
        }

        public void ShowResults()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            Player = "1";
        }

        public void Restart()
        {
            Board = new char[,]
            {
                { '0', '0', '0' },
                { '0', '0', '0' },
                { '0', '0', '0' }
            };
            Player = "1";
            NotifyPropertyChanged("BoardShow");
        }

        public void ChangeBoardValue(int x, int y)
        {
            Board[x, y] = Players[Player];
            NotifyPropertyChanged("BoardShow");
        }

        public char GetBoardValue(int x, int y)
        {
            return Board[x, y];
        }

        public bool CheckTheWinner()
        {
            bool winer = false;

            foreach (var entry in Players)
            {
                if (Board[0, 0] == entry.Value && Board[1, 1] == entry.Value && Board[2, 2] == entry.Value)
                    winer = true;
                else if (Board[0, 2] == entry.Value && Board[1, 1] == entry.Value && Board[2, 0] == entry.Value)
                    winer = true;

                else
                    for (int i = 0; i < Board.GetLength(0); i++)
                    {
                        if (Board[i, 0] == entry.Value && Board[i, 1] == entry.Value && Board[i, 2] == entry.Value)
                            winer = true;
                        else if (Board[0, i] == entry.Value && Board[1, i] == entry.Value && Board[2, i] == entry.Value)
                            winer = true;
                    }
            }

            return winer;
        }
    }
}

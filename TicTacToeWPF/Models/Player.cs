using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWPF.Models
{
    public class Player
    {
        public string Name { get; set; }
        public char Simbol { get; set; }

        public bool Equals(Player player)
        {
            return this.Name == player.Name && this.Simbol == player.Simbol;
        }
    }
}

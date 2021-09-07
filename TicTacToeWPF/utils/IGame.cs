using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWPF.utils
{
    interface IGame
    {
        void Start();
        void Finish();
        void ShowResults();
        void Restart();
    }
}

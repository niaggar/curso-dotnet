using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TicTacToeWPF.classes;

namespace TicTacToeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TicTacToeGame game;

        public MainWindow()
        {
            InitializeComponent();

            this.game = new TicTacToeGame();
            this.game.Start();

            this.DataContext = this.game;
        }

        private void HandleButtonBoardClick(object sender, RoutedEventArgs e)
        { 
            Button buttonClicked = sender as Button;
            buttonClicked.IsEnabled = false;

            int x = Grid.GetRow(buttonClicked) - 1;
            int y = Grid.GetColumn(buttonClicked);

            this.game.ChangeBoardValue(x, y);


            if (this.game.CheckTheWinner())
            {
                MessageBox.Show($"The winner is {this.game.Player}");
                this.game.Restart();
                ResetButtons();
            }
            else
            {
                this.game.ChangePlayer();
            }
        }

        private void ResetButtons()
        {
            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            this.game.Restart();
            ResetButtons();
        }
    }
}

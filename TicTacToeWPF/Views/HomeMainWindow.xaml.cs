namespace TicTacToeWPF.Views
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Controls;
    using TicTacToeWPF.Models;
    using TicTacToeWPF.views;

    /// <summary>
    /// Interaction logic for HomeMainWindow.xaml.
    /// </summary>
    public partial class HomeMainWindow : UserControl, INotifyPropertyChanged
    {
        #region PropertyChange
        /// <summary>
        /// Defines the PropertyChanged.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The OnPropertyRaised.
        /// </summary>
        /// <param name="propertyname">The propertyname<see cref="string"/>.</param>
        private void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
        #endregion

        /// <summary>
        /// Gets or sets the FirstPlayer.
        /// </summary>
        public Player FirstPlayer { get; set; } = new Player();

        /// <summary>
        /// Gets or sets the SecondPlayer.
        /// </summary>
        public Player SecondPlayer { get; set; } = new Player();

        /// <summary>
        /// Defines the _ListPlayers.
        /// </summary>
        private ObservableCollection<Player> _ListPlayers;

        /// <summary>
        /// Gets or sets the ListPlayers.
        /// </summary>
        public ObservableCollection<Player> ListPlayers
        {
            get => _ListPlayers;
            set
            {
                _ListPlayers = value;
                OnPropertyRaised("ListPlayers");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeMainWindow"/> class.
        /// </summary>
        public HomeMainWindow()
        {
            InitializeComponent();

            ObservableCollection<Player> players = new ObservableCollection<Player>()
            {
                new Player() { Name = "Nicolas", Simbol = 'X' },
                new Player() { Name = "Lina", Simbol = 'O' },
                new Player() { Name = "Leonor", Simbol = 'W' },
                new Player() { Name = "Rafael", Simbol = 'Z' }
            };
            ListPlayers = players;
        }

        /// <summary>
        /// The ListBox_SelectionChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="SelectionChangedEventArgs"/>.</param>
        private void ListBoxFirstSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Player firstPlayer = (Player)e.AddedItems[0];
                ListBox listBox = sender as ListBox;

                if (SecondPlayer.Equals(firstPlayer))
                {
                    MessageBox.Show("The player is already selected");

                    listBox.SelectedIndex = -1;
                    FirstPlayer = new Player();

                    return;
                }

                FirstPlayer = firstPlayer;
            }
            catch (System.Exception) { }
        }

        /// <summary>
        /// The ListBox_SelectionChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="SelectionChangedEventArgs"/>.</param>
        private void ListBoxSecondSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Player secondPlayer = (Player)e.AddedItems[0];
                ListBox listBox = sender as ListBox;

                if (FirstPlayer.Equals(secondPlayer))
                {
                    MessageBox.Show("The player is already selected");

                    listBox.SelectedIndex = -1;
                    SecondPlayer = new Player();

                    return;
                }

                SecondPlayer = secondPlayer;
            }
            catch (System.Exception) { }
        }

        private void StartGameClick(object sender, RoutedEventArgs e)
        {
            if (FirstPlayer.Equals(new Player()) || SecondPlayer.Equals(new Player()))
            {
                MessageBox.Show("To start the game first select the players.");
                return;
            }

            GameWindow gameWindow = new GameWindow(FirstPlayer, SecondPlayer);
            gameWindow.ShowDialog();
        }
    }
}

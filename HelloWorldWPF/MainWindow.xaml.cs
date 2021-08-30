using System;
using System.Collections.Generic;
using System.Linq;
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

namespace HelloWorldWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Muestra un mensaje de alerta que permite tener ciertos botones predefinidos
            MessageBoxResult result = MessageBox.Show("Solo estoy saludando!", "No me prestes atencion", MessageBoxButton.YesNo);
            if (((int)result) == 6)
            {
                Close();
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Muestra un simple mensaje que puede ser cerrardo
            MessageBox.Show("La seleccion cambio");
        }
    }
}

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
using CalculadoraWPF.Helpers;
using CalculadoraWPF.Classes;

namespace CalculadoraWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string ActualNumTxt { get; set; }
        public double prevNum = 0;

        private Operations actualOperation;

        public MainWindow()
        {
            InitializeComponent();

            ActualNumTxt = "0";
            acButton.Click += AcButton_Click;
            moreLessButton.Click += MoreLessButton_Click;
            simbolEqualsButton.Click += SimbolEqualsButton_Click;
        }

        /// <summary>
        /// Metodo encargado de realizar las operaciones correspondientes
        /// </summary>
        private void SimbolEqualsButton_Click(object sender, RoutedEventArgs e)
        {
            double actualNum = double.Parse(ActualNumTxt);
            double result = 0;

            switch(actualOperation)
            {
                case Operations.Addition:
                    result = Calculator.Add(prevNum, actualNum);
                    break;
                case Operations.Subtraction:
                    result = Calculator.Subtrac(prevNum, actualNum);
                    break;
                case Operations.Multiplication:
                    result = Calculator.Multiply(prevNum, actualNum);
                    break;
                case Operations.Division:
                    result = Calculator.Divide(prevNum, actualNum);
                    break;
            }

            ActualNumTxt = $"{result}";
            prevNum = 0;
            actualOperation = Operations.Addition;

            UpdateResultLabel();
        }

        /// <summary>
        /// Metodo encargado de determinar que operacion matematica esta actualemente seleccionada
        /// </summary>
        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            prevNum = double.Parse(ActualNumTxt);

            ActualNumTxt = "0";
            UpdateResultLabel();

            actualOperation = sender == simbolAdditionButton ? Operations.Addition : actualOperation;
            actualOperation = sender == simbolDivisionButton ? Operations.Division : actualOperation;
            actualOperation = sender == simbolSubtractionButton ? Operations.Subtraction : actualOperation;
            actualOperation = sender == simbolMultiplicationButton ? Operations.Multiplication : actualOperation;
        }

        /// <summary>
        /// Metodo encargado de controlar como se muestra y almcenan los numeros seleccionados por el
        /// usuario
        /// </summary>
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button buttonClick = sender as Button;

            if (buttonClick.Content.ToString() == "." && ActualNumTxt == "0")
            {
                ActualNumTxt = $"0{buttonClick.Content}";
                UpdateResultLabel();
                return;
            }

            if (buttonClick.Content.ToString() == "." && ActualNumTxt.Contains("."))
                return;

            ActualNumTxt = ActualNumTxt == "0" ? buttonClick.Content.ToString() : $"{ActualNumTxt}{buttonClick.Content}";
            UpdateResultLabel();
        }

        /// <summary>
        /// Cambiar de simbolo el numero que se esta modificando
        /// </summary>
        private void MoreLessButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Restaurar a cero el resultado de la operacion
        /// </summary
        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            ActualNumTxt = "0";
            UpdateResultLabel();
        }

        /// <summary>
        /// Metod que actualiza el texto que se muestra en la interfaz resultLabel
        /// </summary>
        private void UpdateResultLabel()
        {
            resultLabel.Content = ActualNumTxt;
        }
    }
}

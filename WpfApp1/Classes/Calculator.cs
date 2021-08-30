using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraWPF.Classes
{
    class Calculator
    {
        public Calculator() { }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtrac(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static double Percentage(double a)
        {
            return a / 100;
        }
    }
}

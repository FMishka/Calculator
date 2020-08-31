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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double firstNumber, secondNumber;
        private char arithmeticOperation = ' ';
        private bool haveDot = false, isEqually = false;
        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (isEqually)
            {
                Cleaning();
                isEqually = false;
            }
            if (result.Text.Length == 12)
            {

            }
            else
            {
                result.Text += "0";

            }
        }
        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (isEqually)
            {
                Cleaning();
                isEqually = false;
            }
            if (result.Text.Length == 12)
            {

            }
            else
            {
                result.Text += "1";

            }
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (isEqually)
            {
                Cleaning();
                isEqually = false;
            }
            if (result.Text.Length == 12)
            {

            }
            else
            {
                result.Text += "2";

            }
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (isEqually)
            {
                Cleaning();
                isEqually = false;
            }
            if (result.Text.Length == 12)
            {

            }
            else
            {
                result.Text += "3";

            }
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (isEqually)
            {
                Cleaning();
                isEqually = false;
            }
            if (result.Text.Length == 12)
            {

            }
            else
            {
                result.Text += "4";

            }
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (isEqually)
            {
                Cleaning();
                isEqually = false;
            }
            if (result.Text.Length == 12)
            {

            }
            else
            {
                result.Text += "5";

            }
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (isEqually)
            {
                Cleaning();
                isEqually = false;
            }
            if (result.Text.Length == 12)
            {

            }
            else
            {
                result.Text += "6";

            }
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (isEqually)
            {
                Cleaning();
                isEqually = false;
            }
            if (result.Text.Length == 12)
            {

            }
            else
            {
                result.Text += "7";

            }
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (isEqually)
            {
                Cleaning();
                isEqually = false;
            }
            if (result.Text.Length == 12)
            {

            }
            else
            {
                result.Text += "8";

            }
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (isEqually)
            {
                Cleaning();
                isEqually = false;
            }
            if (result.Text.Length == 12)
            {
                
            }
            else
            {
                result.Text += "9";
            }
        }

        private void equally_Click(object sender, RoutedEventArgs e)
        {
            secondNumber = Convert.ToDouble(result.Text);
            switch (arithmeticOperation)
            {
                case '+':
                    result.Text = Convert.ToString(firstNumber + secondNumber);
                    break;
                case '-':
                    result.Text = Convert.ToString(firstNumber - secondNumber);
                    break;
                case '*':
                    result.Text = Convert.ToString(firstNumber * secondNumber);
                    break;
                case '/':
                    result.Text = Convert.ToString(firstNumber / secondNumber);
                    break;
            }
            arithmeticOperation = ' ';
            isEqually = true;
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if (result.Text != "")
            {
                arithmeticOperation = '+';
                firstNumber = Convert.ToDouble(result.Text);
                haveDot = false;
                Cleaning();
            }
        }
        private void Cleaning()
        {
            result.Text = "";
            haveDot = false;
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            if (result.Text != "")
            {
                arithmeticOperation = '-';
                firstNumber = Convert.ToDouble(result.Text);
                haveDot = false;
                Cleaning();
            }
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            if (result.Text != "")
            {
                arithmeticOperation = '/';
                firstNumber = Convert.ToDouble(result.Text);
                haveDot = false;
                Cleaning();
            }
        }

        private void mult_Click(object sender, RoutedEventArgs e)
        {
            if (result.Text != "")
            {
                arithmeticOperation = '*';
                firstNumber = Convert.ToDouble(result.Text);
                haveDot = false;
                Cleaning();
            }
        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            if (haveDot != true)
            {
                result.Text += ",";
                haveDot = true;
            }

        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Cleaning();
            firstNumber = 0;
            secondNumber = 0;
            arithmeticOperation = ' ';
            haveDot = false;
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

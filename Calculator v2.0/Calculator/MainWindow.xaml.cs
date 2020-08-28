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
        public MainWindow()
        {
            InitializeComponent();
        }
            private void button_Click(object sender, RoutedEventArgs e)
            {
                double firstNumber, secondNumber;
                try
                {
                    firstNumber = Convert.ToDouble(textBox.Text);
                    secondNumber = Convert.ToDouble(textBox1.Text);
                    switch (comboBox.Text)
                    {
                        case "+":
                            textBox2.Text = Convert.ToString(firstNumber + secondNumber);
                            break;
                        case "-":
                            textBox2.Text = Convert.ToString(firstNumber - secondNumber);
                            break;
                        case "*":
                            textBox2.Text = Convert.ToString(firstNumber + secondNumber);
                            break;
                        case "/":
                            if (secondNumber != 0)
                            {
                                textBox2.Text = Convert.ToString(firstNumber + secondNumber);
                                break;
                            }
                            else
                            {
                                textBox2.Text = "На ноль делить нельзя!";
                                break;
                            }
                        case "":
                            MessageBox.Show("Выберите арифметическую операцию!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    textBox2.Text = "Введён неверный символ!";
                }

            }
            private void button1_Click(object sender, RoutedEventArgs e)
            {
                textBox.Text = "0";
                textBox1.Text = "0";
                textBox2.Text = "";
                comboBox.Text = "";
            }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}

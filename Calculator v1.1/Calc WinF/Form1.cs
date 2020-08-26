using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_WinF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstNumber, secondNumber;
            firstNumber = Convert.ToDouble(textBox1.Text);
            secondNumber = Convert.ToDouble(textBox2.Text);
            switch (comboBox1.Text)
            {
                case "+":
                    textBox3.Text = Convert.ToString(firstNumber + secondNumber);
                    break;
                case "-":
                    textBox3.Text = Convert.ToString(firstNumber - secondNumber);
                    break;
                case "*":
                    textBox3.Text = Convert.ToString(firstNumber * secondNumber);
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("На ноль делить нельзя!");
                    }
                    else
                    {
                        textBox3.Text = Convert.ToString(firstNumber / secondNumber);
                        break;
                    }
                    break;
                case "":
                    MessageBox.Show("Выберите арифметическую операцию!");
                    break;
                default:
                    textBox3.Text = "Допущен неверный символ!";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "";
            comboBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

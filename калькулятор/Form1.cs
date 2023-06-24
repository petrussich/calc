using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        double first_num = 0, second_num = 0, result = 0;
        char sign = '+';

     

        private void button17_Click(object sender, EventArgs e)
        {
            first_num = Convert.ToDouble(textBox1.Text);
            sign = (sender as Button).Text[0];
            textBox1.Clear();
        }

        

        private void button21_Click(object sender, EventArgs e)
        {
            second_num = Convert.ToDouble(textBox1.Text);
   
            switch (sign)
            {
                case '+': result = first_num + second_num; break;
                case '-': result = first_num - second_num; break;
                case '×': result = first_num * second_num; break;
                case '÷': result = first_num / second_num; break;
            }
            textBox1.Text = result.ToString();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double number, result;
            number = Convert.ToDouble(textBox1.Text);
            result = 1/number;
            textBox1.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double number, result;
            number = Convert.ToDouble(textBox1.Text);
            result =Math.Sqrt(number);
            textBox1.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number, result;
            number = Convert.ToDouble(textBox1.Text);
            result = number/100;
            textBox1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = first_num.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                }
                else
                {
                    textBox1.Text = '-' + textBox1.Text;
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1,1);
            }
        }
    }
}

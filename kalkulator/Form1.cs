using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        bool finish = false;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        string input = string.Empty;
        char operation;
        double output = 0.0;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (finish == false)
            {
                input += "0";
                this.screen.Text = input;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (finish == false)
            {
                input += "1";
                this.screen.Text = input;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (finish == false)
            {
                input += "2";
                this.screen.Text = input;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (finish == false)
            {
                input += "3";
                this.screen.Text = input;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (finish == false)
            {
                input += "4";
                this.screen.Text = input;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (finish == false)
            {
                input += "5";
                this.screen.Text = input;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (finish == false)
            {
                input += "6";
                this.screen.Text = input;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (finish == false)
            {
                input += "7";
                this.screen.Text = input;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (finish == false)
            {
                input += "8";
                this.screen.Text = input;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (finish == false)
            {
                input += "9";
                this.screen.Text = input;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if(finish == false)
            {
                
                if (input != string.Empty && operand1 == string.Empty)
                {
                    operation = '+';
                    operand1 = input;
                    this.screen.Text = "";
                    this.upscreen.Text = " + " + input;
                    input = string.Empty;
                }
                
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if(finish == false)
            {
                
                if (input != string.Empty && operand1 == string.Empty)
                {
                    operation = '-';
                    operand1 = input;
                    this.screen.Text = "";
                    this.upscreen.Text = " - " + input;
                    input = string.Empty;
                }
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if(finish == false)
            {
                
                if (input != string.Empty && operand1 == string.Empty)
                {
                    operation = '*';
                    operand1 = input;
                    this.screen.Text = "";
                    this.upscreen.Text = " * " + input;
                    input = string.Empty;
                }
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if(finish == false)
            {
                
                if (input != string.Empty && operand1 == string.Empty)
                {
                    operation = '/';
                    operand1 = input;
                    this.screen.Text = "";
                    this.upscreen.Text = " / " + input;
                    input = string.Empty;
                }
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            if (operand1 != string.Empty && input != string.Empty)
            {
                finish = true;
                operand2 = input;
                double num1, num2;
                double.TryParse(operand1, out num1);
                double.TryParse(operand2, out num2);

                if (operation == '+')
                {
                    upscreen.Text = operand2 + " + " + operand1;
                    output = num1 + num2;
                    screen.Text = output.ToString();
                }

                else if (operation == '-')
                {
                    upscreen.Text = operand2 + " - " + operand1;
                    output = num1 - num2;
                    screen.Text = output.ToString();
                }

                else if (operation == '*')
                {
                    upscreen.Text = operand2 + " * " + operand1;
                    output = num1 * num2;
                    screen.Text = output.ToString();
                }

                else
                {
                    upscreen.Text = operand2 + " / " + operand1;
                    output = num1 / num2;
                    screen.Text = output.ToString();
                }
            }
        }

        private void ce_Click(object sender, EventArgs e)
        {
            if (finish == false)
            {
                input = string.Empty;
                screen.Text = "";
            }
        }

        private void c_Click(object sender, EventArgs e)
        {
            finish = false;
            operand1 = string.Empty;
            operand2 = string.Empty;
            input = string.Empty;
            screen.Text = "";
            upscreen.Text = "";

        }
    }
}

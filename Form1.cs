using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSimpleCalculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool isOperationPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if((result.Text == "0") || (isOperationPressed))
            {
                result.Clear();
            }
            isOperationPressed = false;
            Button b = (Button)sender;
            if(b.Text ==".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
            {
                result.Text = result.Text + b.Text;

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                button17.PerformClick();
                isOperationPressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = double.Parse(result.Text);
                isOperationPressed = true;
                equation.Text = value + " " + operation;
            }
           
        }

        private void button17_Click(object sender, EventArgs e)
        {

            equation.Text = "";

            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break; 
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break; 
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break; 
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            value = double.Parse(result.Text);
            operation = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

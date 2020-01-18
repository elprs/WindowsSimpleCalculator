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
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(result.Text);
            isOperationPressed = true;
        }
    }
}

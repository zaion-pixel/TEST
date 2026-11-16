using CalculatorPrivateAssembly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBasicCalculator
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

        private void btnCompute_Click(object sender, EventArgs e)
        {
            
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);
            string op = cmbOperator.Text;
            float result = 0;

            if (op == "+")
            {
                result = BasicComputation.Addition(num1, num2);
            }
            else if (op == "-")
            {
                result = BasicComputation.Subtraction(num1, num2);
            }
            else if (op == "*")
            {
                result = BasicComputation.Multiplication(num1, num2);
            }
            else if (op == "/")
            {
                result = BasicComputation.Division(num1, num2);
            }

          
            lblTotal.Text = result.ToString();
        }

        private void btnCompute_Click_1(object sender, EventArgs e)
        {
           
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);
            string op = cmbOperator.Text;
            float result = 0;

            if (op == "+")
            {
                result = BasicComputation.Addition(num1, num2);
            }
            else if (op == "-")
            {
                result = BasicComputation.Subtraction(num1, num2);
            }
            else if (op == "*")
            {
                result = BasicComputation.Multiplication(num1, num2);
            }
            else if (op == "/")
            {
                result = BasicComputation.Division(num1, num2);
            }

          
            lblTotal.Text = result.ToString();
        }
    }
}

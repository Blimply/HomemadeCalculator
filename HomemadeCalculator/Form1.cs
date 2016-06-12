using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomemadeCalculator
{
    public partial class Form1 : Form
    {

        string history; //Soon
        string inputNumber;
        double operand1, operand2;
        bool operand1Set = false, operand2Set = false;
        bool justEvald = false;
        char lastOperator;

        public Form1()
        {
            InitializeComponent();
        }

        private void oneKey_Click(object sender, EventArgs e)
        {
            keyPress(1);

        }
        private void twoKey_Click(object sender, EventArgs e)
        {
            keyPress(2);

        }

        private void threeKey_Click(object sender, EventArgs e)
        {
            keyPress(3);

        }

        private void fourKey_Click(object sender, EventArgs e)
        {
            keyPress(4);

        }

        private void fiveKey_Click(object sender, EventArgs e)
        {
            keyPress(5);

        }

        private void sixKey_Click(object sender, EventArgs e)
        {
            keyPress(6);

        }

        private void sevenKey_Click(object sender, EventArgs e)
        {
            keyPress(7);

        }

        private void eightKey_Click(object sender, EventArgs e)
        {
            keyPress(8);

        }

        private void nineKey_Click(object sender, EventArgs e)
        {
            keyPress(9);

        }

        private void zeroKey_Click(object sender, EventArgs e)
        {
            keyPress(0);
        }

        private void keyPress(int number)
        {
            if (justEvald) { inputNumber = ""; justEvald = false; }
            inputNumber += number.ToString();
            textBox1.Text = inputNumber;
        }

        private void plusKey_Click(object sender, EventArgs e)
        {
            operatorClick('+');
        }


        private void minusKey_Click(object sender, EventArgs e)
        {
            operatorClick('-');

        }

        private void multiKey_Click(object sender, EventArgs e)
        {
            operatorClick('*');

        }

        private void divKey_Click(object sender, EventArgs e)
        {
            operatorClick('/');
        }

        private void squareKey_Click(object sender, EventArgs e)
        {
            if (inputNumber == "") { inputNumber = "0"; }
            double tmp;
            double.TryParse(inputNumber, out tmp);
            inputNumber = (tmp * tmp).ToString();
            textBox1.Text = inputNumber;
        }

        private void sqrtKey_Click(object sender, EventArgs e)
        {
            if (inputNumber == "") { inputNumber = "0"; }
            double tmp;
            double.TryParse(inputNumber, out tmp);
            inputNumber = Math.Sqrt(tmp).ToString();
            textBox1.Text = inputNumber;
        }

        private void evalKey_Click(object sender, EventArgs e)
        {
            if (inputNumber == "") { inputNumber = "0"; }
            if (operand1Set){
                double.TryParse(inputNumber, out operand2);
                inputNumber = operatorCalculate(lastOperator, operand1, operand2).ToString();
                textBox1.Text = inputNumber;
                operand1Set = false;
            }
            justEvald = true;
        }

        private void clearKey_Click(object sender, EventArgs e)
        {
            operand1Set = false; operand2Set = false;
            operand1 = 0; operand2 = 0; //Just in case
            inputNumber = "";
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private double operatorCalculate(char operation, double i1, double i2)
        {
            switch (operation)
            {
                case '+':
                    return i1 + i2;
                case '-':
                    return i1 - i2;
                case '*':
                    return i1 * i2;
                case '/':
                    return i1 / i2;
                default:
                    return 0;
            }
        }

        private void operatorClick(char op)
        {
            if (inputNumber == "") { inputNumber = "0"; }
            if (operand1Set == false)
            {
                double.TryParse(inputNumber, out operand1);
                operand1Set = true;
                inputNumber = "";
                lastOperator = op;

            }
            //If operand1 is already set we are in the case of a+b+...
            //Set a+b as O1 then and lastOperator as +
            else
            {
                double tmp = 0;
                double.TryParse(inputNumber, out tmp);
                operand1 = operatorCalculate(lastOperator, operand1, tmp); operand1Set = true;
                lastOperator = op;
                inputNumber = "";
                textBox1.Text = operand1.ToString();
            }
        }


    }
}

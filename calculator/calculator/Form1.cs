using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public bool isFirstOperand { get; set; } = true;

        Calculator calculator = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void NumClicked(object sender, EventArgs e)
        {
            if(sender is Label b)
            {
                if (isFirstOperand)
                {
                    calculator.FirstOperand = calculator.FirstOperand * 10 + Convert.ToInt32(b.Text);
                }
                else
                {
                    calculator.SecondOperand = calculator.SecondOperand * 10 + Convert.ToInt32(b.Text);
                }
            }

            SetDisplay();
        }


        private void SetDisplay()
        {
            mainDisplayLabel.Text = isFirstOperand ? calculator.FirstOperand.ToString() : calculator.SecondOperand.ToString();
            previewLbl.Text = $"{calculator.FirstOperand} {calculator.Operator} {calculator.SecondOperand}";
        }

        private void OperatorsClicked(object sender, EventArgs e)
        {
            if(sender is Label lbl)
            {
                if(calculator.Operator == default)
                {
                    calculator.Operator = Convert.ToChar(lbl.Text);
                    isFirstOperand = false;
                }
                else if(calculator.Operator != default && calculator.SecondOperand == 0)
                {
                    calculator.Operator = Convert.ToChar(lbl.Text);
                }
                else if(calculator.Operator != default && calculator.SecondOperand != 0)
                {
                    calculator.Calculate();
                    calculator.Operator = Convert.ToChar(lbl.Text);
                    isFirstOperand = false;
                }
                SetDisplay();
            }
        }


        private void operatorResult_Click(object sender, EventArgs e)
        {
            if(isFirstOperand == true || calculator.Operator == default)
            {
                return;    
            }
            previewLbl.Text = calculator.Calculate().ToString();
            mainDisplayLabel.Text = calculator.SecondOperand.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void togglePositive_Click(object sender, EventArgs e)
        {
            if (isFirstOperand && calculator.FirstOperand != 0)
            {
                calculator.FirstOperand *= -1;
            }
            else if(calculator.SecondOperand != 0)
            {
                calculator.SecondOperand *= -1;
            }
            SetDisplay();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            calculator.Reset();
            SetDisplay();
            isFirstOperand = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (isFirstOperand) calculator.FirstOperand = (int)calculator.FirstOperand / 10;
            else calculator.SecondOperand = (int)calculator.SecondOperand / 10;
            SetDisplay();
        }
    }
}

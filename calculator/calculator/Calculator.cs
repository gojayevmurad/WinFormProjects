using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Calculator
    {
        public List<string> History { get; set; } = new List<string>();

        public double FirstOperand { get; set; } = 0;
        public double SecondOperand { get; set; } = 0;
        public char Operator { get; set; } = default;

        public Calculator() { }

        private double sum()
        {
            double result = FirstOperand + SecondOperand;
            History.Add($"{FirstOperand} + {SecondOperand} = {result}");
            return result;
        }

        private double subt()
        {
            double result = FirstOperand - SecondOperand;
            History.Add($"{FirstOperand} - {SecondOperand} = {result}");
            return result;
        }

        private double mul()
        {
            double result = FirstOperand * SecondOperand;
            History.Add($"{FirstOperand} - {SecondOperand} = {result}");
            return result;
        }

        private double div()
        {
            double result = FirstOperand / SecondOperand;
            History.Add($"{FirstOperand} / {SecondOperand} = {result}");
            return result;
        }

        private double mod()
        {
            double  result = FirstOperand % SecondOperand;
            History.Add($"{FirstOperand} / {SecondOperand} = {result}");
            return result;
        }

        public void Reset()
        {
            FirstOperand = 0;
            SecondOperand = 0;
            Operator = default;
        }

        public double Calculate()
        {
            double result;
            switch ( Operator )
            {
                case '+':
                    result= sum();
                    break;
                case '-':
                    result = subt();
                    break;
                case '*':
                    result = mul();
                    break;
                case '/':
                    result = div();
                    break;
                case '%':
                    result = mod();
                    break;
                default:
                    throw new NotImplementedException();
            }

            FirstOperand = result;
            SecondOperand = 0;
            Operator = default;

            return result;
        }

    }
}

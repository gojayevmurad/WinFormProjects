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

        public double Calculate()
        {
            double result;
            switch ( Operator )
            {
                case '+':
                    Console.WriteLine("plus");
                    result= sum();
                    break;
                case '-':
                    Console.WriteLine("minus");
                    result = subt();
                    break;
                case '*':
                    Console.WriteLine("mul");
                    result = mul();
                    break;
                case '/':
                    Console.WriteLine("div");
                    result = div();
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

using System;
using System.Text;

namespace CalculatorLib
{
    public class Calculator
    {
        private static double _inputValue;
        private static char _operator = ' ';
        private static double _result;
        public static void Input(string value, char operation )
        {
            bool parsed = double.TryParse(value, out double result);
            if (parsed)
            {
                _inputValue = result;
                _operator = operation;

            }
            else
            {
                throw new ArgumentException("Invalid input");
            }
        }

        public static void Equals()
        {
            switch (_operator)
            {
                case(' '):
                    // Take the input value and put it in the result
                    break;
                case ('+'):
                    // do addition
                    break;
                case ('-'):
                    // do subtraction
                    break;
                case ('*'):
                    // do multiplication
                    break;
                case ('/'):
                    // do division
                    break;
                case ('%'):
                    // do modulus
                    break;
            }
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {

            return y == 0 ? throw new ArgumentException("Cannot divide by zero") : x / y;
        }

        public static int Modulus(int x, int y)
        {
            return x % y;
        }
    }
}

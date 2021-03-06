using System;
using System.Text;

namespace CalculatorLib
{
    public class Calculator
    {
        public static double _inputValue;
        public static char _operator = ' ';
        public static double _previousResult;
        public static double _result;
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

        public static string Execute(string a, string b, string operation) // this needs to return a string.
        {
            var num1Parse = double.TryParse(a, out double num1);
            var num2Parse = double.TryParse(b, out double num2);

            if (!num1Parse || !num2Parse)
            {
                return "Incorrect String Format";
            }
            else
            {
                switch (operation)
                {
                    case (""):
                        return a;
                    case ("+"):
                        // do addition
                        return Add(num1, num2).ToString();
                    case ("-"):
                        return Subtract(num1, num2).ToString();
                    case ("x"):
                        // do multiplication _result = Multiply(_inputValue, _previousResult)
                        return Multiply(num1, num2).ToString();
                    case ("/"):
                        // do division _result = Divide(_input, _previousResult)
                        if (a == " ") { a = "0"; }

                        try
                        {
                            return Divide(num1, num2).ToString();
                        }
                        catch (ArgumentException e)
                        {
                            return e.Message;
                        }
                    case ("%"):
                        // do modulus _result = Modulus(_input, _previousResult)
                        return Modulus(num1, num2).ToString();
                    default:
                        break;
                }

            }

            return a;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {

            return y == 0 ? throw new ArgumentException("Cannot divide by zero") : x / y;
        }

        public static double Modulus(double x, double y)
        {
            return x % y;
        }
    }
}

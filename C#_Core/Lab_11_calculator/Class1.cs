﻿using System;
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

        public static Tuple<string, string, string> Execute(string a, string b, string operation) // this needs to return a string.
        {
            switch (operation)
            {
                case(""):
                    return Tuple.Create( a, b, operation);
                case ("+"):
                    // do addition
                    return Tuple.Create(Add(double.Parse(a), double.Parse(b)).ToString(), b, operation);
                case ("-"):
                    return Tuple.Create(Subtract(double.Parse(a), double.Parse(b)).ToString(), b, operation);
                case ("x"):
                    // do multiplication _result = Multiply(_inputValue, _previousResult)
                    return Tuple.Create(Multiply(double.Parse(a), double.Parse(b)).ToString(), b, operation);
                case ("/"):
                    // do division _result = Divide(_input, _previousResult)
                    return Tuple.Create(Divide(double.Parse(a), double.Parse(b)).ToString(), b, operation);
                case ("%"):
                    // do modulus _result = Modulus(_input, _previousResult)
                    return Tuple.Create(Modulus(double.Parse(a), double.Parse(b)).ToString(), b, operation);
                default:
                    break;
            }
            return Tuple.Create(a, b, operation);
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

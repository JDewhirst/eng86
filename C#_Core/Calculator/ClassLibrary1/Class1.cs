﻿using System;

namespace CalculatorLibrary
{
    public static class Calculator
    {
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
            return x / y;
        }

        public static int Modulus(int x, int y)
        {
            return x % y;
        }
    }
}

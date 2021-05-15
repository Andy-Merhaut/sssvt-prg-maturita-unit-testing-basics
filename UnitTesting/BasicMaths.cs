using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    public class BasicMaths
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Deduct(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public double Multiply(double num1, double num2)
        {
            // To trace error while testing, writing + operator instead of * operator.  
            // Toto bude padat, abychom videli, ze testing funguje
            // oprava je zmena z operatoru plus na operator nasobeni (hvezdicka)
            return num1 + num2;
        }
    }
}

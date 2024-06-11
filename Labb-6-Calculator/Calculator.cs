using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_Calculator
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division med noll är inte tillåtet.");
            }
            return a / b;
        }

    }
}

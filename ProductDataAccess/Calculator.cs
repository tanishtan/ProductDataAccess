using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDataAccess
{
    /*public enum Operators
    {
        None, Add, Minus,  Multiply, Divide, Modulus
    }*/
    public class Calculator
    {

        public int Calculate(string op, int input1, int input2)
        {
            switch (op)
            {
                case "+": return Add(input1, input2);
                case "-": return Minus(input1, input2);
                case "*": return Multiply(input1, input2);
                case "/": return Divide(input1, input2);
                case "%": return input2 == 0 ? 0 : input1 % input2;
                default: return -1;
            }
        }
        public int Add(int a, int b) => a + b;
        public int Minus(int a, in int b) => a - b;
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new ArgumentOutOfRangeException(nameof(b));
            return b == 0 ? 0 : a / b;
        }
        public int Multiply(int a, int b) => a * b;
        
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCalculator
{
    public DivideOperation : IOperation
    {
        public string Name { get; } = "divide";
        public float Execute(int[] input)
        {
            if (input.Length == 0)
                throw new ArgumentException("Input array cannot be empty.");
            if (input.Length == 1)
                return input[0]; // If only one element, return it as is.
            float result = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == 0)
                    throw new DivideByZeroException("Cannot divide by zero.");
                result /= input[i];
            }
            return result;
        }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCalculator
{
    public class SubtractOperation : IOperation
    {
        public string Name { get; } = "subtract";
        public float Execute(int[] input)
        {
            if (input.Length == 0)
                throw new ArgumentException("Input array cannot be empty.");
            int result = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                result -= input[i];
            }
            return result;
        }
    }
}

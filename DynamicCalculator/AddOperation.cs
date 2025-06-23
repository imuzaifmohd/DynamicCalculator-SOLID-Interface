using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCalculator
{
    public class AddOperation : IOperation
    {
        public string Name { get; } = "add";
        public float Execute(int[] input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCalculator
{
    public class  DeleteOperation : IOperation
    {
        public string Name { get; } = "multiply";
        public float Execute(int[] input)
        {
            int temp = 1;
            for (int i = 0; i < input.Length; i++)
            {
                temp *= input[i];
            }
            return temp;
        }
    }
}

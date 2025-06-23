using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCalculator
{
    public class DeleteOperation : IOperation
    {
        public string Name { get; } = "delete";
        public float Execute(int[] input)
        {
            return 0.0;
            //if (input.Length == 0)
            //    throw new ArgumentException("Input array cannot be empty.");
            //// Assuming delete operation means removing the first element from the array
            //return input[0]; // Just returning the first element as an example
        }

    {
}

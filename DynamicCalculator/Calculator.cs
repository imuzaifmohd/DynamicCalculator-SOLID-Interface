using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCalculator
{
    public class Calculator
    {
        public   int Add(int[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return sum;
        }
        public int Subtract(int[] x)
        {
            int result = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                result -= x[i];
            }
            return result;
        }
        public int Multiply(int[] x)
        {
            int temp = 1;
            for (int i = 0; i < x.Length; i++)
            {
                temp *= x[i];
            }
            return temp;
        }
        public float Divide(int[] x)
        {
            float result = (float) x[0];
            for (int i=1; i<x.Length; i++)
            {
                if (x[i] != 0)
                {
                    result /= x[i];
                }
                else
                {
                    return float.NaN; // Return NaN if division by zero occurs
                }
            }

            return result;
        }
    }
}

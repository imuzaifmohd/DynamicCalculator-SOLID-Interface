using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCalculator
{
    public interface IOperation
    {
        string Name { get;}

        float Execute(int[] input);
    }
}

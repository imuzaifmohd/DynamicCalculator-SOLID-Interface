using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCalculator
{
    public class Helper
    {
        public int[] TakeArrayInput(int length)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }

    }
}

using System;

namespace DynamicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IOperation> operations = new List<IOperation>()
            {
                new AddOperation(),
                new SubtractOperation(),
                new DeleteOperation(),
                //new DivideOperation()
            };

            Helper inputHelper = new Helper();
            Console.WriteLine("Type the operation name (add / subtract / multiply / divide):");
            string opName = Console.ReadLine();

            IOperation selectedOp = operations.Find(op => op.Name == opName);

            Console.WriteLine("How many numbers do you want to " + selectedOp.Name + "?");
            int length = Convert.ToInt32(Console.ReadLine());

            if (length <= 0)
            {
                Console.WriteLine("Please enter a valid number greater than 0.");
                return;
            }

            int[] inputArray = inputHelper.TakeArrayInput(length);

            Console.WriteLine("The result of " + selectedOp.Name + " operation is: " + selectedOp.Execute(inputArray));
        }
    }
}

























//using System;

//namespace DynamicCalculator
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Calculator calc = new Calculator();
//            Helper inputHelper = new Helper();


//            Console.WriteLine("Type The Operation name you want to perform: add / subtract / mulitply / divide");
//            string operationName = Console.ReadLine();
//            if (operationName == "add")
//            {
//                Console.WriteLine("How many numbers you want to add?");
//                int arrayLength = Convert.ToInt32(Console.ReadLine());
//                int[] array = inputHelper.TakeArrayInput(arrayLength);

//                Console.WriteLine("The total is: " + calc.Add(array));
//            }
//            else if (operationName == "subtract")
//            {
//                Console.WriteLine("How many numbers you want to subtract?");
//                int arrayLength = Convert.ToInt32(Console.ReadLine());
//                int[] array = inputHelper.TakeArrayInput(arrayLength);
//                Console.WriteLine("Subtracted result is: " + calc.Subtract(array));
//            }
//            else if (operationName == "multiply")
//            {
//                Console.WriteLine("How many numbers you want to multiply?");
//                int arrayLength = Convert.ToInt32(Console.ReadLine());
//                int[] array = inputHelper.TakeArrayInput(arrayLength);

//                Console.WriteLine("The Multiply result is: " + calc.Multiply(array));
//            }
//            else if (operationName == "divide")
//            {
//                Console.WriteLine("How many numbers you want to Divide?");
//                int arrayLength = Convert.ToInt32(Console.ReadLine());
//                int[] array = inputHelper.TakeArrayInput(arrayLength);
//                float result = calc.Divide(array);
//                if (float.IsNaN(result))
//                {
//                    Console.WriteLine("The divider can not be 0.");
//                }
//                else
//                {
//                    Console.WriteLine("Divided Value is: " + result);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Write a proper operation name among the options given.");
//            }
//        }
//    }
//}


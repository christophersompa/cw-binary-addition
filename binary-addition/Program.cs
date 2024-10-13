using System;

namespace binary_addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Implement a function that adds two number together and returns their sum in binary
             * This conversion can be done before, or after the addition. The binary number return should be a string
             */

            Console.WriteLine(AddBinary(1,1));
            Console.ReadLine();
        }

        public static string AddBinary(int a , int b ) => Convert.ToString(a + b , 2);
        
    }
}

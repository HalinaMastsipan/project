using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.SumProgram
{
    class SumProgram
    {
        public static int ReadValue()
        {
            Console.WriteLine("Insert some number");
            string N = Console.ReadLine();
            int value;
            while (!int.TryParse(N, out value) || !(value <= 100) || !(value >= 0))
            {
                Console.WriteLine("error, please enter number more then 0 and less then 100");
                N = Console.ReadLine();
            }
            return value;
        }
        public static int CountValue(int value)
        {
            int result = 0;
            for (int i = 1; i <= value; i++)
            {
                result = result + i;
            }
            return result;
        }
    }
}

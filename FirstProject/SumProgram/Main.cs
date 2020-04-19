using FirstProject.RandomNumbers;
using System;
using System.Collections.Generic;
using System.Text;
using TuttiFruttiProgram;

namespace SumProgram
{
    class Array
    {
        public static void Main (String [] args)
        {
            new NewArrayWithRandomValues().countElementsSum();
            TuttiFrutti tuttiFrutti = new TuttiFrutti();
            tuttiFrutti.outputValues();
            int a = enteredValue();
            Console.WriteLine(countValue(a));
            int enteredValue()
            {
                Console.WriteLine("Insert some number");
                string N = Console.ReadLine();
                int value;
                while (!int.TryParse(N, out value) || !(value <= 100))
                {
                    Console.WriteLine("error");
                    N = Console.ReadLine();
                }
                return value;
            }
            string countValue(int value)
            {
                int result = 0;
                for (int i = 1; i <= value; i++)
                {
                    result = result + i;
                }
                return result.ToString();
            }
        }
    } 
}

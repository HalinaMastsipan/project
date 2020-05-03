using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.DifMethods
{
    class Arithmetical
    { 
        public static int ReadFirstNumber()
        {
            Console.WriteLine("Print the first number");
            int firstNumber = Int32.Parse(Console.ReadLine());
            return firstNumber;
        }
        public static int ReadSecondNumber()
        {
            Console.WriteLine("Print the second number");
            int secondNumber = Int32.Parse(Console.ReadLine());
            return secondNumber;
        }

        public static void SumOfTheNumbers(int f1, int f2)
        {
            Console.WriteLine("SUM OF THE NUMBERS IS " + Convert.ToInt32(f1 + f2));
        }

        public static void MultiplicationOfTheNumbers(int f1, int f2)
        {
            Console.WriteLine("MULTIPLICATION OF THE NUMBERS IS " + Convert.ToInt32(f1 * f2));
        }

        public static void DivisionOfTheNumbers(int f1, int f2)
        {
            Console.WriteLine("DIVISION OF THE NUMBERS IS " + Convert.ToInt32(f1 * f2));
        }
    }
}

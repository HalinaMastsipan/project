using System;
using System.Collections.Generic;
using System.Text;

namespace TuttiFruttiProgram
{
    class TuttiFrutti
    {
        public static void outputValues()
        {
            const string TUTTI = "Tutti";
            const string FRUTTI = "Frutti";
            const string TUTTI_FRUTTI = "Tutti-Frutti";
            int[] numbers = new int[50];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
                if ((numbers[i] % 3 == 0) && !(numbers[i] % 5 == 0))
                {
                    Console.WriteLine($"{numbers[i]} {TUTTI}");
                }
                else if ((numbers[i] % 5 == 0) && !(numbers[i] % 3 == 0))
                {
                    Console.WriteLine($"{numbers[i]} {FRUTTI}");
                }
                else if ((numbers[i] % 5 == 0) && (numbers[i] % 3 == 0))
                {
                    Console.WriteLine($"{numbers[i]} {TUTTI_FRUTTI}");
                }
            }
        }
    }
}

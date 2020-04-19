using System;
using System.Collections.Generic;
using System.Text;

namespace TuttiFruttiProgram
{
    class TuttiFrutti
    {
        public void outputValues()
        {
            string value1 = "Tutti";
            string value2 = "Frutti";
            string value3 = "Tutti-Frutti";
            int[] numbers = new int[50];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
                if ((numbers[i] % 3 == 0) && !(numbers[i] % 5 == 0))
                {
                    Console.WriteLine($"{numbers[i]} Tutti");
                }
                else if ((numbers[i] % 5 == 0) && !(numbers[i] % 3 == 0))
                {
                    Console.WriteLine($"{numbers[i]} Frutti");
                }
                else if ((numbers[i] % 5 == 0) && (numbers[i] % 3 == 0))
                {
                    Console.WriteLine($"{numbers[i]} Tutti Frutti");
                }
            }
        }
    }
}

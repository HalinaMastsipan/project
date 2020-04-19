using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.RandomNumbers
{
    class NewArrayWithRandomValues
    {
        public void countElementsSum()
        {
            int[] numbers = new int[5];
            int sum = 0;
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(20);
                sum += numbers[i];
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine($"Sum of the elemnts is {sum}");
        }
    }
}

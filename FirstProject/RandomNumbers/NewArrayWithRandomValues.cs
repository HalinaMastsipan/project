using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.RandomNumbers
{
    class NewArrayWithRandomValues
    {
        public static int[] generateArray(int size)
        {
            int[] numbers = new int[size];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                int rnd = random.Next(20);
                numbers[i] = rnd;
            }
            return numbers;
        }
        public static void printArray(int[] numbers)
        {
            Console.WriteLine("Your array contains numbers");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        public static int calculateSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}

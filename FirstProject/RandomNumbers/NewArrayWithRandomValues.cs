using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.RandomNumbers
{
    class NewArrayWithRandomValues
    {
        public static int[] GenerateArray(int size)
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

        public static void PrintArray(int[] numbers)
        {
            Console.WriteLine("Your array contains numbers");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static int CalculateSum(int[] numbers)
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

using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.SequenseOfNumbers
{
    class ArrayHandler
    {
        const int MIN_ARRAY_SIZE = 2;
        public static int ScanArraySize()
        {
            int arraySize = -1;
            string stringArraySize; 
            while (arraySize < MIN_ARRAY_SIZE) 
            {
                Console.WriteLine("Please enter the array size greater or equal to 2");
                stringArraySize = Console.ReadLine();
                int.TryParse(stringArraySize, out arraySize);
            }
            return arraySize;
        }

        public static int[] FillArray(int arraySize)
        {
            int[] array = new int[arraySize];
            string stringArrayItem;
            int intArrayItem;
            for (int i = 0; i < arraySize; i++)
            {
                while (true)
                {
                    Console.WriteLine($"Enter the {i} element of your array");
                    stringArrayItem = Console.ReadLine();
                    if(int.TryParse(stringArrayItem, out intArrayItem))
                    {
                        array[i] = intArrayItem;
                        break;
                    }
                }
            }
            return array;
        }

        public static void ValidateIfTheSequenseIsAscending(int[] array)
        {
            bool isAscending = true;
            for(int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    isAscending = false;
                    break;
                }
            }
            string answer = isAscending ? " is " : " is not ";
            Console.WriteLine($"Your array {answer} ascending");
        }
    }
}

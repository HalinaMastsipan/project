using FirstProject.RandomNumbers;
using System;
using System.Collections.Generic;
using System.Text;
using TuttiFruttiProgram;
using FirstProject.SumProgram;
using FirstProject.DifMethods;
using FirstProject.SequenseOfNumbers;

namespace TheBeginning
{
    class StartingClass
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("_________________________________Task 1_________________________________");
            int[] numbers = NewArrayWithRandomValues.GenerateArray(5);
            NewArrayWithRandomValues.PrintArray(numbers);
            int sum = NewArrayWithRandomValues.CalculateSum(numbers);
            Console.WriteLine($"sum of array elements is {sum}");

            Console.WriteLine("_________________________________Task 2_________________________________");
            TuttiFrutti.outputValues();

            Console.WriteLine("_________________________________Task 3_________________________________");
            int value = SumProgram.ReadValue();
            int sum1 = SumProgram.CountValue(value);
            Console.WriteLine($"the sum of numbers between {value} and 0 is {sum1}");

            Console.WriteLine("_________________________________Task 4_________________________________");
            int f1 = Arithmetical.ReadFirstNumber();
            int f2 = Arithmetical.ReadSecondNumber();
            Arithmetical.SumOfTheNumbers(f1, f2);
            Arithmetical.MultiplicationOfTheNumbers(f1, f2);
            Arithmetical.DivisionOfTheNumbers(f1, f2);

            Console.WriteLine("_________________________________Task 5_________________________________");
            int arraySize = ArrayHandler.ScanArraySize();
            int[] array = ArrayHandler.FillArray(arraySize);
            ArrayHandler.ValidateIfTheSequenseIsAscending(array);
        }
    }
}

using FirstProject.RandomNumbers;
using System;
using System.Collections.Generic;
using System.Text;
using TuttiFruttiProgram;
using FirstProject.SumProgram;
using FirstProject.DifMethods;

namespace TheBeginning
{
    class StartingClass
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("_________________________________Task 1_________________________________");
            int[] numbers = NewArrayWithRandomValues.generateArray(5);
            NewArrayWithRandomValues.printArray(numbers);
            int sum = NewArrayWithRandomValues.calculateSum(numbers);
            Console.WriteLine($"Sum of array elements is {sum}");

            Console.WriteLine("_________________________________Task 2_________________________________");
            TuttiFrutti.outputValues();

            Console.WriteLine("_________________________________Task 3_________________________________");
            int value = SumProgram.readValue();
            int sum1 = SumProgram.countValue(value);
            Console.WriteLine($"The sum of numbers between {value} and 0 is {sum1}");

            Console.WriteLine("_________________________________Task 4_________________________________");
            int f1 = Arithmetical.readFirstNumber();
            int f2 = Arithmetical.readSecondNumber();
            Arithmetical.sumOfTheNumbers(f1, f2);
            Arithmetical.multiplicationOfTheNumbers(f1, f2);
            Arithmetical.divisionOfTheNumbers(f1, f2);
        }
    }
}

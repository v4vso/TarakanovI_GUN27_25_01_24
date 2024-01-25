using System;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#1
            //Fibonacci sequence

            int[] fibonacciNum = new int[8] { 0, 1, 1, 2, 3, 5, 8, 13 };

            Console.WriteLine("#1 Fibonacci sequence");

            foreach (var num in fibonacciNum)
            {
                Console.WriteLine($"{num}");
            }
            Console.WriteLine();

            //#2
            //Months of the year

            string[] monthsYear = { "January", "February",  "March", "April",
                                    "May", "June", "July", "August", "September",
                                    "October", "November", "December"};

            Console.WriteLine("#2 Months of the year");

            foreach (var month in monthsYear)
            {
                Console.Write($"{month}\n");
            }
            Console.WriteLine();

            //#3
            //3x3 Array

            int[,] arr3x3 = new int[3, 3]
                {

                        { 2, 3, 4 },
                        { 4, 9, 16 },
                        { 8, 27, 64 }
                };
            Console.WriteLine("#3 3x3 Array");

            /* foreach (var num in arr3x3)
             {
                 Console.WriteLine($"{num}");
             }*/
            for (int i = 0; i < arr3x3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3x3.GetLength(1); j++)
                {
                    Console.Write(arr3x3[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //#4
            //Jagged array

            double[][] numbers = new double[3][];

            numbers[0] = new double[] { 1, 2, 3, 4, 5 };

            numbers[1] = new double[] { (double)Math.E, (double)Math.PI };

            numbers[2] = new double[] { (double)Math.Log10(1), (double)Math.Log10(10),
                                        (double)Math.Log10(100), (double)Math.Log10(1000) };

            Console.WriteLine("#4 Jagged array");

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write(numbers[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            //#5
            //Arrays Copy

            Console.WriteLine("#5 Arrays Copy");

            int[] array = { 1, 2, 3, 4, 5 };

            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

            Array.Copy(array, 0, array2, 0, 3);

            Console.WriteLine(String.Join(",", array2));

            //#6
            //First array x2
            Console.WriteLine();

            Console.WriteLine("#6 First array x2");

            Array.Resize(ref array, 10);

            foreach (var num in array)
            {
                Console.Write($"{num}");
            }

            //

            Console.Read();
        }
    }
}
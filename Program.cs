using System;
using System.Diagnostics.CodeAnalysis;


namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Массив 1
            int[] array1 = { 0, 1, 1, 2, 3, 5, 8, 13 };
            Console.WriteLine("Первый массив - array1, числа Фибоначчи");
            foreach (int fibonacci_number in array1)
            {
                Console.Write(fibonacci_number + " ");
            }
             Console.WriteLine();   

            // Массив 2
            string[] array2 = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Console.WriteLine("Второй массив - array2, месяца на английском");
            foreach (string month in array2)
            {
                Console.WriteLine(month);
            }

            //Массив 3 
            int[,] array3 = {
            {2, 3, 4},
            {2 * 2, 3 * 3, 4 * 4},
            {2 * 2 * 2, 3 * 3 * 3, 4 * 4 * 4}};
            Console.WriteLine("Третий массив - матрица 3x3 array3");
            for (int i = 0; i < 3; i++)
{
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array3[i, j] + " ");  
                }
                Console.WriteLine();  
            }

            //Массив 4 
            double[][] array4 = new double[3][];
            array4[0] = new double []{ 1, 2, 3, 4, 5 };
            array4[1] = new double []{ Math.E, Math.PI};
            array4[2] = new double []{ Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000)};
            Console.WriteLine("Четвертый jagged массив - array4");
            for (int i = 0; i < array4.Length; i++)
        {
                    foreach (double num in array4[i])
                    {
                        Console.Write(num + " ");
                    }
                    Console.WriteLine();
                }

            // массивы для заданий 5 и 6.
            int[] array5 = { 1, 2, 3, 4, 5 };
            int[] array6 = { 7, 8, 9, 10, 11, 12, 13 };
            Array.Copy(array5, 0, array6, 0, 3);
            Console.WriteLine("Массив array6 после копирования:");
            foreach (int num in array6)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Массив array5 после увеличения");
            Array.Resize(ref array5, array5.Length * 2);
            foreach (int num in array5)
            {
                Console.Write(num + " ");
            }

            ///string[] sample = { "", "" };
            /// ResizeArray(ref array, /* подставьте число вторым аргументов  */ );///
            // Что же будет выведено?
















        }
    }
}
using System;

namespace ViduArray1
{
    class Program
    {
        //mang
        static void Main(string[] args)
        {
            int[,] array = CreateArray();
            ShowArray(array);
            int s = Sum(array);
            Console.WriteLine("Tong la: " + s);
        }

        static int[,] CreateArray() 
        {
            int row, column;
            Console.WriteLine("Moi nhap so hang: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi nhap so cot: ");
            column = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[row, column];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Moi nhap gia tri: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return array;
        }

        static void ShowArray(int[,] array) 
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int Sum(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            return sum;
        }
    }
}

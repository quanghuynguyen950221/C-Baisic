using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Moi nhap vao so phan luong tu trong mang");
            n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Moi nhap phan tu thu {i+1} = ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            Console.WriteLine("Min = " + numbers[0]);
            Console.WriteLine("Max = " + numbers[n-1]);
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] < numbers[i+1])
                {
                    Console.WriteLine("Min2 = " + numbers[i+1]);
                    break;
                }
            }
            for (int i = n-1; i >= 0; i--)
            {
                if (numbers[i] > numbers[i-1])
                {
                    Console.WriteLine("Max2 = " + numbers[i-1]);
                    break;
                }
            }
        }
    }
}

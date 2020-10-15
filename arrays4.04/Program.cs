using System;

namespace arrays4._03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 4.4. Cho mảng số nguyên gồm n phần tử tùy ý nhập từ bàn phím hoặc file. Nhập thêm giá trị nguyên x và đếm số lần xuất hiện của x trong mảng.
            int n = 0;            
            Console.WriteLine("Nhap so luong phan tu n = ");
            n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i+1} = ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mang ban nhap vao la: ");
            foreach (var i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Sort(numbers);
            Console.WriteLine("Thu tu phan tu tang dan: ");
            foreach (var i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Reverse(numbers);
            Console.WriteLine("Thu tu phan tu giam dan: ");
            foreach (var i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

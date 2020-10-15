using System;

namespace arrays4._07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ài 4.7.Cho mảng số nguyên gồm n phần tử tùy ý nhập từ bàn phím hoặc file.
            Nhập thêm hai giá trị nguyên tùy ý a, b sao cho a<b. Tính tổng các phần tử mảng
            có giá trị nằm trong đoạn [a, b].*/

            int n, a, b;
            int sum = 0;
            Console.WriteLine("Nhap so luong phan tu n = ");
            n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i+1} = ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Xin moi nhap a = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap b = ");
            b = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] >= a && numbers[i] <= b)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine($"Tong tu {a} den {b} trong mang la = {sum}");
        }
    }
}

using System;

namespace arrays4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bài 4.8.Cho mảng số nguyên gồm n phần tử tùy ý nhập từ bàn phím hoặc file.
            Kiểm tra xem mảng này có đối xứng hay không. Mảng đối xứng là mảng có các giá
            trị theo thứ tự ngược và xuôi như nhau.Ví dụ: 1 2 3 6 3 2 1 là mảng đối xứng.*/
            int n;       
            Random numrd = new Random();
            int i = 0;
            Console.WriteLine("Nhap so luong phan tu mang mong muong: ");
            n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            while (i < n)
            {
                int x = numrd.Next(1, 100);
                if (Array.IndexOf(numbers, x) == 0)
                {
                    numbers[i] = x;
                    i++;
                }
                    
            }
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}

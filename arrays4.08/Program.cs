using System;

namespace arrays4._08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bài 4.8.Cho mảng số nguyên gồm n phần tử tùy ý nhập từ bàn phím hoặc file.
            Kiểm tra xem mảng này có đối xứng hay không. Mảng đối xứng là mảng có các giá
            trị theo thứ tự ngược và xuôi như nhau.Ví dụ: 1 2 3 6 3 2 1 là mảng đối xứng.*/
            int n;
            Console.WriteLine("Nhap so luong phan tu muon co trong mang: ");
            n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int[] haftA = new int[n/2];
            int[] haftB = new int[n/2];
            bool equa = true;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap gia tri phan tu thu {i+1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.ConstrainedCopy(numbers, 0, haftA, 0, n / 2);
            if (n%2 == 1)
            {
                Array.ConstrainedCopy(numbers, (n / 2)+1, haftB, 0, n / 2);
            }
            else Array.ConstrainedCopy(numbers, n / 2, haftB, 0, n / 2);
            Array.Reverse(haftB);
            for (int i = 0; i < n/2; i++)
            {
                if (haftA[i] != haftB[i]) 
                {
                    equa = false;
                }
            }
            if (equa)
            {
                Console.WriteLine("Mang ban nhap vao doi xung");
            }
            else
            {
                Console.WriteLine("Mang ban nhap vao KHONG doi xung");
            }
        }
    }
}

using System;

namespace arrays4._05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 4.5.Cho mảng số nguyên gồm n phần tử tùy ý.Hãy nhập giá trị nguyên x nào đó và xác định phần tử có giá trị gần x nhất.Giá trị k nào đó gọi là gần x nhất nếu
            //| k - x | gần với 0 nhất
            int n;
            int x;
            int compare;
            int abs;
            int near;
            Console.WriteLine("Nhap so luong phan tu trong mang: ");
            n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Moi nhap phan tu thu {i+1}= " );
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Moi ban nhap so muon tim so can: ");
            x = int.Parse(Console.ReadLine());
            compare = x;
            near = x;
            for (int i = 0; i < numbers.Length; i++)
            {
                abs = Math.Abs(numbers[i] - x);
                if (compare >= abs)
                {
                    near = numbers[i];
                }
            }
            Console.WriteLine($"So can cua {x} trong mang n la {near}");
        }
    }
}

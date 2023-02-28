using System;

namespace BaiTapCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, c;
            Console.Write("\n Nhap vao so bat dau: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so ket thuc: ");
            c = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            Console.Write("\n Cac so random la: ");
            for (int i = 1; i <= 2; i++)
            {
                Console.Write((random.Next(c - (b - 1)) + b) + " ");
            }
            Console.WriteLine("\nTong 2 so nhap vao la:");
            Console.WriteLine(b + c);
        }
    }
}
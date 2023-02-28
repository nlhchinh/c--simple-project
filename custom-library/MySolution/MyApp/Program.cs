using MyLibrary;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("a = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            b = int.Parse(Console.ReadLine());  
            //goi phuong thuc Add tu Mylibrary
            c = MyMath.Add(a, b);
            // in ket qua
            Console.WriteLine($"{a}+{b}={c}");
            //hoac
            // Console.WriteLine($"{0}+{1}={2}", a, b, c);
            Console.ReadLine();
        }
    }
}

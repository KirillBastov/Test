using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            byte q = 255; // sbyte
            Console.WriteLine(q - 20);
            short w = 15000; //ushort
            Console.WriteLine(w / 100);
            int f = 10000232; //uint
            Console.WriteLine(f * 2);
            long x = 2323232323232323233; //ulong
            Console.WriteLine(x + 7);
            float g = 2.323f; 
            Console.WriteLine(g + 2.32);
            double j = 2.23323323;
            Console.WriteLine(j + g);
            var d = 32;
            Console.WriteLine(d + 60 - 32);

            //  2.
            int x1 = 7;
            int x2 = x1 * 3;
            int x3 = x1 + x2;
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);


            //  3.
            Console.WriteLine("Введите первое число ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число ");
            double a3 = Convert.ToDouble(Console.ReadLine());
            double j3 = a1 / a2;
            double j4 = a1 + a2 + a3;
            Console.WriteLine($"Деление {j3}{'\n'}Сложение {j4}");
            


        }
    }
}
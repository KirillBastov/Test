using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isa = true;
            bool ira = false; //bool = true или false 
            Console.WriteLine(isa);
            Console.WriteLine(ira);

            byte by1 = 1;
            byte by2 = 100; ///byte = 0-255

            Console.WriteLine(by1);
            Console.WriteLine(by2);


            sbyte sb1 = -5;
            sbyte sb2 =127; // sbyte -127 до +12

            Console.WriteLine(sb1);
            Console.WriteLine(sb2);



            short sh1 = 15000; 
            Console.WriteLine(sh1);

            ushort sh2 = 15000;
            Console.WriteLine(sh2);


            int a =-1000023232;
            Console.WriteLine(a);

            uint b = 2323232323;
            Console.WriteLine(b);


            long x = -2323232323232323233;
            Console.WriteLine(x);

            ulong f = 2332323232323232323;
            Console.WriteLine(f);


            float g = 2.323f; // числа с плавающей точкой 
            double j = 2.23323323; // число с плавающей точкой уневерсальное как int 

            char sim = 'a';  // юникод символы 
            String gagag = "ямадама "; // текст 
            Console.WriteLine(gagag);

            object obj = 22;

            // стек + куча -  ссылочные 

            var d = "вывыв"; // уневерсальный тип 


            
















        }

    }
}

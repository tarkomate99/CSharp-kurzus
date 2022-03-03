using System;
using System.Collections.Generic;

namespace HelloVilag
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100_000_000;
            int y = 0xFF;
            uint z = 100000000;
            short f = 0;
            byte b = 255;
            sbyte s = -1;

            float fl = 0.0f;
            float exponent = 1E-3f;
            double dbl = 1.24;

            decimal money = 124.3453M;

            Half h = (Half)12.0d;

            char c = 'A';

            string str = "str";

            long lng = 0;

            var myVariable = 12;

            dynamic asd = 12.0 + "Hello";

            long[] tomb = new long[3];
            long[] tomb2 = new[] { 2l, 1l, 3l };

            long[,] tomb2d = new long[2, 3];

            long[][] jagged = new long[2][]
                { 
                    new long[2],
                    new long[4],
                };

            List<int> items = new List<int>();
            items.Add(1);
            items.Add(2);
            items.Add(3);
            items[2] = 2;

            LinkedList<int> linked = new LinkedList<int>();

            foreach (var item in items) 
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Hot reload");




            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}

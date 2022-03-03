using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public struct Pont
        {
            public int X { get; set; }

            public int Y { get; set; }

            public override string ToString()
            {
                return $"x: {X}; y: {Y}";
            }

            public override bool Equals(object obj)
            {
                return obj is Pont pont &&
                       X == pont.X &&
                       Y == pont.Y;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(X, Y);
            }

            override 
        }

        public record InmutablePont
        {
            public int X { get; init; }

            public int Y { get; init; }

        }

        static void Main(string[] args)
        {
            Pont p = new Pont { 
                X = 10,
                Y = 20
            };
            int a = 44;
            int b = a + 1;
            Console.WriteLine(p);
            Pont p2 = p;
            p2.X = 100;
            Console.WriteLine(p);
            Console.WriteLine(p.Equals(p2));

            var p3 = new Pont
            {
                X = 100,
                Y = 30
            };
            Console.WriteLine(p3);
            Console.WriteLine(p2.Equals(p3));

            InmutablePont ip = new InmutablePont
            {
                X = 20,
                Y = 10
            };

            Console.WriteLine(ip);
            InmutablePont ip2 = ip with 
            {
                X = 100
            };

            Console.WriteLine(ip);
            Console.WriteLine(ip == ip2);

            string s = "foo";
            string g = "foo";
        }
    }
}

using System;
using System.Diagnostics;

namespace UserInput
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int szam;
                string szamSzoveg = Console.ReadLine();
                szam = Convert.ToInt32(szamSzoveg);
                Console.WriteLine("A szam negyzete: {0}", szam * szam);
            }
            catch (Exception e) {
                Debug.WriteLine(e);
            }
        }
    }
}

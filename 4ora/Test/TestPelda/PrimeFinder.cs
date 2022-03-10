using System;

namespace TestPelda
{
    public static class PrimeFinder
    {
        public static bool isPrime(int input) 
        {
            if (input == 2) return true;
            if (input < 3) return false; 
            for (int i = 3; i < Math.Sqrt(input); i++) 
            {
                if (input % i == 0) {
                    return false;
                }
            }
            return true;
        }
    }
}

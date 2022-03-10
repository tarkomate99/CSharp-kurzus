using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPelda
{
    public interface IRandomProvider
    {
        int GetNumber(int minimum, int maxium);
    }

    public class RandomNUmberProvider : IRandomProvider
    {
        private Random _rng = new Random();

        public int GetNumber(int minimum, int maxium)
        {
            return _rng.Next(minimum, maxium);
        }
    }

    public class RandomPrimeProvider
    {
        private readonly IRandomProvider _randomProvider;

        public RandomPrimeProvider(IRandomProvider randomProvider)
        {
            _randomProvider = randomProvider;
        }

        public int GetNumber(int minimum, int maximum) {
            bool isPrime = false;
            do
            {
                int candidate = _randomProvider.GetNumber(minimum, maximum);
                isPrime = PrimeFinder.isPrime(candidate);
                if (isPrime)
                    return candidate;
            }
            while (!isPrime);

            throw new InvalidOperationException("This shouldn't happen...");
        }
    }
}

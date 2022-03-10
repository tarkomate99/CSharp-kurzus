using NUnit.Framework;

namespace TestPelda
{
    [TestFixture]
    internal class PrimeFinderTests
    {
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(8)]
        [TestCase(12)]
        [TestCase(13)]

        public void EnsureThat_PrimeFinder_isPrime_ReturnsTrue_WhenPrime(int input)
        {

            //Arrange + Act
            Assert.IsTrue(PrimeFinder.isPrime(input));
        }
    }
}

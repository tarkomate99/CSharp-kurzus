using NUnit.Framework;

namespace TestPelda
{
    [TestFixture]
    internal class PrimeFinderTests
    {
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(11)]
        [TestCase(13)]
        
        public void EnsureThat_PrimeFinder_isPrime_ReturnsTrue_WhenPrime(int input)
        {

            //Arrange + Act
            Assert.IsTrue(PrimeFinder.isPrime(input));
        }
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(8)]
        [TestCase(49)]

        public void EnsureThat_PrimeFinder_isPrime_ReturnsFalse_WhenNotPrime(int input)
        {

            //Arrange + Act
            Assert.IsFalse(PrimeFinder.isPrime(input));
        }
    }
}

using NUnit.Framework;

namespace TestPelda.Tests
{

    internal class TestRandomProvider : IRandomProvider
    {
        public int GetNumber(int minimum, int maximum)
        {
            return 3;
        }
    }

    [TestFixture]
    internal class RandomPrimeProviderTests
    {

        public void EnsureThat_Random_PrimeProvideWorks()
        {

            RandomPrimeProvider provider = new RandomPrimeProvider(new TestRandomProvider());
            int result = provider.GetNumber(0, 100);
            Assert.AreEqual(3, result);

        }


    }
}

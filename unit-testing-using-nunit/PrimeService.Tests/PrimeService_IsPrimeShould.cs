using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private PrimeService primeService;

        [SetUp]
        public void SetUp()
        {
            primeService = new PrimeService();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = primeService.IsPrime(1);
            Assert.IsFalse(result, "1 should not be prime");
        }

    }
}
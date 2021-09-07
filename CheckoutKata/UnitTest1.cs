using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace CheckoutKata
{
    public class CheckoutTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenIDoNotScanAnItem_TheTotalIsZero()
        {
            var checkout = new Checkout();

            var total = checkout.GetTotal();

            Assert.That(total, Is.Zero);
        }
    }

    public class Checkout
    {
        public int GetTotal()
        {
            return 0;
        }
    }
}
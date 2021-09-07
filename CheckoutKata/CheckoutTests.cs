using NUnit.Framework;

namespace CheckoutKata
{
    public class CheckoutTests
    {
        [Test]
        public void WhenIDoNotScanAnItem_TheTotalIsZero()
        {
            var checkout = new Checkout();

            var total = checkout.GetTotal();

            Assert.That(total, Is.Zero);
        }
    }
}
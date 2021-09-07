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

        [Test]
        public void WhenIScanItemA_TheTotalIsThePriceOfItemA()
        {
            var checkout = new Checkout();

            checkout.ScanItem("A");

            var total = checkout.GetTotal();

            Assert.That(total, Is.EqualTo(50));
        }
    }
}
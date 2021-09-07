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

        [Test]
        public void WhenIScanItemB_TheTotalIsThePriceOfItemB()
        {
            var checkout = new Checkout();

            checkout.ScanItem("B");

            var total = checkout.GetTotal();

            Assert.That(total, Is.EqualTo(30));
        }

        [Test]
        public void WhenIScanItemC_TheTotalIsThePriceOfItemC()
        {
            var checkout = new Checkout();

            checkout.ScanItem("C");

            var total = checkout.GetTotal();

            Assert.That(total, Is.EqualTo(20));
        }
    }
}
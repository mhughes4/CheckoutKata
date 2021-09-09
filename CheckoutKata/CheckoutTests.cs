using NUnit.Framework;
using System.Collections.Generic;

namespace CheckoutKata
{
    public class CheckoutTests
    {
        [Test]
        public void WhenIDoNotScanAnItem_TheTotalIsZero()
        {
            var checkout = new Checkout(new List<Item>
            {
                new Item { Sku = "A", Price = 50},
                new Item { Sku = "B", Price = 30},
                new Item { Sku = "C", Price = 20},
                new Item { Sku = "D", Price = 15}
            });

            var total = checkout.GetTotal();

            Assert.That(total, Is.Zero);
        }

        [Test]
        public void WhenIScanItemA_TheTotalIsThePriceOfItemA()
        {
            var checkout = new Checkout(new List<Item>
            {
                new Item { Sku = "A", Price = 50},
                new Item { Sku = "B", Price = 30},
                new Item { Sku = "C", Price = 20},
                new Item { Sku = "D", Price = 15}
            });

            checkout.ScanItem("A");

            var total = checkout.GetTotal();

            Assert.That(total, Is.EqualTo(50));
        }

        [Test]
        public void WhenIScanItemB_TheTotalIsThePriceOfItemB()
        {
            var checkout = new Checkout(new List<Item>
            {
                new Item { Sku = "A", Price = 50},
                new Item { Sku = "B", Price = 30},
                new Item { Sku = "C", Price = 20},
                new Item { Sku = "D", Price = 15}
            });

            checkout.ScanItem("B");

            var total = checkout.GetTotal();

            Assert.That(total, Is.EqualTo(30));
        }

        [Test]
        public void WhenIScanItemC_TheTotalIsThePriceOfItemC()
        {
            var checkout = new Checkout(new List<Item>
            {
                new Item { Sku = "A", Price = 50},
                new Item { Sku = "B", Price = 30},
                new Item { Sku = "C", Price = 20},
                new Item { Sku = "D", Price = 15}
            });

            checkout.ScanItem("C");

            var total = checkout.GetTotal();

            Assert.That(total, Is.EqualTo(20));
        }

        [Test]
        public void WhenIScanItemD_TheTotalIsThePriceOfItemD()
        {
            var checkout = new Checkout(new List<Item>
            {
                new Item { Sku = "A", Price = 50},
                new Item { Sku = "B", Price = 30},
                new Item { Sku = "C", Price = 20},
                new Item { Sku = "D", Price = 15}
            });

            checkout.ScanItem("D");

            var total = checkout.GetTotal();

            Assert.That(total, Is.EqualTo(15));
        }

        [Test]
        public void WhenIScanAnItem_TheTotalIsTheSumOfAllItems()
        {
            var checkout = new Checkout(new List<Item>
            {
                new Item { Sku = "A", Price = 50},
                new Item { Sku = "B", Price = 30},
                new Item { Sku = "C", Price = 20},
                new Item { Sku = "D", Price = 15}
            });

            checkout.ScanItem("C");
            checkout.ScanItem("C");

            var sum = checkout.GetTotal();
            Assert.That(sum, Is.EqualTo(40));
        }
    }
}
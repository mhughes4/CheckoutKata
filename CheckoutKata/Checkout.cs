using System.Collections.Generic;
using System.Linq;

namespace CheckoutKata
{
    public class Checkout
    {
        private readonly List<Item> _scannableItems;
        private string _scannedItemSku;

        public Checkout(List<Item> scannableItems)
        {
            _scannableItems = scannableItems;
        }

        public void ScanItem(string sku)
        {
            _scannedItemSku = sku;
        }

        public int GetTotal()
        {
            var scannedItem = _scannableItems.SingleOrDefault(i => i.Sku == _scannedItemSku);

            if (scannedItem == null)
            {
                return 0;
            }

            return scannedItem.Price;
        }
    }
}
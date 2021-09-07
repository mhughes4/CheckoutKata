using System;

namespace CheckoutKata
{
    public class Checkout
    {
        private int numberOfScannedItems;

        public int GetTotal()
        {
            if (numberOfScannedItems > 0)
            {
                return 50;
            }
            else
            {
                return 0;
            }
        }

        public void ScanItem(string s)
        {
            numberOfScannedItems += 1;
        }
    }
}
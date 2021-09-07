namespace CheckoutKata
{
    public class Checkout
    {
        private int numberOfScannedItems = 0;

        public void ScanItem(string item)
        {
            numberOfScannedItems += 1;
        }

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
    }
}
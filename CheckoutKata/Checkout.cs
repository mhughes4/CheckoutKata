namespace CheckoutKata
{
    public class Checkout
    {
        private int numberOfScannedAItems = 0;
        private int numberOfScannedBItems = 0;
        private int numberOfScannedCItems = 0;

        public void ScanItem(string item)
        {
            numberOfScannedAItems += 1;

            if (item == "B")
            {
                numberOfScannedBItems += 1;
            }

            if (item == "C")
            {
                numberOfScannedCItems += 1;
            }
        }

        public int GetTotal()
        {
            if (numberOfScannedCItems > 0)
            {
                return 20;
            }
            if (numberOfScannedBItems > 0)
            {
                return 30;
            }
            if (numberOfScannedAItems > 0)
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
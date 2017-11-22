using System;

namespace WebShopV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;

            int noOfBooksInOrder = 23;
            int noOfDVDsInOrder = 16;
            int noOfGamesInOrder = 7;
            double totalPrice = (((netPriceBook * noOfBooksInOrder) + (netPriceDVD * noOfDVDsInOrder) + (netPriceGame * noOfGamesInOrder)) * 1.1 + 49);
            int totalNoOfItems = noOfBooksInOrder + noOfDVDsInOrder + noOfGamesInOrder;
            Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            if (totalNoOfItems < 15)
            {
                Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice*1.02} kr.");
            }
            if (totalNoOfItems >= 15 && totalNoOfItems < 30)
            {
                Console.WriteLine($"Total cost including tax, shipping and credit card fee: {(totalPrice*0.95)*1.02} kr.");
            }
            if (totalNoOfItems >= 30)
            {
                Console.WriteLine($"Total cost including tax, shipping and credit card fee: {(totalPrice*0.9)*1.02} kr.");
            }

            // This variable should contain the total price for the order

            // The LAST line of code should be ABOVE this line
        }
    }
}
using System;
namespace _clas
{

    class stock
    {
        string StockName, StockSymbol;
        double PreviousClosingPrice, CurrentClosingPrice;
        public stock(string name, string symbol, int previousprice, int currentprice)
        {
            StockName = name;
            StockSymbol = symbol;
            PreviousClosingPrice = previousprice;
            CurrentClosingPrice = currentprice;
        }
        public double GetChangePercentage()
        {
            return ((CurrentClosingPrice - PreviousClosingPrice) / PreviousClosingPrice) * 100;

        }
    }
    public class program
    {
        public void Main()
        {
            stock obj = new stock("NYSE", "TUFN", 15000, 23000);
            Console.WriteLine("percentage change from the previous to current is {0}", obj.GetChangePercentage());

        }
    }
}
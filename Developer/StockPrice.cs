using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer
{
    public class StockPrice
    {
        public static void MaxProfit()
        {
            int[] stock = { 100, 180, 260, 310, 40, 535, 695 };

            int maxDiff = 0;
            int BuyPrice= stock[0];
            foreach (int SellPrice in stock)
            {
                foreach (int sellPrice in stock)
                {
                    int diff = sellPrice - BuyPrice;
                    if (diff > maxDiff)
                        maxDiff = diff;
                    if (diff < maxDiff)
                        BuyPrice = SellPrice;
                }
            }
            Console.Write(maxDiff);
        }
    }
}

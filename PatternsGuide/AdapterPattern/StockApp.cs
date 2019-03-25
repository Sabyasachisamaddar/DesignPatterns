using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PatternsGuide.AdapterPattern
{
    class StockApp
    {
        public void ShowStockHistory(string ticker)
        {
            StockHistoryTarget adapter = new StockHistoryAdapter();

            DataTable history = adapter.GetStockPrices(ticker);

            foreach(DataRow row in history.Rows)
            {
                DateTime dt = (DateTime)row[0];
                decimal price = (decimal)row[1];
                Console.WriteLine("On {0:MMM d yyyy} {1} was ${2:0.00}", dt, ticker, price);
            }
        }
    }
}

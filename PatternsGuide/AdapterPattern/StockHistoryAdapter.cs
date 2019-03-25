using System;
using System.Data;

namespace PatternsGuide.AdapterPattern
{
    internal class StockHistoryAdapter : StockHistoryTarget
    {
        private StockHistoryDB _adaptee = new StockHistoryDB();

        public override DataTable GetStockPrices(string ticker)
        {
            decimal[] history = new decimal[] { };
            switch (ticker)
            {
                case "AAPL":
                    history = _adaptee.GetAAPL();
                    break;
                case "MSFT":
                    history = _adaptee.GetMSFT();
                    break;
                case "GOOG":
                    history = _adaptee.GetGOOG();
                    break;
                default:
                    throw new NotImplementedException("Cannot get history for ticker" + ticker);                
            }

            DataTable results = new DataTable();
            results.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            results.Columns.Add(new DataColumn("Price", typeof(decimal)));

            DateTime dt = new DateTime(15, 11, 17);
            for(int i=0; i <3; i++)
            {
                DataRow row = results.NewRow();
                row[0] = dt;
                row[1] = history[i];
                results.Rows.Add(row);
                dt = dt.AddMonths(-1);
            }

            return results;
        }
    }
}
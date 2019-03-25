using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PatternsGuide.AdapterPattern
{
    abstract class StockHistoryTarget
    {
        public abstract DataTable GetStockPrices(string ticker);
    }
}

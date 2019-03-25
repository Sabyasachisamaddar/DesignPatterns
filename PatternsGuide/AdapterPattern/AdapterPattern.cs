using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.AdapterPattern
{
    class AdapterPattern
    {
        public void ImplementPattern()
        {
            StockApp app = new StockApp();
            app.ShowStockHistory("AAPL");
        }
    }
}

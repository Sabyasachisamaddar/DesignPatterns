using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.AdapterPattern
{
    class StockHistoryDB
    {
        public decimal[] GetAAPL()
        {
            return new decimal[] { 121.06m, 119.5m, 110.3m };
        }

        public decimal[] GetMSFT()
        {
            return new decimal[] { 12.06m, 11.5m, 11.3m };
        }

        public decimal[] GetGOOG()
        {
            return new decimal[] { 21.06m, 19.5m, 10.3m };
        }

    }
}

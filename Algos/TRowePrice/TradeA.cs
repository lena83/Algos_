using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.TRowePrice
{
    public class TradeA
    {
        public string InstrumentType { get; set; }
        public string TradeName { get; set; }

        public string TradeDate { get; set;}

        public decimal NPV { get; set; }    
    }

    public class TradeB
    {
        public string InstrumentType { get; set; }
        public string TradeName { get; set; }

        public string TradeDate { get; set; }

        public decimal NPV { get; set; }
    }


    public class Trade
    {
        public string TradeName { get; set; }

        public string TraderName { get; set; }

        public string InstrumentType { get; set; }

        public DateTime TradeDate { get; set; }
        public double Amount { get; set; }
        


        
    }
}

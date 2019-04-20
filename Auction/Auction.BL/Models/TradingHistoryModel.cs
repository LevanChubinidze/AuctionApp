using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.BL.Models
{
    class TradingHistoryModel
    {
        public int Id { get; set; }
        public LotModel Lot { get; set; }
        public TraderModel Trader { get; set; }
        public AuctioneerModel Auctioneer { get; set; }
        public decimal RecordedPrice { get; set; }
        public int BidOrder { get; set; }
        public DateTime BidTime { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.BL.Models
{
    class LotModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal StartingPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal MinimalBid { get; set; }
        public int BidCount { get; set; }
        public DateTime AuctionDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.DL.Models
{
    public class Lot
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public decimal StartingPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal MinimalBid { get; set; }
        public int BidCount { get; set; }
        public DateTime AuctionDate { get; set; }

        public virtual ICollection<TradingHistory> TradingHistories { get; set; }

    }
}

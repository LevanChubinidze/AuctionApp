using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.DL.Models
{
   public class TradingHistory
   {
        [Key, Required]
        public int Id { get; set; }

        [ForeignKey("Lot"), Required]
        public int LotId { get; set; }

        [ForeignKey("Trader"), Required]
        public int TraderId { get; set; }

        [ForeignKey("Auctioneer")]
        public int AuctioneerId { get; set; }

        [Required]
        public decimal RecordedPrice { get; set; }
        [Required]
        public int BidOrder { get; set; }
        [Required]
        public DateTime BidTime { get; set; }

        [Required]
        public virtual Lot Lot { get; set; }
        [Required]
        public virtual Trader Trader { get; set; }
        [Required]
        public virtual Auctioneer Auctioneer { get; set; }
   }
}

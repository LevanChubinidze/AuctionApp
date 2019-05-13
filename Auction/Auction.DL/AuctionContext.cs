using Auction.DL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.DL
{
   public class AuctionContext : DbContext
    {
        public AuctionContext() : base("AuctionContext")
        {
        }

        public DbSet<Lot> Lots { get; set; }
        public DbSet<Trader> Traders { get; set; }
        public DbSet<Auctioneer> Auctioneers { get; set; }
        public DbSet<TradingHistory> TradingHistories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

using Auction.BL.Models;
using Auction.BL.Services;
using Auction.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auction.DL.Services
{
    public class AuctioneerService : IAuctioneerService
    {
        public async Task<AuctioneerModel> EditAuctioneer(AuctioneerModel auctioneerModel)
        {
            if (auctioneerModel == null)
            {
                throw new ArgumentNullException(nameof(auctioneerModel));
            }

            using (var db = new AuctionContext())
            {
                var auctioneer = db.Auctioneers.FirstOrDefault(o => o.Id == auctioneerModel.Id);

                if (auctioneer != null)
                {
                    auctioneer.FirstName = auctioneerModel.FirstName;
                    auctioneer.LastName = auctioneerModel.LastName;
                    auctioneer.UserName = auctioneerModel.UserName;
                    auctioneer.Password = auctioneerModel.Password;
                    auctioneer.IsAdmin = auctioneerModel.IsAdmin;
                }
                await db.SaveChangesAsync();

                return auctioneerModel;
            }
        }

        public async Task<IEnumerable<AuctioneerModel>> GetAuctioneers()
        {
            using (var db = new AuctionContext())
            {
                var auctioneers = db.Auctioneers.Select(a => new AuctioneerModel
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    UserName = a.UserName,
                    Password = a.Password,
                    IsAdmin = a.IsAdmin,
                }).ToList();
                return auctioneers;
            }
        }

        public async Task<AuctioneerModel> LoginAuctioneer(AuctioneerModel auctioneerModel)
        {
            if (auctioneerModel == null)
            {
                throw new ArgumentNullException(nameof(auctioneerModel));
            }

            using (var db = new AuctionContext())
            {
                var found = db.Auctioneers.Any(a =>
                     a.UserName.Equals(auctioneerModel.UserName, StringComparison.CurrentCultureIgnoreCase)
                     && a.Password == auctioneerModel.Password);
                return found ? auctioneerModel : null;
            }
        }

        public async Task<AuctioneerModel> RegisterAuctioneer(AuctioneerModel auctioneerModel)
        {
            if (auctioneerModel == null)
            {
                throw new ArgumentNullException(nameof(auctioneerModel));
            }

            using (var db = new AuctionContext())
            {
                var found = db.Auctioneers.Any(a =>
                     a.UserName.Equals(auctioneerModel.UserName, StringComparison.CurrentCultureIgnoreCase));
                if (found) return null;

                Auctioneer auctioneer = new Auctioneer
                {
                    FirstName = auctioneerModel.FirstName,
                    LastName = auctioneerModel.LastName,
                    UserName = auctioneerModel.UserName,
                    Password = auctioneerModel.Password,
                    IsAdmin = auctioneerModel.IsAdmin,
                };

                db.Auctioneers.Add(auctioneer);
                await db.SaveChangesAsync();

                auctioneerModel.Id = auctioneer.Id;
                return auctioneerModel;
            }
        }

        public async Task<AuctioneerModel> RemoveAuctioneer(AuctioneerModel auctioneerModel)
        {
            if (auctioneerModel == null)
            {
                throw new ArgumentNullException(nameof(auctioneerModel));
            }

            using (var db = new AuctionContext())
            {
                var auctioneer = db.Auctioneers.FirstOrDefault(a => a.Id == auctioneerModel.Id || a.UserName.Equals(auctioneerModel.UserName, StringComparison.CurrentCultureIgnoreCase));
                if (auctioneer == null) return null;

                db.Auctioneers.Remove(auctioneer);
                await db.SaveChangesAsync();
                return auctioneerModel;
            }
        }
    }
}

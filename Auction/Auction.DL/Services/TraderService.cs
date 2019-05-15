using Auction.BL.Models;
using Auction.BL.Services;
using Auction.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.DL.Services
{
    public class TraderService : ITraderService
    {
        public async Task<TraderModel> AddTrader(TraderModel trader)
        {
            if (trader == null)
            {
                throw new ArgumentNullException(nameof(trader));
            }

            using (var db = new AuctionContext())
            {
                var traderEntity = new Trader()
                {
                    Name = trader.Name,
                    LegacyForm = trader.LegacyForm,
                    IdentityNumber = trader.IdentityNumber,
                    ApplicantName = trader.ApplicantName,
                    ParticipantName = trader.ParticipantName,
                    ParticipantStatus = trader.ParticipantStatus,
                    PhoneNumber = trader.PhoneNumber,
                    Email = trader.Email,
                    BankName = trader.BankName,
                    BankAccountNumber = trader.BankAccountNumber,
                    Swift = trader.Swift,
                    AuctionDate = trader.AuctionDate
                };

                db.Traders.Add(traderEntity);
                await db.SaveChangesAsync();
                trader.Id = traderEntity.Id;
                return trader;
            }
        }

        public async Task<TraderModel> EditTrader(TraderModel trader)
        {
            if (trader == null)
            {
                throw new ArgumentNullException(nameof(trader));
            }

            using (var db = new AuctionContext())
            {
                var traderEntity = db.Traders.FirstOrDefault(t => t.Id == trader.Id);
                if (traderEntity == null) return null;

                traderEntity.LegacyForm = trader.LegacyForm;
                traderEntity.IdentityNumber = trader.IdentityNumber;
                traderEntity.ApplicantName = trader.ApplicantName;
                traderEntity.ParticipantName = trader.ParticipantName;
                traderEntity.ParticipantStatus = trader.ParticipantStatus;
                traderEntity.PhoneNumber = trader.PhoneNumber;
                traderEntity.Email = trader.Email;
                traderEntity.BankName = trader.BankName;
                traderEntity.BankAccountNumber = trader.BankAccountNumber;
                traderEntity.Swift = trader.Swift;
                traderEntity.AuctionDate = trader.AuctionDate;

                await db.SaveChangesAsync();

                return trader;
            }
        }

        public async Task<IEnumerable<TraderModel>> GetTraders()
        {
            using (var db = new AuctionContext())
            {
                var traders = db.Traders.Select(t => new TraderModel
                {
                    Id = t.Id,
                    Name = t.Name,
                    LegacyForm = t.LegacyForm,
                    IdentityNumber = t.IdentityNumber,
                    ApplicantName = t.ApplicantName,
                    ParticipantName = t.ParticipantName,
                    ParticipantStatus = t.ParticipantStatus,
                    PhoneNumber = t.PhoneNumber,
                    Email = t.Email,
                    BankName = t.BankName,
                    BankAccountNumber = t.BankAccountNumber,
                    Swift = t.Swift,
                    AuctionDate = t.AuctionDate
                }).ToList();

                return traders;
            }
        }

        public async Task<IEnumerable<TraderModel>> GetTradersByDate(DateTime start, DateTime end)
        {
            using (var db = new AuctionContext())
            {
                var traders = db.Traders
                    .Where(t => t.AuctionDate >= start && t.AuctionDate <= end)
                    .Select(t => new TraderModel
                    {
                        Id = t.Id,
                        Name = t.Name,
                        LegacyForm = t.LegacyForm,
                        IdentityNumber = t.IdentityNumber,
                        ApplicantName = t.ApplicantName,
                        ParticipantName = t.ParticipantName,
                        ParticipantStatus = t.ParticipantStatus,
                        PhoneNumber = t.PhoneNumber,
                        Email = t.Email,
                        BankName = t.BankName,
                        BankAccountNumber = t.BankAccountNumber,
                        Swift = t.Swift,
                        AuctionDate = t.AuctionDate
                    }).ToList();

                return traders;
            }
        }

        public async Task<IEnumerable<TraderModel>> GetTradersByNameAndDate(string name, DateTime start, DateTime end)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using (var db = new AuctionContext())
            {
                var traders = db.Traders
                    .Where(t => 
                    t.AuctionDate >= start 
                    && t.AuctionDate <= end
                    && t.Name == name)
                    .Select(t => new TraderModel
                    {
                        Id = t.Id,
                        Name = t.Name,
                        LegacyForm = t.LegacyForm,
                        IdentityNumber = t.IdentityNumber,
                        ApplicantName = t.ApplicantName,
                        ParticipantName = t.ParticipantName,
                        ParticipantStatus = t.ParticipantStatus,
                        PhoneNumber = t.PhoneNumber,
                        Email = t.Email,
                        BankName = t.BankName,
                        BankAccountNumber = t.BankAccountNumber,
                        Swift = t.Swift,
                        AuctionDate = t.AuctionDate
                    }).ToList();

                return traders;
            }
        }
    }
}

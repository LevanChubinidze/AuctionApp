using Auction.BL.Models;
using Auction.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.DL.Utils
{
    internal static class Extensions
    {
        public static AuctioneerModel ToAuctioneerModel(this Auctioneer auctioneer)
        {
            if (auctioneer == null)
            {
                throw new ArgumentNullException(nameof(auctioneer));
            }

            return new AuctioneerModel()
            {
                Id = auctioneer.Id,
                FirstName = auctioneer.FirstName,
                LastName = auctioneer.LastName,
                UserName = auctioneer.UserName,
                Password = auctioneer.Password,
                IsAdmin = auctioneer.IsAdmin
            };
        }

        public static Auctioneer ToAuctioneer(this AuctioneerModel auctioneer)
        {
            if (auctioneer == null)
            {
                throw new ArgumentNullException(nameof(auctioneer));
            }

            return new Auctioneer()
            {
                FirstName = auctioneer.FirstName,
                LastName = auctioneer.LastName,
                UserName = auctioneer.UserName,
                Password = auctioneer.Password,
                IsAdmin = auctioneer.IsAdmin
            };
        }

        public static LotModel ToLotModel(this Lot lot)
        {
            if (lot == null)
            {
                throw new ArgumentNullException(nameof(lot));
            }

            return new LotModel()
            {
                Id = lot.Id,
                Name = lot.Name,
                Description = lot.Description,
                Quantity = lot.Quantity,
                Unit = lot.Unit,
                StartingPrice = lot.StartingPrice,
                CurrentPrice = lot.CurrentPrice,
                MinimalBid = lot.MinimalBid,
                BidCount = lot.BidCount,
                AuctionDate = lot.AuctionDate
            };
        }

        public static Lot ToLot(this LotModel lot)
        {
            if (lot == null)
            {
                throw new ArgumentNullException(nameof(lot));
            }

            return new Lot()
            {
                Name = lot.Name,
                Description = lot.Description,
                Quantity = lot.Quantity,
                Unit = lot.Unit,
                StartingPrice = lot.StartingPrice,
                CurrentPrice = lot.CurrentPrice,
                MinimalBid = lot.MinimalBid,
                BidCount = lot.BidCount,
                AuctionDate = lot.AuctionDate
            };
        }

        public static TraderModel ToTraderModel(this Trader trader)
        {
            if (trader == null)
            {
                throw new ArgumentNullException(nameof(trader));
            }

            return new TraderModel()
            {
                Id = trader.Id,
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
        }

        public static Trader ToTrader(this TraderModel trader)
        {
            if (trader == null)
            {
                throw new ArgumentNullException(nameof(trader));
            }

            return new Trader()
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
        }

        public static TradingHistory ToTradingHistory(
            this TradingHistoryModel tradingHistory, 
            Auctioneer auctioneer,
            Trader trader,
            Lot lot)
        {
            if (tradingHistory == null)
            {
                throw new ArgumentNullException(nameof(tradingHistory));
            }

            if (auctioneer == null)
            {
                throw new ArgumentNullException(nameof(auctioneer));
            }

            if (trader == null)
            {
                throw new ArgumentNullException(nameof(trader));
            }

            if (lot == null)
            {
                throw new ArgumentNullException(nameof(lot));
            }

            return new TradingHistory
            {
                AuctioneerId  = auctioneer.Id,
                LotId= lot.Id,
                TraderId = trader.Id,
                BidTime = tradingHistory.BidTime,
                BidOrder = tradingHistory.BidOrder,
                RecordedPrice = tradingHistory.RecordedPrice,
                Auctioneer = auctioneer,
                Lot = lot,
                Trader = trader
            };
        }

        public static TradingHistoryModel ToTradingHistoryModel(this TradingHistory tradingHistory)
        {
            return new TradingHistoryModel
            {
                Id = tradingHistory.Id,
                BidTime = tradingHistory.BidTime,
                BidOrder = tradingHistory.BidOrder,
                RecordedPrice = tradingHistory.RecordedPrice,
                Auctioneer = tradingHistory.Auctioneer.ToAuctioneerModel(),
                Lot = tradingHistory.Lot.ToLotModel(),
                Trader = tradingHistory.Trader.ToTraderModel()
            };
        }

        public static void MapTo(this TraderModel traderModel, Trader trader)
        {
            if (traderModel == null)
            {
                throw new ArgumentNullException(nameof(traderModel));
            }

            if (trader == null)
            {
                throw new ArgumentNullException(nameof(trader));
            }

            trader.Name = traderModel.Name;
            trader.LegacyForm = traderModel.LegacyForm;
            trader.IdentityNumber = traderModel.IdentityNumber;
            trader.ApplicantName = traderModel.ApplicantName;
            trader.ParticipantName = traderModel.ParticipantName;
            trader.ParticipantStatus = traderModel.ParticipantStatus;
            trader.PhoneNumber = traderModel.PhoneNumber;
            trader.Email = traderModel.Email;
            trader.BankName = traderModel.BankName;
            trader.BankAccountNumber = traderModel.BankAccountNumber;
            trader.Swift = traderModel.Swift;
            trader.AuctionDate = traderModel.AuctionDate;
        }

        public static void MapTo(this Trader trader, TraderModel traderModel)
        {
            if (trader == null)
            {
                throw new ArgumentNullException(nameof(trader));
            }

            if (traderModel == null)
            {
                throw new ArgumentNullException(nameof(traderModel));
            }

            traderModel.Id = trader.Id;
            traderModel.Name = trader.Name;
            traderModel.LegacyForm = trader.LegacyForm;
            traderModel.IdentityNumber = trader.IdentityNumber;
            traderModel.ApplicantName = trader.ApplicantName;
            traderModel.ParticipantName = trader.ParticipantName;
            traderModel.ParticipantStatus = trader.ParticipantStatus;
            traderModel.PhoneNumber = trader.PhoneNumber;
            traderModel.Email = trader.Email;
            traderModel.BankName = trader.BankName;
            traderModel.BankAccountNumber = trader.BankAccountNumber;
            traderModel.Swift = trader.Swift;
            traderModel.AuctionDate = trader.AuctionDate;

        }

        public static void MapTo(this LotModel lotModel, Lot lot)
        {
            if (lotModel == null)
            {
                throw new ArgumentNullException(nameof(lotModel));
            }

            if (lot == null)
            {
                throw new ArgumentNullException(nameof(lot));
            }

            lot.Name = lotModel.Name;
            lot.Description = lotModel.Description;
            lot.Quantity = lotModel.Quantity;
            lot.Unit = lotModel.Unit;
            lot.StartingPrice = lotModel.StartingPrice;
            lot.CurrentPrice = lotModel.CurrentPrice;
            lot.MinimalBid = lotModel.MinimalBid;
            lot.BidCount = lotModel.BidCount;
            lot.AuctionDate = lotModel.AuctionDate;
        }

        public static void MapTo(this Lot lot, LotModel lotModel)
        {
            if (lot == null)
            {
                throw new ArgumentNullException(nameof(lot));
            }

            if (lotModel == null)
            {
                throw new ArgumentNullException(nameof(lotModel));
            }

            lotModel.Id = lot.Id;
            lotModel.Name = lot.Name;
            lotModel.Description = lot.Description;
            lotModel.Quantity = lot.Quantity;
            lotModel.Unit = lot.Unit;
            lotModel.StartingPrice = lot.StartingPrice;
            lotModel.CurrentPrice = lot.CurrentPrice;
            lotModel.MinimalBid = lot.MinimalBid;
            lotModel.BidCount = lot.BidCount;
            lotModel.AuctionDate = lot.AuctionDate;
        }

        public static void MapTo(this Auctioneer auctioneer, AuctioneerModel auctioneerModel)
        {
            if (auctioneer == null)
            {
                throw new ArgumentNullException(nameof(auctioneer));
            }

            if (auctioneerModel == null)
            {
                throw new ArgumentNullException(nameof(auctioneerModel));
            }

            auctioneerModel.Id = auctioneer.Id;
            auctioneerModel.FirstName = auctioneer.FirstName;
            auctioneerModel.LastName = auctioneer.LastName;
            auctioneerModel.UserName = auctioneer.UserName;
            auctioneerModel.Password = auctioneer.Password;
            auctioneerModel.IsAdmin = auctioneer.IsAdmin;
        }

        public static void MapTo(this AuctioneerModel auctioneerModel, Auctioneer auctioneer)
        {
            if (auctioneerModel == null)
            {
                throw new ArgumentNullException(nameof(auctioneerModel));
            }

            if (auctioneer == null)
            {
                throw new ArgumentNullException(nameof(auctioneer));
            }

            auctioneer.FirstName = auctioneerModel.FirstName;
            auctioneer.LastName = auctioneerModel.LastName;
            auctioneer.UserName = auctioneerModel.UserName;
            auctioneer.Password = auctioneerModel.Password;
            auctioneer.IsAdmin = auctioneerModel.IsAdmin;
        }
    }
}

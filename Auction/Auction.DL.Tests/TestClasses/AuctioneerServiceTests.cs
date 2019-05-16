using System;
using System.Linq;
using System.Threading.Tasks;
using Auction.BL.Models;
using Auction.BL.Services;
using Auction.DL.Models;
using Auction.DL.Tests.Utils;
using NUnit.Framework;
using Unity;

namespace Auction.DL.Tests.TestClasses
{

    public class AuctioneerServiceTests : BaseTest
    {
        [SetUp]
        public void SetUpMethod()
        {
            using (var db = new AuctionContext())
            {
                var auctioneer = db.Auctioneers.ToList();
                db.Auctioneers.RemoveRange(auctioneer);
            }

        }

        [Test]
        public async Task AuctioneerRegistered()
        {
            var service = container.Resolve<IAuctioneerService>();
            var auctioneerModel = new AuctioneerModel
            {
                FirstName = "FirstName",
                LastName = "LastName",
                IsAdmin = true,
                Password = "123",
                UserName = "User",
            };

            var result = await service.RegisterAuctioneer(auctioneerModel);
            var auctioneer = (await service.GetAuctioneers()).First();

            Assert.IsTrue(auctioneerModel.IsEqualTo(auctioneer));

            Assert.IsNotNull(result);

            await service.RemoveAuctioneer(result);

        }

        [Test]
        public async Task AuctioneerWithSameUserNameDoesNotRegistered()
        {
            var service = container.Resolve<IAuctioneerService>();
            var first = new AuctioneerModel
            {
                FirstName = "F1",
                LastName = "L1",
                IsAdmin = true,
                Password = "123",
                UserName = "User",
            };

            var second = new AuctioneerModel
            {
                FirstName = "F2",
                LastName = "L2",
                IsAdmin = true,
                Password = "1",
                UserName = "User",
            };

            var firstResult = await service.RegisterAuctioneer(first);
            var secondResult = await service.RegisterAuctioneer(second);

            Assert.IsNotNull(firstResult);
            Assert.IsNull(secondResult);

            await service.RemoveAuctioneer(firstResult);
        }

        [Test]
        public async Task AllAuctioneerRetrieved()
        {
            var service = container.Resolve<IAuctioneerService>();
            AuctioneerModel[] auctioneersExpected =
            {
                new AuctioneerModel
                {
                    FirstName = "F1",
                    LastName = "L1",
                    IsAdmin = true,
                    Password = "123",
                    UserName = "User1",
                },

                new AuctioneerModel
                {
                    FirstName = "F2",
                    LastName = "L2",
                    IsAdmin = true,
                    Password = "1",
                    UserName = "User2",
                }
            };

            foreach (var auctioneer in auctioneersExpected)
            {
                await service.RegisterAuctioneer(auctioneer);
            }

            var auctioneersActual = await service.GetAuctioneers();

            Assert.IsTrue(auctioneersExpected.SequenceEqual(auctioneersActual, new AuctoineerModelEquilityComparer()));

            foreach (var auctioneer in auctioneersExpected)
            {
                await service.RemoveAuctioneer(auctioneer);
            }
        }

        [Test]
        public async Task AuctioneerEdited()
        {
            var service = container.Resolve<IAuctioneerService>();
            var auctioneerModel = new AuctioneerModel
            {
                FirstName = "FirstName",
                LastName = "LastName",
                IsAdmin = true,
                Password = "123",
                UserName = "User",
            };

            var registeredAuctioneer = await service.RegisterAuctioneer(auctioneerModel);
            registeredAuctioneer.FirstName = "Modified Name";

            await service.EditAuctioneer(registeredAuctioneer);
            var auctioneerInDatabase = (await service.GetAuctioneers()).First();
            Assert.AreEqual("Modified Name", auctioneerInDatabase.FirstName);
        }


        [Test]
        public async Task AuctioneerIsNotEditedIfUsernameMatches()
        {
            var service = container.Resolve<IAuctioneerService>();
            var first = new AuctioneerModel
            {
                FirstName = "FirstName",
                LastName = "LastName",
                IsAdmin = true,
                Password = "123",
                UserName = "User",
            };

            var second = new AuctioneerModel
            {
                FirstName = "FirstName",
                LastName = "LastName",
                IsAdmin = true,
                Password = "123",
                UserName = "OtherUser",
            };

            await service.RegisterAuctioneer(first);
            var secondAuctioneer = await service.RegisterAuctioneer(second);

            secondAuctioneer.UserName = "User";

            var editResult = await service.EditAuctioneer(secondAuctioneer);

            Assert.IsNull(editResult);

            await service.RemoveAuctioneer(first);
            await service.RemoveAuctioneer(second);
        }

    }
}

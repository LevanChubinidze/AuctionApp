namespace Auction.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auctioneer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TradingHistory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LotId = c.Int(nullable: false),
                        TraderId = c.Int(nullable: false),
                        AuctioneerId = c.Int(nullable: false),
                        RecordedPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BidOrder = c.Int(nullable: false),
                        BidTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Auctioneer", t => t.AuctioneerId, cascadeDelete: true)
                .ForeignKey("dbo.Lot", t => t.LotId, cascadeDelete: true)
                .ForeignKey("dbo.Trader", t => t.TraderId, cascadeDelete: true)
                .Index(t => t.LotId)
                .Index(t => t.TraderId)
                .Index(t => t.AuctioneerId);
            
            CreateTable(
                "dbo.Lot",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Unit = c.String(),
                        StartingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurrentPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MinimalBid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BidCount = c.Int(nullable: false),
                        AuctionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trader",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LegacyForm = c.String(),
                        IdentityNumber = c.String(),
                        ApplicantName = c.String(),
                        ParticipantName = c.String(),
                        ParticipantStatus = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        BankName = c.String(),
                        BankAccountNumber = c.String(),
                        Swift = c.String(),
                        AuctionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TradingHistory", "TraderId", "dbo.Trader");
            DropForeignKey("dbo.TradingHistory", "LotId", "dbo.Lot");
            DropForeignKey("dbo.TradingHistory", "AuctioneerId", "dbo.Auctioneer");
            DropIndex("dbo.TradingHistory", new[] { "AuctioneerId" });
            DropIndex("dbo.TradingHistory", new[] { "TraderId" });
            DropIndex("dbo.TradingHistory", new[] { "LotId" });
            DropTable("dbo.Trader");
            DropTable("dbo.Lot");
            DropTable("dbo.TradingHistory");
            DropTable("dbo.Auctioneer");
        }
    }
}

namespace WebWinkel2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Afdelings",
                c => new
                    {
                        AfdelingId = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                    })
                .PrimaryKey(t => t.AfdelingId);
            
            CreateTable(
                "dbo.Boodschappenlijsts",
                c => new
                    {
                        BoodschappenlijstID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.BoodschappenlijstID);
            
            CreateTable(
                "dbo.Eindproducts",
                c => new
                    {
                        EindproductID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(),
                        MerkID = c.Int(),
                        BoodschappenlijstID = c.Int(),
                        ReceptID = c.Int(),
                    })
                .PrimaryKey(t => t.EindproductID)
                .ForeignKey("dbo.Boodschappenlijsts", t => t.BoodschappenlijstID)
                .ForeignKey("dbo.Merks", t => t.MerkID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .ForeignKey("dbo.Recepts", t => t.ReceptID)
                .Index(t => t.ProductID)
                .Index(t => t.MerkID)
                .Index(t => t.BoodschappenlijstID)
                .Index(t => t.ReceptID);
            
            CreateTable(
                "dbo.Kortings",
                c => new
                    {
                        KortingID = c.Int(nullable: false, identity: true),
                        StartDatum = c.DateTime(nullable: false),
                        EindDatum = c.DateTime(nullable: false),
                        Hoeveelheid = c.Int(nullable: false),
                        EindproductID = c.Int(),
                    })
                .PrimaryKey(t => t.KortingID)
                .ForeignKey("dbo.Eindproducts", t => t.EindproductID)
                .Index(t => t.EindproductID);
            
            CreateTable(
                "dbo.Merks",
                c => new
                    {
                        MerkID = c.Int(nullable: false, identity: true),
                        MerkNaam = c.String(),
                    })
                .PrimaryKey(t => t.MerkID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductNaam = c.String(),
                        AfdelingID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Afdelings", t => t.AfdelingID)
                .Index(t => t.AfdelingID);
            
            CreateTable(
                "dbo.Recepts",
                c => new
                    {
                        ReceptID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ReceptID);
            
            CreateTable(
                "dbo.Prijs",
                c => new
                    {
                        PrijsID = c.Int(nullable: false, identity: true),
                        Hoeveelheid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PrijsID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Eindproducts", "ReceptID", "dbo.Recepts");
            DropForeignKey("dbo.Eindproducts", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "AfdelingID", "dbo.Afdelings");
            DropForeignKey("dbo.Eindproducts", "MerkID", "dbo.Merks");
            DropForeignKey("dbo.Kortings", "EindproductID", "dbo.Eindproducts");
            DropForeignKey("dbo.Eindproducts", "BoodschappenlijstID", "dbo.Boodschappenlijsts");
            DropIndex("dbo.Products", new[] { "AfdelingID" });
            DropIndex("dbo.Kortings", new[] { "EindproductID" });
            DropIndex("dbo.Eindproducts", new[] { "ReceptID" });
            DropIndex("dbo.Eindproducts", new[] { "BoodschappenlijstID" });
            DropIndex("dbo.Eindproducts", new[] { "MerkID" });
            DropIndex("dbo.Eindproducts", new[] { "ProductID" });
            DropTable("dbo.Prijs");
            DropTable("dbo.Recepts");
            DropTable("dbo.Products");
            DropTable("dbo.Merks");
            DropTable("dbo.Kortings");
            DropTable("dbo.Eindproducts");
            DropTable("dbo.Boodschappenlijsts");
            DropTable("dbo.Afdelings");
        }
    }
}

namespace nl2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Komitents",
                c => new
                    {
                        KomitentId = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Priimek = c.String(),
                        DavcnaStevilka = c.String(),
                        DatumRojstva = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.KomitentId);
            
            CreateTable(
                "dbo.Račun",
                c => new
                    {
                        RačunId = c.Int(nullable: false, identity: true),
                        stanje = c.Double(nullable: false),
                        limit = c.Double(nullable: false),
                        blokiran = c.Boolean(nullable: false),
                        Banka = c.String(),
                        lastnik_KomitentId = c.Int(),
                    })
                .PrimaryKey(t => t.RačunId)
                .ForeignKey("dbo.Komitents", t => t.lastnik_KomitentId)
                .Index(t => t.lastnik_KomitentId);
            
            CreateTable(
                "dbo.Transakcijas",
                c => new
                    {
                        TransakcijaId = c.Int(nullable: false, identity: true),
                        datumTransakcije = c.DateTime(nullable: false),
                        znesek = c.Double(nullable: false),
                        datum = c.String(),
                        račun_RačunId = c.Int(),
                    })
                .PrimaryKey(t => t.TransakcijaId)
                .ForeignKey("dbo.Račun", t => t.račun_RačunId)
                .Index(t => t.račun_RačunId);
            
            CreateTable(
                "dbo.UporabniskiRacuns",
                c => new
                    {
                        UporabniskiRacunId = c.Int(nullable: false, identity: true),
                        ime = c.String(),
                        geslo = c.String(),
                        aliJeAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UporabniskiRacunId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transakcijas", "račun_RačunId", "dbo.Račun");
            DropForeignKey("dbo.Račun", "lastnik_KomitentId", "dbo.Komitents");
            DropIndex("dbo.Transakcijas", new[] { "račun_RačunId" });
            DropIndex("dbo.Račun", new[] { "lastnik_KomitentId" });
            DropTable("dbo.UporabniskiRacuns");
            DropTable("dbo.Transakcijas");
            DropTable("dbo.Račun");
            DropTable("dbo.Komitents");
        }
    }
}

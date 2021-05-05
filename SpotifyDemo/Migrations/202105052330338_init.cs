namespace SpotifyDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        AdminAd = c.String(),
                        AdminMail = c.String(),
                        AdminSifre = c.String(),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumID = c.Int(nullable: false, identity: true),
                        AlbumAd = c.String(),
                        AlbumSanatci_SanatciID = c.Int(),
                    })
                .PrimaryKey(t => t.AlbumID)
                .ForeignKey("dbo.Sanatcis", t => t.AlbumSanatci_SanatciID)
                .Index(t => t.AlbumSanatci_SanatciID);
            
            CreateTable(
                "dbo.Sanatcis",
                c => new
                    {
                        SanatciID = c.Int(nullable: false, identity: true),
                        SanatciAd = c.String(),
                        SanatciUlke = c.String(),
                    })
                .PrimaryKey(t => t.SanatciID);
            
            CreateTable(
                "dbo.Sarkis",
                c => new
                    {
                        SarkiID = c.Int(nullable: false, identity: true),
                        SarkiAd = c.String(),
                        SarkiTarih = c.DateTime(nullable: false),
                        SarkiTur = c.Double(nullable: false),
                        SarkiSure = c.Single(nullable: false),
                        SarkiDinlenmeSayisi = c.Int(nullable: false),
                        SarkiAlbum_AlbumID = c.Int(),
                        Sanatci_SanatciID = c.Int(),
                    })
                .PrimaryKey(t => t.SarkiID)
                .ForeignKey("dbo.Albums", t => t.SarkiAlbum_AlbumID)
                .ForeignKey("dbo.Sanatcis", t => t.Sanatci_SanatciID)
                .Index(t => t.SarkiAlbum_AlbumID)
                .Index(t => t.Sanatci_SanatciID);
            
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        KullaniciID = c.Int(nullable: false, identity: true),
                        KullaniciAd = c.String(),
                        KullaniciMail = c.String(),
                        KullaniciSifre = c.String(),
                        KullaniciAbonelikTur = c.String(),
                        KullaniciUlke = c.String(),
                    })
                .PrimaryKey(t => t.KullaniciID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Albums", "AlbumSanatci_SanatciID", "dbo.Sanatcis");
            DropForeignKey("dbo.Sarkis", "Sanatci_SanatciID", "dbo.Sanatcis");
            DropForeignKey("dbo.Sarkis", "SarkiAlbum_AlbumID", "dbo.Albums");
            DropIndex("dbo.Sarkis", new[] { "Sanatci_SanatciID" });
            DropIndex("dbo.Sarkis", new[] { "SarkiAlbum_AlbumID" });
            DropIndex("dbo.Albums", new[] { "AlbumSanatci_SanatciID" });
            DropTable("dbo.Kullanicis");
            DropTable("dbo.Sarkis");
            DropTable("dbo.Sanatcis");
            DropTable("dbo.Albums");
            DropTable("dbo.Admins");
        }
    }
}

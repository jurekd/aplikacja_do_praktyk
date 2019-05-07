namespace praktyki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Praktykis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        LiczbaMiejc = c.Int(nullable: false),
                        Opis = c.String(),
                        Tagi = c.String(),
                        Wymagania = c.String(),
                        Kontakt = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Praktykis");
        }
    }
}

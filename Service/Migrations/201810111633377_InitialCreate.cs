namespace Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Disks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        genre = c.String(nullable: false),
                        description = c.String(nullable: false),
                        director = c.String(nullable: false),
                        country = c.String(nullable: false),
                        takenByClient = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Disks");
        }
    }
}

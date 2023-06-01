namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(nullable: false),
                        Days = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Restaurant_Name = c.String(nullable: false, maxLength: 128),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_Name, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Restaurant_Name)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Address = c.String(nullable: false),
                        YearlyProfit = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Reservations", "Restaurant_Name", "dbo.Restaurants");
            DropIndex("dbo.Reservations", new[] { "Client_Id" });
            DropIndex("dbo.Reservations", new[] { "Restaurant_Name" });
            DropTable("dbo.Restaurants");
            DropTable("dbo.Reservations");
            DropTable("dbo.Clients");
        }
    }
}

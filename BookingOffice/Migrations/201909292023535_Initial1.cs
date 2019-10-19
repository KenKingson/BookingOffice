namespace BookingOffice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        From = c.String(),
                        To = c.String(),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(nullable: false),
                        Aircraft = c.String(),
                        TimeZone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FlightId = c.Guid(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                        Price = c.Single(nullable: false),
                        DateOfPushcare = c.DateTime(nullable: false),
                        FlightClass = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tickets");
            DropTable("dbo.Flights");
        }
    }
}

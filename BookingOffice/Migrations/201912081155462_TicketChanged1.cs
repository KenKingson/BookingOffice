namespace BookingOffice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TicketChanged1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Tickets", "CustomerId", c => c.String());
            AlterColumn("dbo.Tickets", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.Tickets", "FlightClass", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tickets", "FlightClass", c => c.Int(nullable: false));
            AlterColumn("dbo.Tickets", "Price", c => c.Single(nullable: false));
            AlterColumn("dbo.Tickets", "CustomerId", c => c.Guid(nullable: false));
        }
    }
}

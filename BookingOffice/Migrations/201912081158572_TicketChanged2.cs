namespace BookingOffice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TicketChanged2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tickets", "CustomerId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tickets", "CustomerId", c => c.String());
        }
    }
}

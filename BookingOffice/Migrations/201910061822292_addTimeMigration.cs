namespace BookingOffice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTimeMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Flights", "TimeFrom", c => c.DateTime(nullable: false));
            AddColumn("dbo.Flights", "TimeTo", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Flights", "TimeTo");
            DropColumn("dbo.Flights", "TimeFrom");
        }
    }
}

namespace BookingOffice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "PassportCode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "PassportCode", c => c.Guid(nullable: false));
            AlterColumn("dbo.Customers", "Id", c => c.Guid(nullable: false));
        }
    }
}

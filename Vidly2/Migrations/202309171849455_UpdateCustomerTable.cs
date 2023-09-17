namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "MembershipType_Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "MembershipType_Name", c => c.Byte(nullable: false));
        }
    }
}

namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUpdateCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers set MembershipType_Name = 'Pay as You Go'");
        }
        
        public override void Down()
        {
        }
    }
}

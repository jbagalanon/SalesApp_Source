#region Using

using System.Data.Entity.Migrations;

#endregion

namespace SalesApp.Migrations
{
    public partial class SalesTargets : DbMigration
    {

        #region Up

        public override void Up()
        {
            AddColumn("dbo.SalesPersons", "SalesTarget", c => c.Decimal(false, 18, 2, 1000.00M));
            AddColumn("dbo.SalesRegions", "SalesTarget", c => c.Decimal(false, 18, 2, 10000.00M));
        }

        #endregion

        #region Down

        public override void Down()
        {
            DropColumn("dbo.SalesRegions", "SalesTarget");
            DropColumn("dbo.SalesPersons", "SalesTarget");
        }

        #endregion

    }
}

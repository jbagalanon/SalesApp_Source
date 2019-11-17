#region Using

using System.Data.Entity.Migrations;

#endregion

namespace SalesApp.Migrations
{
    public partial class Initial : DbMigration
    {

        #region Up

        public override void Up()
        {
            CreateTable(
                "dbo.SalesPersons",
                c => new
                    {
                        Id = c.Int(false, true),
                        Active = c.Boolean(false),
                        FirstName = c.String(false, 100),
                        LastName = c.String(false, 100),
                        RegionId = c.Int(false),
                        CreatedBy = c.String(false, 100),
                        CreatedDate = c.DateTime(false),
                        UpdatedBy = c.String(false, 100),
                        UpdatedDate = c.DateTime(false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SalesRegions", t => t.RegionId)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.SalesRegions",
                c => new
                    {
                        Id = c.Int(false, true),
                        Active = c.Boolean(false),
                        Name = c.String(false, 100),
                        Code = c.String(false, 3),
                        CreatedBy = c.String(false, 100),
                        CreatedDate = c.DateTime(false),
                        UpdatedBy = c.String(false, 100),
                        UpdatedDate = c.DateTime(false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(false, true),
                        Amount = c.Decimal(false, 18, 2),
                        Date = c.DateTime(false),
                        PersonId = c.Int(false),
                        RegionId = c.Int(false),
                        CreatedBy = c.String(false, 100),
                        CreatedDate = c.DateTime(false),
                        UpdatedBy = c.String(false, 100),
                        UpdatedDate = c.DateTime(false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SalesPersons", t => t.PersonId)
                .ForeignKey("dbo.SalesRegions", t => t.RegionId)
                .Index(t => t.PersonId)
                .Index(t => t.RegionId);
            
        }

        #endregion

        #region Down

        public override void Down()
        {
            DropForeignKey("dbo.Sales", "RegionId", "dbo.SalesRegions");
            DropForeignKey("dbo.Sales", "PersonId", "dbo.SalesPersons");
            DropForeignKey("dbo.SalesPersons", "RegionId", "dbo.SalesRegions");
            DropIndex("dbo.Sales", new[] { "RegionId" });
            DropIndex("dbo.Sales", new[] { "PersonId" });
            DropIndex("dbo.SalesPersons", new[] { "RegionId" });
            DropTable("dbo.Sales");
            DropTable("dbo.SalesRegions");
            DropTable("dbo.SalesPersons");
        }

        #endregion

    }
}

namespace FreshGreensShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsInCampaign = c.Boolean(nullable: false),
                        DiscountRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TaxRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FeaturedImage = c.String(),
                        CategoryId = c.Int(nullable: false),
                        MeasurementUnitId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.measurement_units", t => t.MeasurementUnitId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.MeasurementUnitId);
            
            CreateTable(
                "dbo.product_images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        ProductId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.measurement_units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.products", "MeasurementUnitId", "dbo.measurement_units");
            DropForeignKey("dbo.product_images", "ProductId", "dbo.products");
            DropForeignKey("dbo.products", "CategoryId", "dbo.categories");
            DropIndex("dbo.product_images", new[] { "ProductId" });
            DropIndex("dbo.products", new[] { "MeasurementUnitId" });
            DropIndex("dbo.products", new[] { "CategoryId" });
            DropTable("dbo.measurement_units");
            DropTable("dbo.product_images");
            DropTable("dbo.products");
            DropTable("dbo.categories");
        }
    }
}

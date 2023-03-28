using System.Data.Entity;

namespace FreshGreensShop.Data
{
    public class FreshGreensContext : DbContext
    {
        public FreshGreensContext() : base("fresh_greens_db")
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<MeasurementUnit> MeasurementUnits { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreshGreensShop.Data
{
    [Table("products")]
    public class Product : BaseEntity
    {
        public decimal Price { get; set; }
        public bool IsInCampaign { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal TaxRate { get; set; }
        public string FeaturedImage { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey("MeasurementUnit")]
        public int MeasurementUnitId { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }

        public virtual ICollection<ProductImage> Images { get; set; }
    }
}
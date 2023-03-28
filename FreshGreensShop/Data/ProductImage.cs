using System.ComponentModel.DataAnnotations.Schema;

namespace FreshGreensShop.Data
{
    [Table("product_images")]
    public class ProductImage : BaseEntity
    {
        public string ImageUrl { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreshGreensShop.Data
{
    [Table("categories")]
    public class Category : BaseEntity
    {
        public virtual ICollection<Product> Products { get; set; }
        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
}
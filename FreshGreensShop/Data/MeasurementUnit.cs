using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreshGreensShop.Data
{
    [Table("measurement_units")]
    public class MeasurementUnit : BaseEntity
    {
        public virtual ICollection<Product> Products { get; set; }
        public MeasurementUnit()
        {
            Products = new HashSet<Product>();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BingeShop.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }
        public virtual string Brand { get; set; }
        public virtual int Quatity { get; set; }
        public virtual string Review { get; set; }
        public virtual string Category { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual string ProductImage { get; set; }
        public virtual string Color { get; set; }
    }
}

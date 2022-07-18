using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ThaSaoShop.Models
{
    [Table("Buy")]
    public partial class Buy
    {
        public int BuyId { get; set; }

        public int Price { get; set; }

        public int ProductId { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        public virtual Product Product { get; set; }

        public virtual User User { get; set; }
    }
}

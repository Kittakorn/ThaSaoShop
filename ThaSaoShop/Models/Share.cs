using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ThaSaoShop.Models
{
    [Table("Share")]
    public partial class Share
    {
        public int ShareId { get; set; }

        public int MemberId { get; set; }

        public int Amount { get; set; }

        public DateTime Date { get; set; }

        public bool Type { get; set; }

        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        public virtual Member Member { get; set; }

        public virtual User User { get; set; }
    }
}

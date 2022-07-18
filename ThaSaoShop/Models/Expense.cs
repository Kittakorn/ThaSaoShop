using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ThaSaoShop.Models
{
    [Table("Expense")]
    public partial class Expense
    {
        public int ExpenseId { get; set; }

        public int ExpenseCategoryId { get; set; }

        [Column(TypeName = "text")]
        public string Detail { get; set; }

        public DateTime Date { get; set; }

        public int Price { get; set; }

        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        public virtual ExpenseCategory ExpenseCategory { get; set; }

        public virtual User User { get; set; }
    }
}

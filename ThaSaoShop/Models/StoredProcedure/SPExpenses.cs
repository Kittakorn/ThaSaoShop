using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaSaoShop.Models.StoredProcedure
{
    public class SPExpenses
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Total { get; set; }
    }
}

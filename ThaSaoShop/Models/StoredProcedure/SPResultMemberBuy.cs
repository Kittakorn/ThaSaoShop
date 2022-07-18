using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaSaoShop.Models.StoredProcedure
{
    public class SPResultMemberBuy
    {
        public int? MemberId { get; set; }
        public bool IsMember { get; set; }
        public bool IsGroup { get; set; }
        public int? Total { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int? Share { get; set; }
        public string VillageName { get; set; }
    }
}

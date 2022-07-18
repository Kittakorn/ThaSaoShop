using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaSaoShop.Models.StoredProcedure
{
    public class SPResultShare
    {
        public int MemberId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Pluse { get; set; }
        public int Remove { get; set; }
    }
}

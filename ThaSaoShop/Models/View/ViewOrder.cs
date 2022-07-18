using System;

namespace ThaSaoShop.Models.View
{
    public class ViewOrder
    {
        public int? OrderId { get; set; }
        public DateTime Date { get; set; }
        public int? MemberId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int? Count { get; set; }
        public int? Sum { get; set; }
    }
}

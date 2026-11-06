using System;
using System.Collections.Generic;
using System.Text;

namespace Order_System.Shared
{
    public class Coupon
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public decimal DiscountAmount { get; set; }
        public DateTime ExpirationDate { get; set; }

    }
}

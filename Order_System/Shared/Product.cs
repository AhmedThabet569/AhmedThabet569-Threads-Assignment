using System;
using System.Collections.Generic;
using System.Text;

namespace Order_System.Shared
{
    public class Product
    {
        public int Id { get;  set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public decimal WeightKg { get; set; }

    }
}

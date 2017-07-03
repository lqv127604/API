using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCI
{
    public class OrderedItem
    {
        public long OrderID { get; set; }

        public long ItemID { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }
    }
}
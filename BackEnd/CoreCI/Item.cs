using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCI
{
    public class Item
    {
        public long _id { get; set; }

        public string SupplierID { get; set; }

        public string VendorID { get; set; }

        public string Name { get; set; }

        public string Sku { get; set; }

        public string SalePrice { get; set; }

        public string RealPrice { get; set; }

        public string Description { get; set; }

        public string Details { get; set; }

        public long CreatedBy { get; set; }

        public int CreatedAt { get; set; }

        public long ModifiedBy { get; set; }

        public int ModifiedAt { get; set; }
    }
}
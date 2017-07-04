using System.Collections.Generic;

namespace CoreCI
{
    public class Item
    {
        public long _id { get; set; }

        /// <summary>
        /// Khóa ngoại trên Supplier
        /// </summary>
        public string SupplierID { get; set; }

        /// <summary>
        /// Khóa ngoại trên Vendor
        /// </summary>
        public string VendorID { get; set; }

        /// <summary>
        /// Khóa ngoại trên Category
        /// </summary>
        public HashSet<string> Categories { get; set; }

        public string Name { get; set; }

        public string Sku { get; set; }

        public int SalePrice { get; set; }

        public int RealPrice { get; set; }

        public string Description { get; set; }

        public string Details { get; set; }

        public long CreatedBy { get; set; }

        public int CreatedAt { get; set; }

        public long ModifiedBy { get; set; }

        public int ModifiedAt { get; set; }
    }
}
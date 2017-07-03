using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCI
{
    public class Group
    {
        public string _id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string SystemPermission { get; set; }

        public string VendorPermission { get; set; }

        public string ItemPermission { get; set; }

        public string ResourcePermission { get; set; }

        public long CreatedBy { get; set; }

        public int CreatedAt { get; set; }

        public long ModifiedBy { get; set; }

        public int ModifiedAt { get; set; }
    }
}
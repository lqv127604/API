using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCI
{
    public class Category
    {
        public string _id { get; set; }

        public string Parent { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public long CreatedBy { get; set; }

        public int CreatedAt { get; set; }

        public long ModifiedBy { get; set; }

        public int ModifiedAt { get; set; }
    }
}
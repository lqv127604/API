using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCI
{
    internal class Resource
    {
        public long _id { get; set; }

        public long UserId { get; set; }

        public string StoredAt { get; set; }

        public string Filename { get; set; }

        public string Details { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public string Mime { get; set; }

        public long Size { get; set; }

        public long CreatedBy { get; set; }

        public int CreatedAt { get; set; }

        public long ModifiedBy { get; set; }

        public int ModifiedAt { get; set; }
    }
}
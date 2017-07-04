﻿namespace CoreCI
{
    public class Category
    {
        public string _id { get; set; }

        /// <summary>
        /// Khóa ngoại Categeries
        /// </summary>
        public string Parent { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public long CreatedBy { get; set; }

        public int CreatedAt { get; set; }

        public long ModifiedBy { get; set; }

        public int ModifiedAt { get; set; }
    }
}
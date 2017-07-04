using System.Collections.Generic;

namespace CoreCI
{
    public class User
    {
        public long _id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Fullname { get; set; }

        public string Birthday { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public int PasswordChangedAt { get; set; }

        public int CreatedAt { get; set; }

        /// <summary>
        /// Khóa ngoại trên bảng Groups
        /// </summary>
        public HashSet<long> Groups { get; set; }
    }
}
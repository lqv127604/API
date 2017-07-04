namespace CoreCI
{
    public class Session
    {
        public string _id { get; set; }

        /// <summary>
        /// Khóa ngoại với User
        /// </summary>
        public long UserID { get; set; }

        public string Token { get; set; }

        public int Reload { get; set; }

        public string Permissions { get; set; }

        public string IP { get; set; }

        public string Browser { get; set; }

        public int LastVisited { get; set; }
    }
}
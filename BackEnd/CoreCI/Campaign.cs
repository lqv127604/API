using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCI
{
    public class Campaign
    {
        public string _id { get; set; }

        public int StartDate { get; set; }

        public string StartTime { get; set; }

        public int EndDate { get; set; }

        public string EndTime { get; set; }

        public int DayOfWeek { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public long CreatedBy { get; set; }

        public int CreatedAt { get; set; }

        public long ModifiedBy { get; set; }

        public int ModifiedAt { get; set; }
    }
}
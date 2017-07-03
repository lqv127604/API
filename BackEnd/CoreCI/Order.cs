using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCI
{
    public class Order
    {
        public long _id { get; set; }

        public int UserID { get; set; }

        public string DeliveryMethod { get; set; }

        public string PayingMethod { get; set; }

        public string Status { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Note { get; set; }

        public string DiscountCode { get; set; }

        public long CreatedBy { get; set; }

        public int CreatedAt { get; set; }

        public long ModifiedBy { get; set; }

        public int ModifiedAt { get; set; }
    }
}
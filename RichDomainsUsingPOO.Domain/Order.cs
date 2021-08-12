using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomainsUsingPOO.Domain {
    public class Order : Base {
        public DateTime OrderDate {
            get; set;
        }

        public List<OrderItem> OrderItems{
            get; set;
        }

        public Customer Customer {
            get; set;
        }

        //public bool Validate() => OrderItems.Count > 0;

        public override bool Validate() {
            return OrderItems.Count > 0;
        }
    }
}

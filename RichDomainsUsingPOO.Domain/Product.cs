using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomainsUsingPOO.Domain {
    public class Product : Base {
        public string Seller{
            get; set;
        }

        public decimal Price{
            get; set;
        }

        public string Name{
            get; set;
        }

        public DateTime CreatedDate{
            get; set;
        }

        public bool Deleted{
            get; set;
        }

        public DateTime DeletedDate {
            get; set;
        }

        //public bool Validate() => !string.IsNullOrWhiteSpace(Name);

        public override bool Validate() {
            return !string.IsNullOrWhiteSpace(Name);
        }
    }
}

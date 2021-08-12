using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomainsUsingPOO.Domain {
    public abstract class Base {
        public int ID{
            get; set;
        }

        public abstract bool Validate();
    }
}

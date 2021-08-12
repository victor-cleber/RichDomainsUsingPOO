﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomainsUsingPOO.Domain {

    public enum AddressType {
        Comercial = 1,
        Residential = 2
    }

    public class Address :Base {
        public AddressType AddressType {
            get; set;
        }

        public string  PostCode {
            get; set;
        }

        public string  StreetName {
            get; set;
        }

        public string State {
            get; set;
        }
        public string Number {
            get; set;
        }

        public string Complement {
            get;set;
        }

        //public bool Validate() => !string.IsNullOrWhiteSpace(PostCode);

        public override bool Validate() {
            return !string.IsNullOrWhiteSpace(PostCode);
        }
    }
}

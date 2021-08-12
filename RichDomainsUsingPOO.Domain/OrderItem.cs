using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomainsUsingPOO.Domain {
    public class OrderItem : Base {

        public int ProductId {
            get; set;
        }
        public Product Product {
            get; set;
        }

        public int Quantity {
            get; set;
        }

        public decimal TotalPrice {
            get {
                decimal totalPrice = 0;
                if (Product != null) 
                    totalPrice = Product.Price * Quantity;
                return totalPrice;
            }
        }

       /* public bool Validate (){
            bool isValid = true;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            
            return isValid;
        }*/

        public override bool Validate() {
            bool isValid = true;
            if (Quantity <= 0)
                isValid = false;
            if (ProductId <= 0)
                isValid = false;

            return isValid;
        }
    }
}

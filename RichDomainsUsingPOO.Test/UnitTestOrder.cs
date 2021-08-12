using Microsoft.VisualStudio.TestTools.UnitTesting;
using RichDomainsUsingPOO.Domain;
using System.Collections.Generic;

namespace RichDomainsUsingPOO.Test {

    [TestClass]
    public class UnitTestOrder {
        [TestMethod]
        public void Order_Is_Valid() {
            //Arrange - preparing the scenary
            Order order = new Order() {
                OrderDate = System.DateTime.Today,
                ID = 1234,
                Customer = new Customer() { },
                OrderItems = (new List<OrderItem>() {})                
            };

            bool expected = true;

            //Act
            bool valid_order = order.Validate();

            //Assert
            Assert.AreEqual(expected, valid_order);
        }
    }
}

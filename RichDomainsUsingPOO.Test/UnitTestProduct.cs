using Microsoft.VisualStudio.TestTools.UnitTesting;
using RichDomainsUsingPOO.Domain;
using System.Collections.Generic;

namespace RichDomainsUsingPOO.Test {

    [TestClass]
    public class UnitTestProduct {
        [TestMethod]
        public void Product_Is_Valid() {
            //Arrange - preparing the scenary
            Product product = new Product() {
                Name = "car"
            };

            bool expected = true;

            //Act
            bool valid_order = product.Validate();

            //Assert
            Assert.AreEqual(expected, valid_order);
        }
    }
}

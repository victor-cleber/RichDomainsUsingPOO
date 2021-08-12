using Microsoft.VisualStudio.TestTools.UnitTesting;
using RichDomainsUsingPOO.Domain;
namespace RichDomainsUsingPOO.Test {
    [TestClass]
    public class UnitTestCustomer {
        [TestMethod]
        public void Full_Name_Is_Valid_Test() {
            //Arrange - preparing the scenary
            Customer customer = new Customer() {
                FirstName = "Victor",
                LastName = "Cleber"
            };

            string expected = "Victor Cleber";
            
            //Act
            string result = customer.FullName;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Last_Name_is_Empty() {
            //Arrange - preparing the scenary
            Customer customer = new Customer() {
                FirstName = "Victor",
                LastName = ""
            };

            string expected = "Victor";

            //Act
            string result = customer.FullName;

            //Assert
            Assert.AreEqual(expected, result);

        }
    }
}

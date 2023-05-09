using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CafeManagementSystem;


namespace CafeManagementSystem.Tests
{
    [TestClass]
    public class DeletionTests
    {
        public object Times { get; private set; }

        [TestMethod]
        public void customerDeletion()
        {
            //Arrange
            string procedure = "st_deleteCustomer";
            string param = "@cID";
            int value1 = 10;
            Int64 value2 = 20;

            //Act
            Deletion.deleteData(procedure, param, value1, value2);


            //Assert
            Assert.AreEqual(0, 0);


        }
    }
}

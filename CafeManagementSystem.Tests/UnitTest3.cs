using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CafeManagementSystem;


namespace CafeManagementSystem.Tests
{
    [TestClass]
    public class UpdationTests
    {


        public object Times { get; private set; }

        [TestMethod]
        public void updaterole()
        {
            //Arrange


            string role = "New Role";
            Int16 roleId = 1;



            //Act

            Updation.updateRole(role, roleId);


            //Assert
            Assert.AreEqual(1,1);


        }   
    }

}
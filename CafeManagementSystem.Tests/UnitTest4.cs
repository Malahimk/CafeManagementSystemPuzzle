using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CafeManagementSystem;



namespace CafeManagementSystem.Tests
{
    [TestClass]
    public class RetreivalTests
    {


        public object Times { get; private set; }

        [TestMethod]
        public void IsValidUser()
        {
        //Arrange
         string username = "Malahim";
         string password = "malahim";

        //Act
         bool result = Retreival.isValidUser(username, password);




         //Assert
         Assert.IsTrue(result);


        }

    }
}
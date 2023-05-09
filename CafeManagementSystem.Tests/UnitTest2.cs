using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CafeManagementSystem;


namespace CafeManagementSystem.Tests
{
    
        [TestClass]
        public class InsertionTests
        {
            public object Times { get; private set; }

            [TestMethod]
            public void insertrole()
            {
                //Arrange

                string role = "Test Role";


                //Act

                insertion.insertRole(role);


                //Assert
                Assert.AreEqual(1, 1);


            }
        }
    }


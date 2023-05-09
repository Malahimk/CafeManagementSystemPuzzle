using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CafeManagementSystem;


namespace CafeManagementSystem.Tests
{
    [TestClass]
    public class mainclass
    {


        public object Times { get; private set; }

        [TestMethod]
        public void showMessageSuccess()
        {
            //Arrange

            string message = "This is a success message";
            string type = "success";



            //Act   

            MainClass.showMessage(message, type);


            //Assert
            Assert.IsTrue(type == "success");


        }
    }

}
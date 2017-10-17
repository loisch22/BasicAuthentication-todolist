using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void GetDescriptionTest()
        {
            //Arrange
            var item = new Item();

            item.Description = "Wash the dog";
            //Act
            var result = item.Description;

            //Assert
            Assert.AreEqual("Wash the dog", result);
        }
    }
}

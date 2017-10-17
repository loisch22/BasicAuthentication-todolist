using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Controllers;
using System.Collections.Generic;
using Moq;
using System.Linq;

namespace ToDoList.Tests
{
    [TestClass]
    public class ItemsControllerTest
    {
        Mock<IItemRepository> mock = new Mock<IItemRepository>();

        EFItemRepository db = new EFItemRepository(new TestDbContext());

        private void DbSetup()
        {
            mock.Setup(mock => mock.Items).Returns(new Item[]
            {
                new Item(){ItemId = 1, Description = "Wash the dog"},
                new Item {ItemId = 2, Description = "Do the dishes" },
                new Item {ItemId = 3, Description = "Sweep the floor" }
            }.AsQueryable());  
        }

        [TestMethod]
        public void Mock_GetViewResultIndex_Test()
        {
            DbSetup();
            ItemsController controller = new ItemsController();

            var result = controller.Index();

            Assert.IsInstanceOfType(result, typeof(ActionResult));
        }

        [TestMethod]
        public void Mock_IndexListOfItems_Test()
        {   
            DbSetup();
            ViewResult indexView = new ItemsController(mock.Object).Index() as ViewResult;

            var result = indexView.ViewData.Model;

            Assert.IsInstanceOfType(result, typeof(List<Item>));
        }

        [TestMethod]
        public void Mock_ConfirmEntry_Test()
        {
            DbSetup();
            ItemsController controller = new ItemsController();
            Item testItem = new Item();
            testItem.Description = "Wash the dog";
            testItem.ItemId = 1;

            ViewResult indexView = new ItemsController().Index() as ViewResult;
            var collection = indexView.ViewData.Model as List<Item>;

            CollectionAssert.Contains(collection, testItem);
        }

        [TestMethod]
        public void DB_CreateNewEntry_Test()
        {
            // Arrange
            ItemsController controller = new ItemsController(db);
            Item testItem = new Item();
            testItem.Description = "TestDb Item";

            // Act
            controller.Create(testItem);
            var collection = (controller.Index() as ViewResult).ViewData.Model as List<Item>;

            // Assert
            CollectionAssert.Contains(collection, testItem);
        }
    }
}

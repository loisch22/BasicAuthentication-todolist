using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Controllers;
using System.Collections.Generic;

namespace ToDoList.Tests
{
    [TestClass]
    public class ItemsControllerTest
    {
        [TestMethod]
        public void GetDescriptionTest()
        {
            ItemsController controller = new ItemsController();

            var result = controller.Index();

            Assert.IsInstanceOfType(result, typeof(ActionResult));
        }

        [TestMethod]
        public void Get_ModelList_Index_Test()
        {
            ViewResult indexView = new ItemsController().Index() as ViewResult;

            var result = indexView.ViewData.Model;

            Assert.IsInstanceOfType(result, typeof(List<Item>));
        }

    }
}

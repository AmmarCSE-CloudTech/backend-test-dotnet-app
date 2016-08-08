﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDo.Controllers;

namespace ToDo.Tests
{
    [TestClass]
    public class TestToDoController 
    {
        [TestMethod]
        public void Get_ShouldReturnNull()
        {
            var controller = new ToDoController();

            Assert.AreEqual(null, controller.Get(null));
        }
        [TestMethod]
        public void Get_ShouldReturnToDo()
        {
            var controller = new ToDoController();

            Assert.AreEqual(null, controller.Get(1));
        }
    }
}
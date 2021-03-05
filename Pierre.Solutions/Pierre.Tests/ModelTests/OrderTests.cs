using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
using System.Collections.Generic;
using System;

namespace Pierre.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Item()
        {
            Order newOrder = new Order("TestTitle", "TestDescription", 0, "TestDate");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetTitle_ReturnsTitle_String()
        {
            string title = "Test Order";
            string description = "Test Description";
            int price = 0;
            string date = "Test Date";
            Order newOrder = new Order(title, description, price, date);
            string result = newOrder.Title;
            Assert.AreEqual(title, result);
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string title = "Test Order";
            string description = "Test Description";
            int price = 0;
            string date = "Test Date";
            Order newOrder = new Order(title, description, price, date);
            string result = newOrder.Description;
            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void GetPrice_ReturnsPrice_Int()
        {
            string title = "Test Order";
            string description = "Test Description";
            int price = 0;
            string date = "Test Date";
            Order newOrder = new Order(title, description, price, date);
            int result = newOrder.Price;
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void GetDate_ReturnsDate_String()
        {
            string title = "Test Order";
            string description = "Test Description";
            int price = 0;
            string date = "Test Date";
            Order newOrder = new Order(title, description, price, date);
            string result = newOrder.Date;
            Assert.AreEqual(date, result);
        }

        [TestMethod]
        public void GetId_ReturnsOrderId_Int()
        {
            string title = "Test Order";
            string description = "Test Description";
            int price = 0;
            string date = "Test Date";
            Order newOrder = new Order(title, description, price, date);
            int result = newOrder.Id;
            Assert.AreEqual(1, result);
        }
    }
}
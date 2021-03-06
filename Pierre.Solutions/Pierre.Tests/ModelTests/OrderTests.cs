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

        [TestMethod]
        public void GetAll_ReturnsAllOrders_OrderList()
        {
            string title1 = "Test Order";
            string description1 = "Test Description";
            int price1 = 0;
            string date1 = "Test Date2";
            string title2 = "Test Order2";
            string description2 = "Test Description2";
            int price2 = 0;
            string date2 = "Test Date2";
            Order newOrder1 = new Order(title1, description1, price1, date1);
            Order newOrder2 = new Order(title2, description2, price2, date2);
            List<Order> newList = new List<Order>{newOrder1, newOrder2};
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void ClearAll_ClearsAllOrders_OrderList()
        {
            string title1 = "Test Order";
            string description1 = "Test Description";
            int price1 = 0;
            string date1 = "Test Date2";
            string title2 = "Test Order2";
            string description2 = "Test Description2";
            int price2 = 0;
            string date2 = "Test Date2";
            Order newOrder1 = new Order(title1, description1, price1, date1);
            Order newOrder2 = new Order(title2, description2, price2, date2);
            List<Order> newList = new List<Order>{};
            Order.ClearAll();
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void Find_FindsCorrectOrder_Order()
        {
            string title1 = "Test Order";
            string description1 = "Test Description";
            int price1 = 0;
            string date1 = "Test Date2";
            string title2 = "Test Order2";
            string description2 = "Test Description2";
            int price2 = 0;
            string date2 = "Test Date2";
            Order newOrder1 = new Order(title1, description1, price1, date1);
            Order newOrder2 = new Order(title2, description2, price2, date2);
            Order result = Order.Find(2);
            Assert.AreEqual(newOrder2, result);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
using System.Collections.Generic;
using System;

namespace Pierre.Tests
{
    [TestClass]
    public class VendorTests : IDisposable
    {

        public void Dispose()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor()
        {
            Vendor newVendor = new Vendor("TestName", "TestDescription");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "Test Vendor";
            string description = "Test Description";
            Vendor newVendor = new Vendor(name, description);
            string result = newVendor.Name;
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string name = "Test Vendor";
            string description = "Test Description";
            Vendor newVendor = new Vendor(name, description);
            string result = newVendor.Description;
            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void GetAll_ReturnsAllVendors_VendorList()
        {
            string name1 = "La Provence";
            string name2 = "Mcdonalds";
            string description = "Test description";
            Vendor newVendor1 = new Vendor(name1, description);
            Vendor newVendor2 = new Vendor(name2, description);
            List<Vendor> newList = new List<Vendor>{newVendor1, newVendor2};
            List<Vendor> result = Vendor.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void ClearAll_ClearsAllVendors_VendorList()
        {
            string name1 = "La Provence";
            string name2 = "Mcdonalds";
            string description = "Test description";
            Vendor newVendor1 = new Vendor(name1, description);
            Vendor newVendor2 = new Vendor(name2, description);
            List<Vendor> newList = new List<Vendor>{};
            Vendor.ClearAll();
            List<Vendor> result = Vendor.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetId_ReturnsVendorId_Int()
        {
            string name = "Test Vendor";
            string description = "Test Description";
            Vendor newVendor = new Vendor(name, description);
            int result = newVendor.Id;
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Find_FindsCorrectVendor_Vendor()
        {
            string name1 = "La Provence";
            string name2 = "Mcdonalds";
            string description = "Test description";
            Vendor newVendor1 = new Vendor(name1, description);
            Vendor newVendor2 = new Vendor(name2, description);
            Vendor result = Vendor.Find(2);
            Assert.AreEqual(newVendor2, result);
        }

        [TestMethod]
        public void AddOrder_AssociatesOrderWithVendor_OrderList()
        {
            string name = "Test Vendor";
            string vendorDescription = "Test Description";
            string title = "Test Order";
            string orderDescription = "Test Description";
            int price = 0;
            string date = "Test Date";
            Order newOrder = new Order(title, orderDescription, price, date);
            List<Order> newList = new List<Order> {newOrder};
            Vendor newVendor = new Vendor(name, vendorDescription);
            newVendor.AddOrder(newOrder);
            List<Order> result = newVendor.Orders;
            CollectionAssert.AreEqual(newList, result);
        }
    }
}
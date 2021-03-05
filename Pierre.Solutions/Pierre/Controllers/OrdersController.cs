using Microsoft.AspNetCore.Mvc;
using Pierre.Models;
using System.Collections.Generic;

namespace Pierre.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult New(int vendorId)
        {
            Vendor vendor = Vendor.Find(vendorId);
            return View(vendor);
        }

        // [HttpPost("/orders")]
        // public ActionResult Create(string orderTitle, string orderDescription, int orderPrice, string orderDate)
        // {
        //     Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
        //     return RedirectToAction("Index");
        // }

        [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
        public ActionResult Show(int vendorId, int orderId)
        {
            Order order = Order.Find(orderId);
            Vendor vendor = Vendor.Find(vendorId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("vendor", vendor);
            model.Add("order", order);
            return View(model);

        }

        [HttpPost("/orders/delete")]
        public ActionResult DeleteAll()
        {
            Order.ClearAll();
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using RentalOfPremises.Data.Models;
using RentalOfPremises.Data.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly Cart cart;

        public OrderController(IOrderService orderService, Cart cart)
        {
            this.orderService = orderService;
            this.cart = cart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            cart.ListCartItem = cart.getCartItems();
            if (cart.ListCartItem.Count == 0)
            {
                ModelState.AddModelError("", "Выберите понравившиеся варианты");
            }
            if (ModelState.IsValid)
            {
                orderService.CreateOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заявка успешно обработана";
            return View();
        }
    }
}

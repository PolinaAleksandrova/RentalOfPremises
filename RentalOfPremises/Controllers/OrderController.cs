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
    }
}

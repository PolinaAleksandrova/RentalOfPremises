using Microsoft.AspNetCore.Mvc;
using RentalOfPremises.Data.Models;

using RentalOfPremises.Data.Services.Abstractions;
using RentalOfPremises.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Controllers
{
    public class CartController : Controller
    {
        private readonly IPremisesService _premisesRepository;
        private readonly Cart _cart;

        public CartController(IPremisesService premisesRepository, Cart cart)
        {
            _premisesRepository = premisesRepository;
            _cart = cart;
        }

        public ViewResult Index()
        {
            var items = _cart.getItems();
            _cart.ListCartItem = items;

            var obj = new CartViewModel
            {
                Cart = _cart
            };
            return View(obj);
        }
        public RedirectToActionResult addToCart(int id)
        {
            var item = _premisesRepository.Premises.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _cart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}

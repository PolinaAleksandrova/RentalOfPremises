using Microsoft.AspNetCore.Mvc;
using RentalOfPremises.Data.Services.Abstractions;
using RentalOfPremises.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPremisesService _premisesService;

        public HomeController(IPremisesService allPremises)
        {
            _premisesService = allPremises;
        }
        public ViewResult Index()
        {
            var homePremises = new HomeViewModel
            {
                BestOffer = _premisesService.GetBestOffer
            };
            return View(homePremises);
        }
    }
}

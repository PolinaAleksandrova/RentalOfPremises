using Microsoft.AspNetCore.Mvc;
using RentalOfPremises.Data.Services.Abstractions;
using RentalOfPremises.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Controllers
{
    public class PremisesController : Controller
    {
        private readonly IPremisesService _premisesService;
        private readonly IPremisesCategoryService _premisesCategoryService;

        public PremisesController(IPremisesService allPremises, IPremisesCategoryService allCategories)
        {
            _premisesService = allPremises;
            _premisesCategoryService = allCategories;
        }

        public ViewResult GetList()
        {
            ViewBag.Title = "Page of premises";
            PremisesListViewModel obj = new PremisesListViewModel();
            obj.AllPremises = _premisesService.Premises;
            obj.currCategory = "Premises";

            return View(obj);
        }
    }
}

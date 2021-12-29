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
    public class PremisesController : Controller
    {
        private readonly IPremisesService _premisesService;
        private readonly ICategoryService _premisesCategoryService;

        public PremisesController(IPremisesService allPremises, ICategoryService allCategories)
        {
            _premisesService = allPremises;
            _premisesCategoryService = allCategories;
        }

        [Route("Premises/GetList")]
        [Route("Premises/GetList/{category}")]
        public ViewResult GetList(string category)
        {
            string _category = category;
            IEnumerable<Premises> premises = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                premises = _premisesService.Premises.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("office", category, StringComparison.OrdinalIgnoreCase))
                {
                    premises = _premisesService.Premises.Where(i => i.Category.Name.Equals("Office")).OrderBy(i => i.Id); ;

                    currCategory = "Office";
                }
                else if(string.Equals("RecordingStudio", category, StringComparison.OrdinalIgnoreCase))
                {
                    premises = _premisesService.Premises.Where(i => i.Category.Name.Equals("RecordingStudio")).OrderBy(i => i.Id); ;
                    currCategory = "RecordingStudio";
                }

            }

            var premisesObj = new PremisesListViewModel
            {
                AllPremises = premises,
                currCategory = currCategory
            };

            ViewBag.Title = "Page of premises";

            return View(premisesObj);
        }
    }
}

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
                else if(string.Equals("recordingStudio", category, StringComparison.OrdinalIgnoreCase))
                {
                    premises = _premisesService.Premises.Where(i => i.Category.Name.Equals("RecordingStudio")).OrderBy(i => i.Id); ;
                    currCategory = "RecordingStudio";
                }
                else if (string.Equals("Shevchenkovsky", category, StringComparison.OrdinalIgnoreCase))
                {
                    premises = _premisesService.Premises.Where(i => i.Category.Name.Equals("Shevchenkovsky")).OrderBy(i => i.Id); ;
                    currCategory = "Shevchenkovsky";
                }
                else if (string.Equals("Kyevsky", category, StringComparison.OrdinalIgnoreCase))
                {
                    premises = _premisesService.Premises.Where(i => i.Category.Name.Equals("Kyevsky")).OrderBy(i => i.Id); ;
                    currCategory = "Kyevsky";
                }
                else if (string.Equals("Slobodskoy", category, StringComparison.OrdinalIgnoreCase))
                {
                    premises = _premisesService.Premises.Where(i => i.Category.Name.Equals("Slobodskoy")).OrderBy(i => i.Id); ;
                    currCategory = "Slobodskoy";
                }
                else if (string.Equals("Osnovyansky", category, StringComparison.OrdinalIgnoreCase))
                {
                    premises = _premisesService.Premises.Where(i => i.Category.Name.Equals("Osnovyansky")).OrderBy(i => i.Id); ;
                    currCategory = "Osnovyansky";
                }
                else if (string.Equals("Kholodnogorsky", category, StringComparison.OrdinalIgnoreCase))
                {
                    premises = _premisesService.Premises.Where(i => i.Category.Name.Equals("Kholodnogorsky")).OrderBy(i => i.Id); ;
                    currCategory = "Kholodnogorsky";
                }
                else if (string.Equals("Moskovsky", category, StringComparison.OrdinalIgnoreCase))
                {
                    premises = _premisesService.Premises.Where(i => i.Category.Name.Equals("Moskovsky")).OrderBy(i => i.Id); ;
                    currCategory = "Moskovsky";
                }
                else if (string.Equals("Novobavarsky", category, StringComparison.OrdinalIgnoreCase))
                {
                    premises = _premisesService.Premises.Where(i => i.Category.Name.Equals("Novobavarsky")).OrderBy(i => i.Id); ;
                    currCategory = "Novobavarsky";
                }
                else if (string.Equals("Industrial", category, StringComparison.OrdinalIgnoreCase))
                {
                    premises = _premisesService.Premises.Where(i => i.Category.Name.Equals("Industrial")).OrderBy(i => i.Id); ;
                    currCategory = "Industrial";
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

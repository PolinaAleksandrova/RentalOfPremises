using RentalOfPremises.Data.Models;
using RentalOfPremises.Data.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Data.Services
{
    public class PremisesCategoryService : IPremisesCategoryService
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { Name = "Office", Description = "Room for clerks"},
                    new Category { Name = "Recording studio", Description = "Room for audio production"}
                };
            }
        }
    }
}

using RentalOfPremises.Data.Models;
using RentalOfPremises.Data.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Data.Repository
{
    public class CategoryRepository : ICategoryService
    {
        private readonly AppContext appContext;
        public CategoryRepository(AppContext appContext)
        {
            this.appContext = appContext;
        }

        public IEnumerable<Category> AllCategories => appContext.Category;
    }
}

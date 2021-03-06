using RentalOfPremises.Data.Models;
using RentalOfPremises.Data.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Data.Services
{
    public class CategoryService : ICategoryService
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { Name = "Office", Description = "District1"},
                    new Category { Name = "RecordingStudio", Description = "District2"},
                    new Category { Name = "Shevchenkovsky", Description = "District3"},
                    new Category { Name = "Kyevsky", Description = "District4"},
                    new Category { Name = "Slobodskoy", Description = "District5"},
                    new Category { Name = "Osnovyansky", Description = "District6"},
                    new Category { Name = "Kholodnogorsky", Description = "District7"},
                    new Category { Name = "Moskovsky", Description = "District8"},
                    new Category { Name = "Novobavarsky", Description = "District9"},
                    new Category { Name = "Industrial", Description = "District10"},
                    new Category { Name = "OneRoom", Description = "1Room"},
                    new Category { Name = "TwoRoom", Description = "2Room"},
                    new Category { Name = "ThreeRoom", Description = "3Room"},
                    new Category { Name = "FourRoom", Description = "4Room"},
                    new Category { Name = "ExpensiveFirst", Description = "ExpFirst"},
                    new Category { Name = "CheaperFirst", Description = "CheapFirst"},
                    new Category { Name = "WithProfessionalEquipment", Description = "WithProfessionalEquipment"},
                    new Category { Name = "WithoutProfEquipment", Description = "WithoutProfEquipment"}
                };
            }
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using RentalOfPremises.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Data
{
    public class DBObjects
    {
        public static void Initial(AppContext context)
        {
            if (!context.Category.Any())
                context.Category.AddRange(Categories.Select(context => context.Value));
            if (!context.Category.Any())
            { 
                context.AddRange(
                new Premises
                {
                    Name = "Room1",
                    ShortDescription = "Comfortable",
                    LongDescription = "Very very comfortable",
                    Img = "/img/1.jpg",
                    Price = 2134,
                    IsBestOffer = true,
                    IsAvailable = true,
                    Category = Categories["Office"]
                },
                    new Premises
                    {
                        Name = "Room2",
                        ShortDescription = "Bright",
                        LongDescription = "Very very Bright",
                        Img = "/img/2.jpg",
                        Price = 3421,
                        IsBestOffer = true,
                        IsAvailable = true,
                        Category = Categories["Office"]
                    },
                    new Premises
                    {
                        Name = "Room3",
                        ShortDescription = "Modern",
                        LongDescription = "Very very Modern",
                        Img = "/img/3.jpg",
                        Price = 3434,
                        IsBestOffer = true,
                        IsAvailable = true,
                        Category = Categories["RecordingStudio"]
                    },
                    new Premises
                    {
                        Name = "Room4",
                        ShortDescription = "Cozy",
                        LongDescription = "Very very Cozy",
                        Img = "/img/4.jpg",
                        Price = 2117,
                        IsBestOffer = false,
                        IsAvailable = true,
                        Category = Categories["Office"]
                    },
                    new Premises
                    {
                        Name = "Room5",
                        ShortDescription = "Appointed",
                        LongDescription = "Very very Appointed",
                        Img = "/img/5.jpg",
                        Price = 3443,
                        IsBestOffer = true,
                        IsAvailable = true,
                        Category = Categories["Shevchenkovsky"]
                    }
                );
            }
            context.SaveChanges();
        }
        public static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { Name = "Office", Description = "Room for clerks"},
                        new Category { Name = "RecordingStudio", Description = "Room for audio production"},
                        new Category { Name = "Shevchenkovsky", Description = "District3"},
                        new Category { Name = "Kyevsky", Description = "District4"},
                        new Category { Name = "Slobodskoy", Description = "District5"},
                        new Category { Name = "Osnovyansky", Description = "District6"},
                        new Category { Name = "Kholodnogorsky", Description = "District7"},
                        new Category { Name = "Moskovsky", Description = "District8"},
                        new Category { Name = "Novobavarsky", Description = "District9"},
                        new Category { Name = "Industrial", Description = "District10"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.Name, el);
                    }
                    
                }
                return category;
            }
        }
    }
}

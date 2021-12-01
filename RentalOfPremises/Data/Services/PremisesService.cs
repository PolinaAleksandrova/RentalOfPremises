using RentalOfPremises.Data.Models;
using RentalOfPremises.Data.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Data.Services
{
    public class PremisesService : IPremisesService
    {
        private readonly IPremisesCategoryService _premisesCategoryService = new PremisesCategoryService();
        public IEnumerable<Premises> Premises
        {
            get
            {
                return new List<Premises>
                {
                    new Premises {
                        Name = "Room1",
                        ShortDescription = "Comfortable",
                        LongDescription = "Very very comfortable",
                        Img = "Some outstanding photo1",
                        Price = 2134,
                        IsBestOffer = true,
                        IsAvailable = true,
                        Category = _premisesCategoryService.AllCategories.First()
                    },
                    new Premises {
                        Name = "Room2",
                        ShortDescription = "Bright",
                        LongDescription = "Very very Bright",
                        Img = "Some outstanding photo2",
                        Price = 3421,
                        IsBestOffer = true,
                        IsAvailable = true,
                        Category = _premisesCategoryService.AllCategories.Last()
                    },
                    new Premises {
                        Name = "Room3",
                        ShortDescription = "Modern",
                        LongDescription = "Very very Modern",
                        Img = "Some outstanding photo3",
                        Price = 3434,
                        IsBestOffer = true,
                        IsAvailable = true,
                        Category = _premisesCategoryService.AllCategories.Last()
                    },
                    new Premises {
                        Name = "Room4",
                        ShortDescription = "Cozy",
                        LongDescription = "Very very Cozy",
                        Img = "Some outstanding photo4",
                        Price = 2117,
                        IsBestOffer = false,
                        IsAvailable = true,
                        Category = _premisesCategoryService.AllCategories.First()
                    },
                    new Premises {
                        Name = "Room5",
                        ShortDescription = "Appointed",
                        LongDescription = "Very very Appointed",
                        Img = "Some outstanding photo5",
                        Price = 3443,
                        IsBestOffer = true,
                        IsAvailable = true,
                        Category = _premisesCategoryService.AllCategories.Last()
                    }

                };
            }
        }
        
        public IEnumerable<Premises> GetBestOffer { get; set; }

        public Premises getObjectPremises(int premisesId)
        {
            throw new NotImplementedException();
        }
    }
}

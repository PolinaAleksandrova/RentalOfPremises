using RentalOfPremises.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Premises> BestOffer { get; set; }
    }
}

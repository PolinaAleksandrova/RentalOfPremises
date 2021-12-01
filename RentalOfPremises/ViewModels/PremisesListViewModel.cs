using RentalOfPremises.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.ViewModels
{
    public class PremisesListViewModel
    {
        public IEnumerable<Premises> AllPremises { get; set; }
        public string currCategory { get; set; }
    }
}

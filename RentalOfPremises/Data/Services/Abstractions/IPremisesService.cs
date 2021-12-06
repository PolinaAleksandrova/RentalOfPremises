using RentalOfPremises.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Data.Services.Abstractions
{
    public interface IPremisesService
    {
        IEnumerable<Premises> Premises { get; }
        IEnumerable<Premises> GetBestOffer { get;}
        Premises getObjectPremises(int premisesId);
    }
}

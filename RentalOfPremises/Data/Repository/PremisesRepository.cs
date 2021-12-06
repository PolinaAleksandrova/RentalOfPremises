using Microsoft.EntityFrameworkCore;
using RentalOfPremises.Data.Models;
using RentalOfPremises.Data.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Data.Repository
{
    public class PremisesRepository : IPremisesService
    {
        private readonly AppContext appContext;
        public PremisesRepository(AppContext appContext)
        {
            this.appContext = appContext;
        }
        public IEnumerable<Premises> Premises => appContext.Premises.Include(c => c.Category);

        public IEnumerable<Premises> GetBestOffer => appContext.Premises.Where(p => p.IsBestOffer).Include(c => c.Category);

        public Premises getObjectPremises(int premisesId) => appContext.Premises.FirstOrDefault(p => p.Id == premisesId);
    }
}

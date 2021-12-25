using RentalOfPremises.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Data.Services.Abstractions
{
    interface IOrderService
    {
        void CreateOrder(Order order);
    }
}

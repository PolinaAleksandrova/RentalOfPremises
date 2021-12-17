using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Data.Models
{
    public class CartItem
    {
        public int ItemId { get; set; }
        public Premises Premises { get; set; }
        public int Price { get; set; }

        public string CartId { get; set; }
    }
}

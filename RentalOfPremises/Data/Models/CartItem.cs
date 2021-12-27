using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Data.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public Premises Premises { get; set; }
        public uint Price { get; set; }

        public string CartId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int PremisesId { get; set; }
        public uint Price { get; set; }
        public virtual Premises premises { get; set; }
        public virtual Order order { get; set; }
    }
}

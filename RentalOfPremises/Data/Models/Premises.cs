using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Data.Models
{
    public class Premises
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string Img { get; set; }

        public uint Price { get; set; }

        public bool IsBestOffer { get; set; }

        public bool IsAvailable { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}

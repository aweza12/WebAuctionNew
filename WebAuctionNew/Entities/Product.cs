using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAuctionNew.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
    }
}

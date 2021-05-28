using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAuctionNew.Entities.Enums;

namespace WebAuctionNew.Entities
{
    public class Lot : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal MinBetMove { get; set; }
        public decimal MinPrice { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<Bid> Bids { get; set; }

        //public int BuyerId { get; set; }
        //public Buyer Buyer { get; set; }
        public LotStatus LotStatus { get; set; }
    }
}

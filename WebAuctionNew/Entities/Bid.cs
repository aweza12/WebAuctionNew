using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAuctionNew.Entities.Enums;

namespace WebAuctionNew.Entities
{
    public class Bid : BaseEntity
    {
        public int Id { get; set; }
        public DateTime BetTime { get; set; }
        public decimal BidSum { get; set; }
        public BidStatus BidStatus { get; set; }
        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; }
        public int LotId { get; set; }
        public Lot Lot { get; set; }
    }
}

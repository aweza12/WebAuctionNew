using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAuctionNew.Entities
{
    public class Buyer : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Bid> Bids { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.BL.Models
{
    public class TraderModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LegacyForm { get; set; }
        public string IdentityNumber { get; set; }
        public string ApplicantName { get; set; }
        public string ParticipantName { get; set; }
        public string ParticipantStatus { get; set; }
        public string PhoneNumber { get; set; }
        public string BankName { get; set; }
        public string BankAccountNumber { get; set; }
        public string Swift { get; set; }
        public DateTime AuctionDate { get; set; }
    }
}

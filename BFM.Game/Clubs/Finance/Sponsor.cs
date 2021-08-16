using System;
namespace BFM.Game.Clubs.Finance {
    public class Sponsor {
        public int Amount { get; set; }
        public SponsorIncomeType IncomeType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool AnnualPayment { get; set; }
    }
}

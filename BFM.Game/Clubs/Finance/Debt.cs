using System;
namespace BFM.Game.Clubs.Finance {
    public class Debt {
        public int Amount { get; set; }
        public DebtSource IncomeType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool AnnualPayment { get; set; }
        public int InterestRate { get; set; }
    }
}

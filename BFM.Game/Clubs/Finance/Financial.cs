using System.Collections.Generic;
namespace BFM.Game.Clubs.Finance {
    public class Financial {
        public int Balance { get; }
        public int TransferBudget { get; }
        public int WageBudget { get; }
        public bool InAdministration { get; set; } = false;
        public int AverageTicketPrice { get; set; }
        public int SeasonTicketPrice { get; set; }
        public int NumberOfSeasonTicketHolders { get; set; }
        public List<Sponsor> Sponsors { get; }
        public Debt Debt { get; set; }
        public List<ITransferClause> TransferClauses { get; }
        
    }
}

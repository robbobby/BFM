namespace BFM.Game.Clubs.Finance {
    public class SellOnClauses : ITransferClause { // TODO: SellOnClauses
        public bool PaymentIn { get; set; }
        public TransferClauseType ClauseType { get; set; }
        public int ClauseAmount { get; set; }
        public int Fee { get; set; }
        public Club ClubOwedTo { get; set; }
    }
}

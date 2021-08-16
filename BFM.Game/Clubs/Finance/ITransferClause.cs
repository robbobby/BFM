namespace BFM.Game.Clubs.Finance {
    public interface ITransferClause {
        public bool PaymentIn { get; set; }
        TransferClauseType ClauseType { get; set; }
        int ClauseAmount { get; set; }
        public int Fee { get; set; }
        Club ClubOwedTo { get; set; }
    }
}

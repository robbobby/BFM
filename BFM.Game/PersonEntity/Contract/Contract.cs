using System;
using System.Collections.Generic;
using BFM.Game.Clubs;
using BFM.Game.PersonEntity.Enums;
namespace BFM.Game.PersonEntity.Contract {
    public class Contract { // Refactor for loans later
        private Club club { get; set; }
        public JobRole JobRole { get; set; }
        public JobRole SecondaryJobRole { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime ContractExpires { get; set; }
        public ContractType ContractType { get; set; }
        public int Wage { get; set; }
        public Dictionary<ContractBonusType, int> ContractBonusList { get; } = new Dictionary<ContractBonusType, int>();
        public List<IContractClause> ContractClauses { get; } = new List<IContractClause>();
        public List<ICompetitionBonus> CompetitionBonusList { get; }
        public Transfer FutureTransfer;
    }
}

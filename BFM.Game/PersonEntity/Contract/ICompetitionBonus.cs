using BFM.Game.Competition;
namespace BFM.Game.PersonEntity.Contract {
    public interface ICompetitionBonus {
        CompetitionBonusType GetBonusType();
        ICompetition GetCompetition();
    }
}

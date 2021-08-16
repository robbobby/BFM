namespace BFM.Game.PersonEntity.Attributes {
    public enum PlayingTrait {
                                    // Movement - With the ball
        CutsInside,
        KnocksBallPassOpponent,
        RunsWithBallRarely,
        RunsWithBallOften,
        RunsWithBallDownLeft,
        RunsWithBallDownRight,
        RunsWithBallDownBothFlanks,
        RunsWithBallThroughCentre,
        StopsPlay,
        
                                    // Movement - Off the ball
        ArrivesLateInOpponentsArea,
        ComesDeepToGetBall,
        GetsForwardWhenEverPossible,
        GetsIntoOppositionArea,
        HugsLine,
        LikesToBeatOffsideTrap,
        MovesIntoChannels,
        PlaysWithBackToGoal,
        StaticTargetMan,
        StaysBackAtAllTimes,
        
                                    // Passing
        DictatesTempo,
        LikesToSwitch,
        LooksForPassRatherThanShot,
        PlaysNoThroughBalls,
        PlaysShortSimplePasses,
        TriesKillerBallOften,
        TriesLongRangePasses,
        
                                    // GK - Passing
        UsesLongThrowToStartCounterAttack,
        
                                    // Finishing
        HitsFreeKicksWithPower,
        LikesTRoundKeeper,
        RefrainsFromTakingLongShots,
        ShootsFromDistance,
        ShootsWithPower,
        TriesFirstTimeShots,
        TriesLongRangeFreeKicks,
        
                                    // Discipline
        ArguesWithOfficials,
                                    
                                    // Defending
        DivesIntoTackles,
        DoesNotDiveIntoTackles,
        MarksOpponentTightly,
        
                                    // Technique
        AttemptsToDevelopWeakFoot,
        AvoidsUsingWeakerFoot,
        CurlsBall,
        DwellsOnBall,
        PossesLongFlatThrow,
        TriesToPlayWayOutOfTrouble
    }
}

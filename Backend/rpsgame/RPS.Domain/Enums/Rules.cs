namespace RPS.Domain.Enums
{
    using System.ComponentModel;
    using System;
    
    public enum Rules
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2
    }

    public enum Errors
    {
        [Description("WrongNumberOfPlayersError")]
        wrongNumberOfPlyersError = 3,
        [Description("NoSuchStrategyError")]
        noSuchStrategyError = 4,
        [Description("WrongMatchPerRound")]
        WrongMatchPerRound = 5,
        [Description("BadFormedTournament")]
        BadFormedTournament = 6
    }
}
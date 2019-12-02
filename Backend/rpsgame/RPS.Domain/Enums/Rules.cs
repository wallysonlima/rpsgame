namespace RPS.Domain.Enums
{
    using System.ComponentModel;
    using System;
    
    public enum Rules
    {
        [Description("R")]
        rock = 0,
        [Description("P")]
        paper = 1,
        [Descriptiion("S")]
        scissors = 2
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
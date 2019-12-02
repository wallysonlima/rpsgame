namespace RPS.Domain.Enums
{
    using System.ComponentModel;
    using System;
    
    public enum Rules
    {
        R = 0,
        P = 1,
        S = 2
    }

    public enum Errors
    {
        wrongNumberOfPlayersError = 3,
        noSuchStrategyError = 4,
        WrongMatchPerRound = 5,
        BadFormedTournament = 6
    }
}
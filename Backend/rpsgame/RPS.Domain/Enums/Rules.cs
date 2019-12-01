namespace RPS.Domain.Enums
{
    public enum Rules
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2
    }

    public enum Errors
    {
        [Description("WrongNumberOfPlayersError")]
        error = 3,
        [Description("NoSuchStrategyError")]
        error = 4,
        [Description("WrongMatchPerRound")]
        error = 5,
        [Description("BadFormedTournament")]
        error = 6
    }
}